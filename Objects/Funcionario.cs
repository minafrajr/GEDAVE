/***********************************************************************
 * Classe:  Funcionario.cs
 * Proprietário:  Carlos
 * Finalidade: Definição da classe Funcionario
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects
{
    public class Funcionario
    {
        private int CodigoFuncionario;
        private string Sobrenome;
        private string Nome;
        private string Cargo;
        private string Tratamento;
        private DateTime DataNascimento;
        private DateTime DataContratacao;
        private string Endereco;
        private string Cidade;
        private string Regiao;
        private string Cep;
        private string Pais;
        private string TelefoneResFuncionario;
        private string Ramal;
        private string Foto;
        private string Observacao;
        private string Supervisor;

        public int _CodigoFuncionario
        {
            get
            {
                return CodigoFuncionario;
            }
            set
            {
                if (this.CodigoFuncionario != value)
                    this.CodigoFuncionario = value;
            }
        }

        public string _Sobrenome
        {
            get
            {
                return Sobrenome;
            }
            set
            {
                if (this.Sobrenome != value)
                    this.Sobrenome = value;
            }
        }

        public string _Nome
        {
            get
            {
                return Nome;
            }
            set
            {
                if (this.Nome != value)
                    this.Nome = value;
            }
        }

        public string _Cargo
        {
            get
            {
                return Cargo;
            }
            set
            {
                if (this.Cargo != value)
                    this.Cargo = value;
            }
        }

        public string _Tratamento
        {
            get
            {
                return Tratamento;
            }
            set
            {
                if (this.Tratamento != value)
                    this.Tratamento = value;
            }
        }

        public DateTime _DataNascimento
        {
            get
            {
                return DataNascimento;
            }
            set
            {
                if (this.DataNascimento != value)
                    this.DataNascimento = value;
            }
        }

        public DateTime _DataContratacao
        {
            get
            {
                return DataContratacao;
            }
            set
            {
                if (this.DataContratacao != value)
                    this.DataContratacao = value;
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

        public string _TelefoneResFuncionario
        {
            get
            {
                return TelefoneResFuncionario;
            }
            set
            {
                if (this.TelefoneResFuncionario != value)
                    this.TelefoneResFuncionario = value;
            }
        }

        public string _Ramal
        {
            get
            {
                return Ramal;
            }
            set
            {
                if (this.Ramal != value)
                    this.Ramal = value;
            }
        }

        public string _Foto
        {
            get
            {
                return Foto;
            }
            set
            {
                if (this.Foto != value)
                    this.Foto = value;
            }
        }

        public string _Observacao
        {
            get
            {
                return Observacao;
            }
            set
            {
                if (this.Observacao != value)
                    this.Observacao = value;
            }
        }

        public string _Supervisor
        {
            get
            {
                return Supervisor;
            }
            set
            {
                if (this.Supervisor != value)
                    this.Supervisor = value;
            }
        }

    }
}