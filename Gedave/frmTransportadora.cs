using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gedave
{
	public partial class frmTransportadora : Gedave.frmBase
	{
		public frmTransportadora()
		{
			InitializeComponent();
			CarregarDados();
			Vercodigo(false);
		}

		
		
		#region Transação com o banco de dados
		/// <summary>
		/// Salva uma transportadora no banco de dados
		/// </summary>
		/// <returns></returns>
		protected override bool Adicionar()
		{
			bool salvar = false;

			AcessoDadosTransportadora Transportadora = new AcessoDadosTransportadora();

			
			Transportadora.NomeEmpresaTransp = txt_nome.Text;
			Transportadora.TelefoneTransp = msk_telefone.Text;
			Transportadora.Bairro = txt_bairro.Text;
			Transportadora.Cep = msk_cep.Text;
			Transportadora.Cidade = txt_cidade.Text;
			Transportadora.Logradouro = txt_logradouro.Text;
			Transportadora.Numero = txt_numero.Text;
			Transportadora.Pais = cbo_pais.Text;
			Transportadora.Região = cbo_regiao.Text;
			Transportadora.Tipologradouro = cbo_tipolograd.Text;

			salvar = Transportadora.salvar(true);

			return salvar;
		}

		/// <summary>
		/// Atualiza os dados de uma transportadora no banco de dados
		/// </summary>
		/// <returns></returns>
		protected override bool Atualizar()
		{
			bool atualizar = false;

			AcessoDadosTransportadora Transportadora = new AcessoDadosTransportadora();

			Transportadora.CodigoTransportadora = Convert.ToInt32(lbl_codigo2.Text);
			Transportadora.NomeEmpresaTransp = txt_nome.Text;
			Transportadora.TelefoneTransp = msk_telefone.Text;
			Transportadora.Cep = msk_cep.Text;
			Transportadora.Cidade = txt_cidade.Text;
			Transportadora.Logradouro = txt_logradouro.Text;
			Transportadora.Numero = txt_numero.Text;
			Transportadora.Pais = cbo_pais.Text;
			Transportadora.Região = cbo_regiao.Text;
			Transportadora.Tipologradouro = cbo_tipolograd.Text;

			atualizar = Transportadora.salvar(false);

			return atualizar;
		}
		/// <summary>
		/// Deleta uma tranportadora do banco de dados
		/// </summary>
		/// <returns></returns>
		protected override bool Deletar()
		{
			bool deletar = false;

			AcessoDadosTransportadora Transportadora = new AcessoDadosTransportadora();

			if (MessageBox.Show("Deseja excluir a transportadora "+txt_nome.Text.ToUpper()+"?","Gedave",MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
			{
				Transportadora.CodigoTransportadora = Convert.ToInt32(lbl_codigo2.Text);

				deletar = Transportadora.delete();
			}

			return deletar;
		}

		/// <summary>
		/// Procura uma transportadora no banco de dados a partir de um nome
		/// </summary>
		/// <returns></returns>
		protected override bool Localizar()
		{
			bool localizar = false;

			if (!txt_nome.Enabled)
			{
				txt_nome.Enabled = true;
				txt_nome.Focus();

				localizar = true;
			}
			else
			{
				AcessoDadosTransportadora Transportadora = new AcessoDadosTransportadora();

				dgv_dados.DataSource = Transportadora.pesquisaNome(txt_nome.Text);
				dgv_dados.Refresh();

				localizar = true;
			}

			return localizar;
		}

		protected override void CarregarDados()
		{
			AcessoDadosTransportadora Transportadora = new AcessoDadosTransportadora();

			dgv_dados.DataSource = Transportadora.CarregaDados();
		}

	#endregion  

		#region Controle do formulario

		/// <summary>
		/// Repassa as informações da tranportadora para o campos do formulário
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgv_dados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Vercodigo(true);

			lbl_codigo2.Text = dgv_dados[0, dgv_dados.CurrentCellAddress.Y].Value.ToString();
			txt_nome.Text = dgv_dados[1, dgv_dados.CurrentCellAddress.Y].Value.ToString();
			msk_telefone.Text = dgv_dados[2, dgv_dados.CurrentCellAddress.Y].Value.ToString();
			cbo_tipolograd.ResetText();
			cbo_tipolograd.SelectedText = dgv_dados[3, dgv_dados.CurrentCellAddress.Y].Value.ToString();
			txt_logradouro.Text = dgv_dados[4, dgv_dados.CurrentCellAddress.Y].Value.ToString();
			txt_numero.Text = dgv_dados[5, dgv_dados.CurrentCellAddress.Y].Value.ToString();
			txt_bairro.Text = dgv_dados[7, dgv_dados.CurrentCellAddress.Y].Value.ToString();
			txt_cidade.Text = dgv_dados[8, dgv_dados.CurrentCellAddress.Y].Value.ToString();
			cbo_regiao.ResetText();
			cbo_regiao.SelectedText = dgv_dados[9, dgv_dados.CurrentCellAddress.Y].Value.ToString();
			cbo_pais.ResetText();
			cbo_pais.Text = dgv_dados[10, dgv_dados.CurrentCellAddress.Y].Value.ToString();
			msk_cep.Text = dgv_dados[6, dgv_dados.CurrentCellAddress.Y].Value.ToString();
		}

		public void Vercodigo(bool value)
		{
			lbl_codigo2.Visible = value;
			lbl_codigo1.Visible = value;
		}




		#endregion

		private void btn_busca_Click(object sender, EventArgs e)
		{
			try
			{
				BuscaCep CEP = new BuscaCep();

				CEP.buscador(msk_cep.Text, txt_cidade, txt_bairro, txt_logradouro, cbo_tipolograd);

				if (txt_cidade.Text == "\n    ")
				{
					System.Media.SystemSounds.Beep.Play();
					MessageBox.Show("Nao foi encontrado o CEP! Por favor digite-o endereço.", "GEDAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
					System.Media.SystemSounds.Beep.Play();
			}
			catch (Exception erro)
			{
				MessageBox.Show(erro.Message, "GEDAVE");

			}
		}
	}
}
