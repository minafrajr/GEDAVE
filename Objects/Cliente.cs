/***********************************************************************
 * Classe:  Cliente.cs
 * Proprietário:  Carlos
 * Finalidade: Definição da classe Cliente
 ***********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Objects
{
    public class Cliente
    {
        private int CodigoCliente;
        private string NomeEmpresaCliente;
        private string NomeContatoCliente;
        private string CargoContatoCliente;
        private string Endereco;
        private string Cidade;
        private string Regiao;
        private string Cep;
        private string Pais;
        private string Telefone;
        private string Fax;

        public Cliente() { }

        public Cliente(string nomeempresa, string nomecontato, string cargocontato, string endereco, string cidade, string regiao, string cep, string pais, string telfone, string fax)
        {
            this.NomeEmpresaCliente = nomeempresa;
            this.NomeContatoCliente = nomecontato;
            this.CargoContatoCliente = cargocontato;
            this.Endereco = endereco;
            this.Cidade = cidade;
            this.Regiao = regiao;
            this.Cep = cep;
            this.Pais = pais;
            this.Telefone = telfone;
            this.Fax = fax;
            
        }

        public int _CodigoCliente
        {
            get
            {
                return CodigoCliente;
            }
            set
            {
                if (this.CodigoCliente != value)
                    this.CodigoCliente = value;
            }
        }

        public string _NomeEmpresaCliente
        {
            get
            {
                return NomeEmpresaCliente;
            }
            set
            {
                if (this.NomeEmpresaCliente != value)
                    this.NomeEmpresaCliente = value;
            }
        }

        public string _NomeContatoCliente
        {
            get
            {
                return NomeContatoCliente;
            }
            set
            {
                if (this.NomeContatoCliente != value)
                    this.NomeContatoCliente = value;
            }
        }

        public string _CargoContatoCleinte
        {
            get
            {
                return CargoContatoCliente;
            }
            set
            {
                if (this.CargoContatoCliente != value)
                    this.CargoContatoCliente = value;
            }
        }

        public string _Endereco
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

        public string _Regiao
        {
            get
            {
                return Regiao;
            }
            set
            {
                if (this.Regiao != value)
                    this.Regiao = value;
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

    }
}