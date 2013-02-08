/***********************************************************************
 * Classe:  Fornecedor.cs
 * Proprietário:  Carlos
 * Finalidade: Definição da classe Fornecedor
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects
{
    public class Fornecedor
    {
        private int CodigoFornecedor;
        private string NomeFornecedor;
        private string NomeContactForn;
        private string CargoContatoForn;
        private string Endereco;
        private string Cidade;
        private string Cep;
        private string Pais;
        private string Telefone;
        private string Fax;
        private string Homepage;

        public int _CodigoFornecedor
        {
            get
            {
                return CodigoFornecedor;
            }
            set
            {
                if (this.CodigoFornecedor != value)
                    this.CodigoFornecedor = value;
            }
        }

        public string _NomeFornecedor
        {
            get
            {
                return NomeFornecedor;
            }
            set
            {
                if (this.NomeFornecedor != value)
                    this.NomeFornecedor = value;
            }
        }

        public string _NomeContactForn
        {
            get
            {
                return NomeContactForn;
            }
            set
            {
                if (this.NomeContactForn != value)
                    this.NomeContactForn = value;
            }
        }

        public string _CargoContatoForn
        {
            get
            {
                return CargoContatoForn;
            }
            set
            {
                if (this.CargoContatoForn != value)
                    this.CargoContatoForn = value;
            }
        }

        public string _Enderreco
        {
            get
            {
                return Endereco;
            }
            set
            {
                if (this.Endereco != value)
                    this.Endereco = value;
            }
        }

        public string _Cidade
        {
            get
            {
                return Cidade;
            }
            set
            {
                if (this.Cidade != value)
                    this.Cidade = value;
            }
        }

        public string _Cep
        {
            get
            {
                return Cep;
            }
            set
            {
                if (this.Cep != value)
                    this.Cep = value;
            }
        }

        public string _Pais
        {
            get
            {
                return Pais;
            }
            set
            {
                if (this.Pais != value)
                    this.Pais = value;
            }
        }

        public string _Telefone
        {
            get
            {
                return Telefone;
            }
            set
            {
                if (this.Telefone != value)
                    this.Telefone = value;
            }
        }

        public string _Fax
        {
            get
            {
                return Fax;
            }
            set
            {
                if (this.Fax != value)
                    this.Fax = value;
            }
        }

        public string _Homepage
        {
            get
            {
                return Homepage;
            }
            set
            {
                if (this.Homepage != value)
                    this.Homepage = value;
            }
        }

    }
}