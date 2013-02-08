using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Persistencia.dsGedaveTableAdapters;

namespace Gedave
{

    public partial class frmPedidos2 : Form
    {
        List<AcessoDadosDetalhesPedidos> ListadeCompras = new List<AcessoDadosDetalhesPedidos>();//armazernará todos os pedidos selecionados pelo cliente.
        bool concluir = false;
        int codigocliente;

        public frmPedidos2()
        {
            InitializeComponent();

            AcessoDadosPedidos Pedidos = new AcessoDadosPedidos();

            Pedidos.salvar(true); //para pegar o Código Identificador da tabela pedidos

        }

        /// <summary>
        /// Load do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPedidos2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsComboBox.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.dsComboBox.Fornecedores);
            // TODO: esta linha de código carrega dados na tabela 'dsComboBox.Categorias'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriasTableAdapter.Fill(this.dsComboBox.Categorias);
            // TODO: esta linha de código carrega dados na tabela 'dsComboBox.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.dsComboBox.Produtos);
            // TODO: esta linha de código carrega dados na tabela 'dsComboBox.Funcionários'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.dsComboBox.Funcionários);
            // TODO: esta linha de código carrega dados na tabela 'dsComboBox.Transportadoras'. Você pode movê-la ou removê-la conforme necessário.
            this.transportadorasTableAdapter.Fill(this.dsComboBox.Transportadoras);

        }

        /// <summary>
        /// Carrega os dados do banco de acordo com a categoria selecionada no combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void meuComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_itens.Visible = true;
            AcessoDadosProdutos produtos = new AcessoDadosProdutos();
            AcessoDadosDetalhesPedidos DetalhesPedidos = new AcessoDadosDetalhesPedidos();

            dgv_itens.DataSource = null;//para limpar qualquer categoria selecionada antes

            dgv_itens.DataSource = DetalhesPedidos.CarregaDados(cbo_categoria.Text);

        }

        /// <summary>
        /// Funcionalidade do botão sair
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            if (concluir)
                this.Close();
            else
            {
                if (MessageBox.Show("A venda ainda não foi efetuada.\nDeseja cancelar o processo de venda atual e fechar o formulário?", "GEDAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    this.Close();
                }
                else
                    tab_vendas_Selected(null, null);//retorna ao formulário
            }

        }

        /// <summary>
        /// Habilita ou desabilita o botão de concluir o pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab_vendas_Selected(object sender, TabControlEventArgs e)
        {
            if (tab_vendas.SelectedIndex == 2)
            {
                AcessoDadosPedidos pedido = new AcessoDadosPedidos();
                lbl_numeropedido.Text = pedido.UltimoPedido().ToString();

                btn_excluirpedido.Visible = false;
                btn_concluirpedido.Enabled = true;
                btn_comprador.Visible = false;
            }
            else if (tab_vendas.SelectedIndex == 1)
            {
                btn_excluirpedido.Visible = true;
                btn_comprador.Visible = true;
                btn_concluirpedido.Enabled = false;
            }
            else
            {
                btn_excluirpedido.Visible = false;
                btn_concluirpedido.Enabled = false;
                btn_comprador.Visible = true;
            }
        }


        /// <summary>
        /// transferindo os dados do DataGridView para a "lista de compras"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_itens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_itens.Columns["Selecao"].Index)
            {
                dgv_itens.EndEdit();//finaliza a edição do data gridview

                bool repetido = false; //marcador se o item está repetido na lista de compra

                try
                {
                    AcessoDadosPedidos Pedidos = new AcessoDadosPedidos();
                    AcessoDadosDetalhesPedidos DetalhesPedidos = new AcessoDadosDetalhesPedidos();

                    DetalhesPedidos.NumeroPedido = Pedidos.UltimoPedido();
                    DetalhesPedidos.CodigoProduto = short.Parse(dgv_itens[1, dgv_itens.CurrentCellAddress.Y].Value.ToString());
                    DetalhesPedidos.NomeProduto = dgv_itens[2, dgv_itens.CurrentCellAddress.Y].Value.ToString();
                    DetalhesPedidos.Descricao = dgv_itens[4, dgv_itens.CurrentCellAddress.Y].Value.ToString();
                    DetalhesPedidos.PrecoUnitario = Convert.ToDecimal(dgv_itens[3, dgv_itens.CurrentCellAddress.Y].Value.ToString());

                    frmSolicitaQtdePreco frm = new frmSolicitaQtdePreco(); //abir a caixa de diálogo solicitando a quantidade e o desconto.

                    if (frm.ShowDialog().Equals(DialogResult.OK))
                    {
                        DetalhesPedidos.Quantidade = frm.quantidade;
                        DetalhesPedidos.Desconto = frm.desconto / 100;
                    }

                    if (ListadeCompras.Count != 0)
                    {
                        for (int i = 0; i < ListadeCompras.Count; i++)
                        {
                            if (((AcessoDadosDetalhesPedidos)ListadeCompras[i]).CodigoProduto == Convert.ToInt32(dgv_itens[1, dgv_itens.CurrentCellAddress.Y].Value.ToString()))
                            {
                                repetido = true;
                                MessageBox.Show("O item selecionado já consta no pedido!\n Exclua-o na conferência dos pedidos e inclua-o novamente\n se desejar alterar a quantidade ou desconto", "Gedave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    if (!repetido)
                        ListadeCompras.Add(DetalhesPedidos);
                }
                catch (Exception erro)
                {

                    MessageBox.Show("Erro: " + erro.Message, "GEDAVE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Abre a guia de selecionar produtos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Novopedido_Click(object sender, EventArgs e)
        {
            tab_vendas.SelectedIndex = 0;
            tab_itenspedidos.Show();
            lbl_selecionarcategoria.Visible = true;
            cbo_categoria.Visible = true;
            btn_comprador.Visible = true;

        }

        /// <summary>
        /// Conferir os itens do pedido atual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_conferirpedidos_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_itens.DataSource = null; //para apagar do DataGridView de seleção de produtos todos os registros que já foram selecionados.
                cbo_categoria.SelectedIndex = 0;//retorna a combobox ao primeiro texto.

                lbl_totalparcial.Text = string.Format("R$ {0:0.00}", TotalLista());

                if (ListadeCompras.Count > 0)
                {
                    tab_vendas.SelectedIndex = 1;
                    tab_confere.Show();

                    if (dgv_confere.RowCount < ListadeCompras.Count)
                    {
                        dgv_confere.DataSource = null;
                        dgv_confere.DataSource = ListadeCompras;
                    }
                }
                else
                {
                    MessageBox.Show("Não existem iten(s) no pedido.\nClique em novo pedido para selecionar itens", "GEDAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tab_vendas.SelectedIndex = 0;
                    tab_itenspedidos.Show();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "GEDAVE");
            }
        }

        /// <summary>
        /// Cancela o pedido de compra atual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o processo de venda atual?", "GEDAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {
                AcessoDadosPedidos Pedidos = new AcessoDadosPedidos();

                Pedidos.NumeroPedido = Convert.ToInt32(lbl_numeropedido.Text);
                Pedidos.delete();

                ListadeCompras.Clear();
                dgv_itens.DataSource = null;
                dgv_itens.DataSource = null;
                dgv_itens.Visible = false;
                tab_vendas.SelectedIndex = 0;
                tab_itenspedidos.Show();
            }
            else
                tab_vendas_Selected(null, null);

        }

        /// <summary>
        /// Copia o mesmo nome do Cliente para o destinatário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiacliente_Click(object sender, EventArgs e)
        {
            txt_destinatario.Text = txt_cliente.Text;
        }



        /// <summary>
        /// Exclui cada item pedido na lista de conferência
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluirpedido_Click(object sender, EventArgs e)
        {
            dgv_confere.EndEdit();//é necessário encerrar a edição do data grid view

            foreach (DataGridViewRow row in dgv_confere.Rows)
            {
                if (row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                {
                    for (int i = row.Index; i < ListadeCompras.Count; i++)
                    {
                        if (((AcessoDadosDetalhesPedidos)ListadeCompras[i]).CodigoProduto == (int)row.Cells[2].Value && row.Cells[0].Value != null)
                        {
                            ListadeCompras.RemoveAt(i);
                        }
                    }
                }
            }
            dgv_confere.DataSource = null;
            dgv_confere.DataSource = ListadeCompras;

            dgv_confere.Refresh();
        }


        /// <summary>
        /// Salva toda a compra no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_concluirpedido_Click(object sender, EventArgs e)
        {
            if (!VerificaCamposVazios())
            {
                concluir = SalvarDetalhesPedidos();//os itens do pedido são salvos no banco de dados (tabela detalhes dos pedidos) 

                concluir = SalvarPedido();//a venda é salva no banco de dados(Tabela Pedidos) com os dados do cliente


                if (concluir)
                {
                    MessageBox.Show("Pedido salvo com sucesso!", "GEDAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_confere.DataSource = null;
                    dgv_itens.DataSource = null;
                    ListadeCompras.Clear();
                }
                else
                    MessageBox.Show("O pedido não pode ser salvo!", "GEDAVE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
                MessageBox.Show("O pedido não pode ser salvo!\nVerifique se não há campos vazios na identificação\nou no endereço do cliente.", "GEDAVE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Salva os itens selecionados na compra no banco de dados e atualiza o estoque de produtos.
        /// </summary>
        /// <returns></returns>
        public bool SalvarDetalhesPedidos()
        {
            bool salvar = false;

            foreach (AcessoDadosDetalhesPedidos DetalhesPedidos in ListadeCompras)
            {
                DetalhesPedidos.AtualizaEstoque(DetalhesPedidos.CodigoProduto, DetalhesPedidos.Quantidade);
                salvar = DetalhesPedidos.salvar(true);
            }

            return salvar;
        }

        /// <summary>
        /// Salva o pedido no banco de dados com as informações do cliente.
        /// </summary>
        /// <returns></returns>
        public bool SalvarPedido()
        {
            bool salvarpedido = false;

            try
            {
                AcessoDadosPedidos Pedidos = new AcessoDadosPedidos();

                Pedidos.NumeroPedido = Convert.ToInt32(lbl_numeropedido.Text);

                Pedidos.CEPDestino = msk_cep.Text;
                Pedidos.CidadeDestino = txt_cidade.Text;



                Pedidos.CodigoFuncionario = Convert.ToInt32(cbo_funcionario.SelectedValue);
                Pedidos.CodigoTranportadora = Convert.ToInt32(cbo_transportadora.SelectedValue);
                Pedidos.DataEntrega = dtp_entrega.Value;
                Pedidos.DataEnvio = dtp_envio.Value;
                Pedidos.DataPedido = dtp_pedido.Value;
                Pedidos.EnderecoDestiantario = txt_logradouro.Text+", " + txt_numero.Text;
                Pedidos.Frete = Convert.ToDecimal(msk_frete.Text) / 100;
                Pedidos.NomeDestinatario = txt_destinatario.Text;
                Pedidos.PaisDestino = cbo_pais.Text;
                Pedidos.RegiaoDestino = cbo_regiao.Text;
                Pedidos.Total = Convert.ToDecimal(Total());

                if (codigocliente.ToString() != string.Empty)
                {
                    Pedidos.CodigoCliente = codigocliente;

                    salvarpedido = Pedidos.salvar(false);
                }
                else
                    throw new Exception("Erro ao Salvar o pedido!\nVerifique se o cliente foi selecionado.");


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao salvar o pedido.\n" + erro.Message, "GEDAVE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return salvarpedido;
        }


        /// <summary>
        /// Verifica se existem campos vazios no formulário 
        /// </summary>
        /// <returns></returns>
        public bool VerificaCamposVazios()
        {
            bool CampoVazio = false;

            foreach (Component mycomp in grp_identificacao.Controls)
            {
                if (mycomp is MeuComboBox)    // se for um componente personalizado combobox
                {
                    if (((MeuComboBox)mycomp).Text == string.Empty)
                        CampoVazio = true;
                }
                if (mycomp is MeuMskTextBox)   // se for um componente personalizado msktextbox
                {
                    if (((MeuMskTextBox)mycomp).Text == "")
                        CampoVazio = true;
                }
                if (mycomp is MeuTextBox)      // se for um componente personalizado textbox
                {
                    if (((MeuTextBox)mycomp).Text == "")
                        CampoVazio = true;
                }
            }

            foreach (Component mycomp in grp_endereço.Controls)
            {
                if (mycomp is MeuComboBox)    // se for um componente personalizado combobox
                {
                    if (((MeuComboBox)mycomp).Text == string.Empty)
                        CampoVazio = true;
                }

                if (mycomp is MeuTextBox)      // se for um componente personalizado textbox
                {
                    if (((MeuTextBox)mycomp).Text == "")
                        CampoVazio = true;
                }
            }
            return CampoVazio;

        }

        /// <summary>
        /// Direciona para a área de identificação do comprador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_comprador_Click(object sender, EventArgs e)
        {
            lbl_valorvenda.Text = String.Format("R$ {0:0.00}", TotalLista());
            tab_vendas.SelectedIndex = 2;
            btn_concluirpedido.Enabled = true;
            tab_identificacao.Show();
        }

        /// <summary>
        /// Busca o endereço do comprador de acordo com o cep digitado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_busca_Click(object sender, EventArgs e)
        {
            try
            {
                BuscaCep CEP = new BuscaCep();

                CEP.buscador(msk_cep.Text, txt_cidade, txt_bairro, txt_logradouro, cbo_tipolograd);
                if (txt_cidade.Text == "\n    ")
                {
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("Nao foi encontrado o CEP!\nPor favor digite o endereço.", "GEDAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    System.Media.SystemSounds.Beep.Play();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "GEDAVE");
            }
        }

        /// <summary>
        /// Soma todos os valores dos produtos selecionados na lista de compras a partir do banco de dados
        /// </summary>
        /// <returns></returns>
        private double Total()
        {
            AcessoDadosDetalhesPedidos DetalhesPedidos = new AcessoDadosDetalhesPedidos();

            return DetalhesPedidos.SomaPreco(Convert.ToInt32(lbl_numeropedido.Text));
        }

        /// <summary>
        /// Soma todos os valores dos produtos selecionados na lista de compras a partir do array list de compras
        /// </summary>
        /// <returns></returns>
        private decimal TotalLista()
        {
            decimal total = 0;

            foreach (AcessoDadosDetalhesPedidos DetalhesPedidos in ListadeCompras)
            {
                if (DetalhesPedidos.Desconto != 0)
                {
                    total += DetalhesPedidos.Quantidade * (DetalhesPedidos.PrecoUnitario - DetalhesPedidos.PrecoUnitario * Convert.ToDecimal(DetalhesPedidos.Desconto));
                }
                else
                    total += DetalhesPedidos.Quantidade * DetalhesPedidos.PrecoUnitario;

            }

            return total;
        }

        private void btn_localizacliente_Click(object sender, EventArgs e)
        {
            foreach (Component mycomp in grp_endereço.Controls)
            {
                if (mycomp is MeuComboBox)
                {
                    ((MeuComboBox)mycomp).Enabled = true;

                }
                if (mycomp is MeuMskTextBox)
                {
                    ((MeuMskTextBox)mycomp).Enabled = true;

                } if (mycomp is MeuTextBox)
                {
                    ((MeuTextBox)mycomp).Enabled = true;

                }
            }

            foreach (Component mycomp in grp_identificacao.Controls)
            {
                if (mycomp is MeuComboBox)
                {
                    ((MeuComboBox)mycomp).Enabled = true;

                }
                if (mycomp is MeuMskTextBox)
                {
                    ((MeuMskTextBox)mycomp).Enabled = true;

                } if (mycomp is MeuTextBox)
                {
                    ((MeuTextBox)mycomp).Enabled = true;

                }
            }

            frmLocalizaCliente frm = new frmLocalizaCliente();

            frm.ShowDialog();

            codigocliente = frm.CodigoCliente;
            txt_cliente.Text = frm.nomecliente;
        }

        private void btn_novocliente_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();

            frm.Show();
        }



    }
}
