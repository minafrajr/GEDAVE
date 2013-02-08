using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Net;


namespace Gedave
{
    class BuscaCep
    {
        /// <summary>
        /// Faz a pesquisa em um webservice do cep. 
        /// Retorna cidade, bairro, logradouro e tipo de logradouro modificadas.
        /// </summary>
        /// <param name="cep">O CEP a ser pesquisado</param>
        /// <param name="cidade"></param>
        /// <param name="bairro"></param>
        /// <param name="logradouro"></param>
        /// <param name="tipologradouro"></param>
        public void buscador(string cep,  MeuTextBox cidade, MeuTextBox bairro, MeuTextBox logradouro, MeuComboBox tipologradouro)
        {
            XmlTextReader leitor;

            try
            {
                leitor = new XmlTextReader("http://www.toolsweb.com.br/webservice/clienteWebService.php?cep=@cep&formato=xml".Replace("@cep", cep));

                while (leitor.Read())
                {
                    if (leitor.LocalName == "cidade" && leitor.NodeType == XmlNodeType.Element)
                    {
                        leitor.Read();
                        cidade.Text = leitor.Value;
                    }
                    if (leitor.LocalName == "bairro" && leitor.NodeType == XmlNodeType.Element)
                    {
                        leitor.Read();
                        bairro.Text = leitor.Value;
                    }
                    if (leitor.LocalName == "tipoLogradouro" && leitor.NodeType == XmlNodeType.Element)
                    {
                        leitor.Read();
                        tipologradouro.ResetText();
                        tipologradouro.SelectedText = leitor.Value;
                    }
                    if (leitor.LocalName == "logradouro" && leitor.NodeType == XmlNodeType.Element)
                    {
                        leitor.Read();
                        logradouro.Text = " " + leitor.Value;
                    }
                }
            }
            catch (WebException erro)
            {
                throw new WebException ("Não foi possível acessar o WebService!\n"+erro.Message+"\nVerifique sua conexão de rede.");
            }

            return;
        }
    }
}
