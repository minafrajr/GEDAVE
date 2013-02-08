using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistencia;
using Persistencia.dsGedaveTableAdapters;
using Persistencia.dsViewsTableAdapters;
using System.Data;

namespace Gedave
{

    #region Classe Pai. Contém métodos para serem herdados
    /// <summary>
    /// Classe para ser herdada
    /// </summary>
    public class AcessoDados
    {
        //atualizar o objeto
        public virtual bool salvar(bool bInsert)
        {
            return false;
        }
        //deletar o objeto
        public virtual bool delete()
        {
            return false;
        }
        //Retorna um data table
        public virtual DataTable pesquisaID(int nCdGenerico)
        {
            return null;
        }

        //retorna somente uma linha atraves do ID pesquisado
        public virtual DataRow pesquisaID()
        {
            return null;
        }
        // retorna um DataTable com o nome pesquisado
        public virtual DataTable pesquisaNome(string sDsNome)
        {
            return null;
        }
        /// <summary>
        /// Preenche um DataTable com todos os dados
        /// </summary>
        /// <returns>Retorna um DataTable com todos os dados</returns>
        public virtual DataTable CarregaDados()
        {
            return null;
        }
    }
    #endregion

    #region Acesso a dados dos Cliente

    /// <summary>
    /// Classe para acesso aos dados dos clientes.
    /// </summary>
    public class AcessoDadosClientes
    {

        public int CodigoCliente { get; set; }
        public string NomeEmpresaCliente { get; set; }
        public string NomeContatoCliente { get; set; }
        public string CargoContatoCliente { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Regiao { get; set; }
        public string Cep { get; set; }
        public string Pais { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }


        /// <summary>
        /// Salva ou atualiza os dados dos clientes
        /// </summary>
        /// <param name="bInsert">True - atualizar | false - atualizar</param>
        /// <param name="oCliente">Objeto do tipo cliente</param>
        /// <returns></returns>
        public bool salvar(bool bInsert)
        {
            bool bSalvar = false;
            ClientesTableAdapter ta = new ClientesTableAdapter();

            if (bInsert)
                return bSalvar = (ta.Insert(NomeEmpresaCliente, NomeContatoCliente, CargoContatoCliente, Endereco, Cidade, Regiao, Cep, Pais, Telefone, Fax) > 0);
            else
                return bSalvar = (ta.Update(NomeEmpresaCliente, NomeContatoCliente, CargoContatoCliente, Endereco, Cidade, Regiao, Cep, Pais, Telefone, Fax, CodigoCliente)) > 0;
        }

        /// <summary>
        /// Deleta o cliente do bando de dados
        /// </summary>
        /// <param name="oCliente"></param>
        /// <returns></returns>
        public bool delete()
        {
            bool bDeletar = false;

            ClientesTableAdapter ta = new ClientesTableAdapter();

            bDeletar = ta.Delete(CodigoCliente) > 0;

            return bDeletar;

        }

        /// <summary>
        /// Pesquisa o objeto pelo seu ID.
        /// </summary>
        /// <param name="NumeroDoPedido">Código a ser pesquisado</param>
        /// <returns>DataTable</returns>
        public DataTable PesquisaIDCliente(int IdCliente)
        {
            dsGedave.ClientesDataTable dt = new dsGedave.ClientesDataTable();
            ClientesTableAdapter ta = new ClientesTableAdapter();

            dt = ta.PesquisaIDCliente(IdCliente);

            return dt;
        }

        /// <summary>
        /// Pesquisa o objeto pelo seu nome.
        /// </summary>
        /// <returns>DataTable</returns>

        public DataTable PesquisaNomeCliente(string Nome)
        {
            dsGedave.ClientesDataTable dt = new dsGedave.ClientesDataTable();
            ClientesTableAdapter ta = new ClientesTableAdapter();

            dt = ta.PesquisaNomeCliente("%" + Nome + "%");

            return dt;
        }

        /// <summary>
        /// Pesquisa o objeto pelo seu ID.
        /// </summary>
        /// <returns>DataRow</returns>
        public DataRow pesquisaID()
        {
            return this.PesquisaIDCliente(CodigoCliente).Rows[0];//vai retornar a primeira linha do dataTable
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable CarregaDados()
        {
            ClientesTableAdapter ta = new ClientesTableAdapter();
            dsGedave.ClientesDataTable dt = new dsGedave.ClientesDataTable();

            ta.Fill(dt);

            return dt;
        }

        public DataTable PesquisaporContato(string nomecontato)
        {
            ClientesTableAdapter ta = new ClientesTableAdapter();
            dsGedave.ClientesDataTable dt = new dsGedave.ClientesDataTable();

            dt = ta.PesquisaporContato("%"+nomecontato+"%");
            return dt;
        }


        public DataTable PesquisaporCidade(string cidade)
        {
            ClientesTableAdapter ta = new ClientesTableAdapter();
            dsGedave.ClientesDataTable dt = new dsGedave.ClientesDataTable();

            dt = ta.PesquisaporCidade("%" + cidade + "%");
            return dt;
        }
    }

    #endregion

    #region Acesso a dados Categoria

    /// <summary>
    /// Classe de acesso aos dados do objeto.
    /// </summary>
    public class AcessoDadosCategoria : AcessoDados
    {
        public int CodigoCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public string DescricaoCategoria { get; set; }
        public byte[] Figura { get; set; }

        /// <summary>
        /// Salvar ou alterar o objeto.
        /// </summary>
        /// <param name="bInsert">true - atualizar | false - alterar</param>
        /// <returns>bool</returns>
        public override bool salvar(bool bInsert)
        {
            bool salvou = false;
            CategoriasTableAdapter ta = new CategoriasTableAdapter();

            if (bInsert)
                salvou = (ta.Insert(NomeCategoria, DescricaoCategoria, Figura) > 0);
            else
                salvou = (ta.Update(NomeCategoria, DescricaoCategoria, Figura, CodigoCategoria) > 0);

            return salvou;
        }

        /// <summary>
        /// Excluir o objeto.
        /// </summary>
        /// <returns>bool</returns>
        public override bool delete()
        {
            bool deletou = false;

            CategoriasTableAdapter ta = new CategoriasTableAdapter();

            deletou = (ta.Delete(CodigoCategoria) > 0);

            return deletou;
        }

        /// <summary>
        /// Pesquisa o objeto pelo seu ID.
        /// </summary>
        /// <param name="NumeroDoPedido">Código a ser pesquisado</param>
        /// <returns>DataTable</returns>
        public override DataTable pesquisaID(int IDCategoria)
        {
            dsGedave.CategoriasDataTable dt = new dsGedave.CategoriasDataTable();
            CategoriasTableAdapter ta = new CategoriasTableAdapter();

            dt = ta.PesquisaIDCategoria(IDCategoria);

            return dt;
        }

        /// <summary>
        /// Pesquisa o objeto pelo seu nome.
        /// </summary>
        /// <returns>DataTable</returns>
        public override DataTable pesquisaNome(string nome)
        {
            dsGedave.CategoriasDataTable dt = new dsGedave.CategoriasDataTable();
            CategoriasTableAdapter ta = new CategoriasTableAdapter();

            dt = ta.PesquisaNomeCategoria("%" + nome + "%");

            return dt;
        }

        /// <summary>
        /// Pesquisa o objeto pelo seu ID.
        /// </summary>
        /// <returns>DataRow</returns>
        public override DataRow pesquisaID()
        {
            return this.pesquisaID(CodigoCategoria).Rows[0];
        }

        /// <summary>
        /// Carrega os dados do objeto a partir do banco de dados.
        /// </summary>
        /// <returns>DataTable</returns>
        public override DataTable CarregaDados()
        {
            CategoriasTableAdapter ta = new CategoriasTableAdapter();
            dsGedave.CategoriasDataTable dt = new dsGedave.CategoriasDataTable();

            ta.Fill(dt);

            return dt;
        }
    }

    #endregion

    #region Acesso a dados Fornecedor

    /// <summary>
    /// Classe de acesso aos dados do objeto.
    /// </summary>
    public class AcessoDadosFornecedor : AcessoDados
    {

        public int CodigoFornecedor { get; set; }
        public string NomeFornecedor { get; set; }
        public string NomeContactForn { get; set; }
        public string CargoContatoForn { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Pais { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }
        public string Homepage { get; set; }
        public string Regiao { get; set; }

        /// <summary>
        /// Salvar ou alterar o objeto.
        /// </summary>
        /// <param name="bInsert">true - atualizar | false - alterar</param>
        /// <returns>bool</returns>
        public override bool salvar(bool bInsert)
        {
            bool salvou = false;

            FornecedoresTableAdapter ta = new FornecedoresTableAdapter();

            if (bInsert)
                salvou = (ta.Insert(NomeFornecedor, NomeContactForn, CargoContatoForn, Endereco, Cidade, Regiao, Cep, Pais, Telefone, Fax, Homepage) > 0);
            else
                salvou = (ta.Update(NomeFornecedor, NomeContactForn, CargoContatoForn, Endereco, Cidade, Regiao, Cep, Pais, Telefone, Fax, Homepage, CodigoFornecedor) > 0);


            return salvou;
        }

        /// <summary>
        /// Excluir o objeto.
        /// </summary>
        /// <returns>bool</returns>
        public override bool delete()
        {
            bool deletou = false;

            FornecedoresTableAdapter ta = new FornecedoresTableAdapter();

            deletou = (ta.Delete(CodigoFornecedor) > 0);

            return deletou;
        }

        /// <summary>
        /// Pesquisa o objeto pelo seu ID.
        /// </summary>
        /// <param name="NumeroDoPedido">Código a ser pesquisado</param>
        /// <returns>DataTable</returns>
        public override DataTable pesquisaID(int CodigoFornecedor)
        {
            FornecedoresTableAdapter ta = new FornecedoresTableAdapter();
            dsGedave.FornecedoresDataTable dt = new dsGedave.FornecedoresDataTable();

            dt = ta.PesquisaIDFornecedor(CodigoFornecedor);

            return dt;
        }

        /// <summary>
        /// Pesquisa o objeto pelo seu nome.
        /// </summary>
        /// <returns>DataTable</returns>
        public override DataTable pesquisaNome(string NomeFornecedor)
        {
            FornecedoresTableAdapter ta = new FornecedoresTableAdapter();
            dsGedave.FornecedoresDataTable dt = new dsGedave.FornecedoresDataTable();

            dt = ta.PesquisaNomeFornecedor("%" + NomeFornecedor + "%");

            return dt;
        }

        /// <summary>
        /// Pesquisa o objeto pelo seu nome.
        /// </summary>
        /// <returns>DataRow</returns>
        public override DataRow pesquisaID()
        {
            return this.pesquisaID(CodigoFornecedor).Rows[0];
        }

        /// <summary>
        /// Carrega os dados do objeto a partir do banco de dados.
        /// </summary>
        /// <returns>DataTable</returns>
        public override DataTable CarregaDados()
        {
            FornecedoresTableAdapter ta = new FornecedoresTableAdapter();

            dsGedave.FornecedoresDataTable dt = new dsGedave.FornecedoresDataTable();

            ta.Fill(dt);

            return dt;
        }

    }
    #endregion

    #region Acesso a dados Funcionarios

    /// <summary>
    /// Classe de acesso aos dados do objeto.
    /// </summary>
    public class AcessoDadosFuncionarios : AcessoDados
    {

        public int CodigoFuncionario { get; set; }
        public string Sobrenome { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Tratamento { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataContratacao { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Regiao { get; set; }
        public string Cep { get; set; }
        public string Pais { get; set; }
        public string TelefoneResFuncionario { get; set; }
        public string Ramal { get; set; }
        public byte[] Foto { get; set; }
        public string Observacao { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }

        /// <summary>
        /// Salvar ou alterar o objeto.
        /// </summary>
        /// <param name="bInsert">true - atualizar | false - alterar</param>
        /// <returns>bool</returns>
        public override bool salvar(bool bInsert)
        {
            bool salvou = false;

            FuncionariosTableAdapter ta = new FuncionariosTableAdapter();


            if (bInsert)
                salvou = (ta.Insert(Sobrenome, Nome, Cargo, Tratamento, DataNascimento, DataContratacao, Endereco, Cidade, Regiao, Cep, Pais, TelefoneResFuncionario, Ramal, Foto, Observacao, Numero, Bairro) > 0);
            else
                salvou = (ta.Update(Sobrenome, Nome, Cargo, Tratamento, DataNascimento, DataContratacao, Endereco, Cidade, Regiao, Cep, Pais, TelefoneResFuncionario, Ramal, Foto, Observacao, Numero, Bairro, CodigoFuncionario) > 0);

            return salvou;
        }

        /// <summary>
        /// Excluir o objeto.
        /// </summary>
        /// <returns>bool</returns>
        public override bool delete()
        {
            bool deletou = false;

            FuncionariosTableAdapter ta = new FuncionariosTableAdapter();

            deletou = (ta.Delete(CodigoFuncionario) > 0);

            return deletou;
        }

        /// <summary>
        /// Pesquisa o objeto pelo seu ID.
        /// </summary>
        /// <param name="NumeroDoPedido">Código a ser pesquisado</param>
        /// <returns>DataTable</returns>
        public override DataTable pesquisaID(int CodigoFuncionario)
        {
            FuncionariosTableAdapter ta = new FuncionariosTableAdapter();
            dsGedave.FuncionariosDataTable dt = new dsGedave.FuncionariosDataTable();

            dt = ta.PesquisaIDFuncionario(CodigoFuncionario);


            return dt;
        }

        /// <summary>
        /// Pesquisa o objeto pelo seu ID.
        /// </summary>
        /// <returns>DataRow</returns>
        public override DataTable pesquisaNome(string NomeFuncionario)
        {
            FuncionariosTableAdapter ta = new FuncionariosTableAdapter();
            dsGedave.FuncionariosDataTable dt = new dsGedave.FuncionariosDataTable();

            dt = ta.PesquisaNomeFuncionario("%"+NomeFuncionario+"%");


            return dt;
        }


        /// <summary>
        /// Pesquisa o objeto pelo seu nome.
        /// </summary>
        /// <returns>DataRow</returns>
        public override DataRow pesquisaID()
        {
            return this.pesquisaID(CodigoFuncionario).Rows[0];
        }

        /// <summary>
        /// Carrega os dados do objeto a partir do banco de dados.
        /// </summary>
        /// <returns>DataTable</returns>

        public override DataTable CarregaDados()
        {
            FuncionariosTableAdapter ta = new FuncionariosTableAdapter();
            dsGedave.FuncionariosDataTable dt = new dsGedave.FuncionariosDataTable();

            ta.Fill(dt);

            return dt;
        }

        public byte[] GetFoto(int Codigofunc)
        {
            FuncionariosTableAdapter ta = new FuncionariosTableAdapter();

            return ta.GetFoto(Codigofunc);

        }
    }
    #endregion

    #region Acesso a dados dos Produtos

    /// <summary>
    /// Classe de acesso aos dados do objeto.
    /// </summary>
    public class AcessoDadosProdutos : AcessoDados
    {
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public int CodigoFornecedor { get; set; }
        public int CodigoCategoria { get; set; }
        public string QuantidadepUnidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public short UnidadeEstocada { get; set; }
        public short UnidadesPedidas { get; set; }
        public short NiveldeReposicao { get; set; }
        public bool Descontinuado { get; set; }

        /// <summary>
        /// Salvar ou alterar o objeto.
        /// </summary>
        /// <param name="bInsert">true - atualizar | false - alterar</param>
        /// <returns>bool</returns>
        public override bool salvar(bool bInsert)
        {
            bool salvou = false;
            ProdutosTableAdapter ta = new ProdutosTableAdapter();


            if (bInsert)
                salvou = (ta.Insert(NomeProduto, CodigoFornecedor, CodigoCategoria, QuantidadepUnidade, PrecoUnitario, UnidadeEstocada, UnidadesPedidas, NiveldeReposicao, Descontinuado) > 0);
            else
                salvou = (ta.Update(NomeProduto, CodigoFornecedor, CodigoCategoria, QuantidadepUnidade, PrecoUnitario, UnidadeEstocada, UnidadesPedidas, NiveldeReposicao, Descontinuado, CodigoProduto) > 0);


            return salvou;
        }

        /// <summary>
        /// Excluir o objeto.
        /// </summary>
        /// <returns>bool</returns>
        public override bool delete()
        {
            bool deletou = false;

            ProdutosTableAdapter ta = new ProdutosTableAdapter();

            deletou = (ta.Delete(CodigoProduto) > 0);

            return deletou;
        }

        /// <summary>
        /// Pesquisa o objeto pelo seu ID.
        /// </summary>
        /// <param name="NumeroDoPedido">Código a ser pesquisado</param>
        /// <returns>DataTable</returns>
        public override DataTable pesquisaID(int CodProduto)
        {
            ProdutosTableAdapter ta = new ProdutosTableAdapter();
            dsGedave.ProdutosDataTable dt = new dsGedave.ProdutosDataTable();

            dt = ta.PesquisaIDProduto(CodProduto);

            return dt;
        }
        /// <summary>
        /// Pesquisa o objeto pelo seu nome.
        /// </summary>
        /// <returns>DataRow</returns>
        public override DataTable pesquisaNome(string NomeProduto)
        {
            ProdutosTableAdapter ta = new ProdutosTableAdapter();
            dsGedave.ProdutosDataTable dt = new dsGedave.ProdutosDataTable();

            dt = ta.PesquisaNomeProduto("%"+NomeProduto+"%");

            return dt;
        }

        /// <summary>
        /// Carrega os dados do objeto a partir do banco de dados.
        /// </summary>
        /// <returns>DataTable</returns>
        public override DataRow pesquisaID()
        {
            return this.pesquisaID(CodigoProduto).Rows[0];
        }

        /// <summary>
        /// Carrega todos os produtos.
        /// </summary>
        /// <param name="bVer"> Verdadeiro produto disponíveis | produtos indisponíveis</param>
        /// <returns>Data Table com produtos</returns>
        public DataTable CarregaDados(bool bVer)
        {
            VW_ProdutosTableAdapter vwta = new VW_ProdutosTableAdapter();
            dsViews.VW_ProdutosDataTable dtvw = new dsViews.VW_ProdutosDataTable();

            if (bVer)
                dtvw = vwta.Disponibilidade(bVer);
            else
                dtvw = vwta.Disponibilidade(bVer);

            return dtvw;
        }

        /// <summary>
        /// Carrega todos os produtos.
        /// </summary>
        /// <returns></returns>
        public override DataTable CarregaDados()
        {
            VW_ProdutosTableAdapter vwta = new VW_ProdutosTableAdapter();

            dsViews.VW_ProdutosDataTable dtvw = new dsViews.VW_ProdutosDataTable();
            vwta.Fill(dtvw);

            return dtvw;
        }

        public DataTable CarregaDados(string categoria)
        {
            ProdutosTableAdapter ta = new ProdutosTableAdapter();
            dsGedave.ProdutosDataTable dt = new dsGedave.ProdutosDataTable();

            dt = ta.PesquisaProdutosPORCategoria("%" + categoria + "%");

            return dt;
        }

       

    }
    #endregion

    #region Acesso a dados Pedidos
    /// <summary>
    /// Classe de acesso a dados dos pedidos
    /// </summary>
    public class AcessoDadosPedidos : AcessoDados
    {
        public int NumeroPedido { get; set; }
        //public int CodProduto { get; set; }
        public int? CodigoCliente { get; set; }
        public int? CodigoFuncionario { get; set; }
        public DateTime? DataPedido { get; set; }
        public DateTime? DataEntrega { get; set; }
        public DateTime? DataEnvio { get; set; }
        public int? CodigoTranportadora { get; set; }
        public decimal? Frete { get; set; }
        public string NomeDestinatario { get; set; }
        public string EnderecoDestiantario { get; set; }
        public string CidadeDestino { get; set; }
        public string RegiaoDestino { get; set; }
        public string CEPDestino { get; set; }
        public string PaisDestino { get; set; }
        public decimal? Total { get; set; }

        /// <summary>
        /// Salvar ou alterar o objeto.
        /// </summary>
        /// <param name="bInsert">true - salvar novo | false - alterar</param>
        /// <returns>bool</returns>
        public override bool salvar(bool bInsert)
        {
            bool salvou = false;

            PedidosTableAdapter ta = new PedidosTableAdapter();

            if (bInsert)
            {
                

                salvou = (ta.Insert(CodigoCliente, CodigoFuncionario, DataPedido, DataEntrega, DataEnvio, CodigoTranportadora, Frete, NomeDestinatario, EnderecoDestiantario, CidadeDestino, RegiaoDestino, CEPDestino, PaisDestino, Total) > 0);
            }
            else
                salvou = (ta.Update(CodigoCliente, CodigoFuncionario, DataPedido, DataEntrega, DataEnvio, CodigoTranportadora, Frete, NomeDestinatario, EnderecoDestiantario, CidadeDestino, RegiaoDestino, CEPDestino, PaisDestino, Total, NumeroPedido) > 0);
            ;

            return salvou;
        }

        /// <summary>
        /// Excluir o objeto.
        /// </summary>
        /// <returns>bool</returns>
        public override bool delete()
        {
            bool deletou = false;

            PedidosTableAdapter ta = new PedidosTableAdapter();

            deletou = (ta.Delete(NumeroPedido) > 0);

            return deletou;
        }

        /// <summary>
        /// Pesquisa o objeto pelo seu ID.
        /// </summary>
        /// <param name="NumeroDoPedido">Código a ser pesquisado</param>
        /// <returns>DataTable</returns>
        public override DataTable pesquisaID(int NumPedido)
        {
            PedidosTableAdapter ta = new PedidosTableAdapter();

            dsGedave.PedidosDataTable dt = new dsGedave.PedidosDataTable();

            dt = ta.PesquisaIDPedido(NumPedido);

            return dt;

        }
        /// <summary>
        /// Pesquisa o objeto pelo seu ID.
        /// </summary>
        /// <returns>DataRow</returns>
        public override DataRow pesquisaID()
        {
            return this.pesquisaID(NumeroPedido).Rows[0];
        }

        /// <summary>
        /// Carrega os dados do objeto a partir do banco de dados.
        /// </summary>
        /// <returns>DataTable</returns>
        public override DataTable CarregaDados()
        {
            PedidosTableAdapter ta = new PedidosTableAdapter();
            dsGedave.PedidosDataTable dt = new dsGedave.PedidosDataTable();

            ta.Fill(dt);

            return dt;
        }


        public int UltimoPedido()
        {
            PedidosTableAdapter ta = new PedidosTableAdapter();
            int Ultimopedido = Convert.ToInt32(ta.UltimoIDPedido());

            return Ultimopedido;
        }
    }
    #endregion

    #region Acesso a dados dos Detalhes do Pedido
    /// <summary>
    /// Classe de acesso aos dados dos detalhes do pedido (classe associativa)
    /// </summary>
    public class AcessoDadosDetalhesPedidos : AcessoDados
    {
        public int NumeroPedido { get; set; }
        public short CodigoProduto { get; set; }
        public string NomeProduto { get; set; }//Servirá somente para mostrar no momento da compra. Não será armazenado no banco de dados
        public string Descricao { get; set; }//Servirá somente para mostrar no momento da compra. Não será armazenado no banco de dados
        public decimal PrecoUnitario { get; set; }
        public short Quantidade { get; set; }
        public float Desconto { get; set; }


        /// <summary>
        /// Salvar ou alterar os detalhes do pedido
        /// </summary>
        /// <param name="bInsert">true - atualizar | false - alterar</param>
        /// <returns>bool</returns>
        public override bool salvar(bool bInsert)
        {
            PedidosTableAdapter taPedido = new PedidosTableAdapter();

            NumeroPedido = Convert.ToInt32(taPedido.UltimoIDPedido());// para inserir o ID do Pedido como chave primária na tabela DetalhesPedidos

            bool salvou = false;

            Detalhes_do_PedidoTableAdapter ta = new Detalhes_do_PedidoTableAdapter();

            if (bInsert)
                salvou = (ta.Insert(NumeroPedido, CodigoProduto, PrecoUnitario, Quantidade, Desconto) > 0);
            else
                salvou = (ta.Update(PrecoUnitario, Quantidade, Desconto, NumeroPedido, CodigoProduto) > 0);

            return salvou;
        }

        /// <summary>
        /// Excluir o detalhe do pedido.
        /// </summary>
        /// <returns>bool</returns>
        public override bool delete()
        {
            bool deletou = false;

            Detalhes_do_PedidoTableAdapter ta = new Detalhes_do_PedidoTableAdapter();

            deletou = (ta.Delete(NumeroPedido, CodigoProduto) > 0);

            return deletou;
        }

        /// <summary>
        /// Pesquisa o objeto pelo seu ID.
        /// </summary>
        /// <param name="NumeroDoPedido">Código a ser pesquisado</param>
        /// <returns>DataTable</returns>
        public override DataTable pesquisaID(int NumeroDoPedido)
        {
            Detalhes_do_PedidoTableAdapter ta = new Detalhes_do_PedidoTableAdapter();

            dsGedave.Detalhes_do_PedidoDataTable dt = new dsGedave.Detalhes_do_PedidoDataTable();

            dt = ta.PesquisaIDDetalhesPedidos(NumeroDoPedido);

            return dt;
        }

        /// <summary>
        /// Pesquisa o objeto pelo seu ID.
        /// </summary>
        /// <returns>DataRow</returns>
        public override DataRow pesquisaID()
        {
            return this.pesquisaID(NumeroPedido).Rows[0];
        }

        /// <summary>
        /// Carrega os dados dos detalhes
        /// </summary>
        /// <returns>DataTable</returns>
        public override DataTable CarregaDados()
        {
            VW_DetalhesProdutosTableAdapter ta = new VW_DetalhesProdutosTableAdapter();
            dsViews.VW_DetalhesProdutosDataTable dt = new dsViews.VW_DetalhesProdutosDataTable();

            ta.Fill(dt);

            return dt;
        }

        public DataTable CarregaDados(string categoria)
        {
            VW_DetalhesProdutosTableAdapter ta = new VW_DetalhesProdutosTableAdapter();
            dsViews.VW_DetalhesProdutosDataTable dt = new dsViews.VW_DetalhesProdutosDataTable();

            dt = ta.PesquisaPorCategoria("%" + categoria + "%");
            return dt;
        }

        public double SomaPreco(int numeropedido)
        {
            Detalhes_do_PedidoTableAdapter ta = new Detalhes_do_PedidoTableAdapter();
            double total = Convert.ToDouble(ta.SomaPreco(numeropedido));

            return total;
        }


        public void AtualizaEstoque(short CodProduto, short QtdeAdquirida)
        {
            Detalhes_do_PedidoTableAdapter ta = new Detalhes_do_PedidoTableAdapter();

            ta.AtualizaEstoque(CodProduto, QtdeAdquirida);
        }
    }



    #endregion

    #region Acesso a dados Transportadora
    /// <summary>
    /// Classe de acesso aos dados das transportadoras
    /// </summary>
    public class AcessoDadosTransportadora : AcessoDados
    {
        public int CodigoTransportadora { get; set; }
        public string NomeEmpresaTransp { get; set; }
        public string TelefoneTransp { get; set; }
        public string Tipologradouro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Região { get; set; }
        public string Pais { get; set; }


        /// <summary>
        /// Salva ou altera o objeto transportadora.
        /// </summary>
        /// <param name="bInsert">True - atualizar | False - alterar</param>
        /// <returns>bool</returns>
        public override bool salvar(bool bInsert)
        {
            bool salvou = false;

            TransportadorasTableAdapter ta = new TransportadorasTableAdapter();

            if (bInsert)
                salvou = ((ta.Insert(NomeEmpresaTransp, TelefoneTransp, Tipologradouro, Logradouro, Numero, Cep, Bairro, Cidade, Região, Pais) > 0));
            else
                salvou = ((ta.Update(NomeEmpresaTransp, TelefoneTransp, Tipologradouro, Logradouro, Numero, Cep, Bairro, Cidade, Região, Pais, CodigoTransportadora) > 0));

            return salvou;
        }

        /// <summary>
        /// Exclui o objeto transportadora.
        /// </summary>
        /// <returns>bool</returns>
        public override bool delete()
        {
            bool deletou = false;

            TransportadorasTableAdapter ta = new TransportadorasTableAdapter();

            deletou = (ta.Delete(CodigoTransportadora) > 0);

            return deletou;
        }

        /// <summary>
        /// Pesquisa a transportadora a partir de seu código.
        /// </summary>
        /// <param name="CodTranportadora">Código da Transportadora</param>
        /// <returns>DataTable</returns>
        public override DataTable pesquisaID(int CodTranportadora)
        {
            TransportadorasTableAdapter ta = new TransportadorasTableAdapter();
            dsGedave.TransportadorasDataTable dt = new dsGedave.TransportadorasDataTable();

            dt = ta.PesquisaIDTransportadora(CodTranportadora);

            return dt;
        }

        /// <summary>
        /// Pesquisa uma transportadora a partir de seu nome
        /// </summary>
        /// <param name="Nometransportadora">Nome a ser pesquisado</param>
        /// <returns>DataTable</returns>
        public override DataTable pesquisaNome(string Nometransportadora)
        {
            TransportadorasTableAdapter ta = new TransportadorasTableAdapter();
            dsGedave.TransportadorasDataTable dt = new dsGedave.TransportadorasDataTable();

            dt = ta.PesquisaNomeTransportadora("%"+Nometransportadora+"%");

            return dt;
        }

        /// <summary>
        /// Pesquisa a transportadora a partir de seu código.
        /// </summary>
        /// <returns>DataRow conntendo as informações.</returns>
        public override DataRow pesquisaID()
        {
            return this.pesquisaID(CodigoTransportadora).Rows[0];
        }

        public override DataTable CarregaDados()
        {
            TransportadorasTableAdapter ta = new TransportadorasTableAdapter();
            dsGedave.TransportadorasDataTable dt = new dsGedave.TransportadorasDataTable();

            ta.Fill(dt);

            return dt;
        }
    }

    #endregion
}

