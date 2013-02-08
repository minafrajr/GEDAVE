/***********************************************************************
 * Classe:  Pedido.cs
 * Proprietário:  Carlos
 * Finalidade: Definição da classe Pedido
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects
{
    public class Pedido
    {
        private int CodigoProduto;
        private int CodigoCliente;
        private int CodigoFuncionario;
        private DateTime DataPedido;
        private DateTime DataEntrega;
        private DateTime DataEnvio;
        private int CodigoTranportadora;
        private double Frete;
        private string NomeDestinatario;
        private string EnderecoDestiantario;
        private string CidadeDestino;
        private string RegiaoDestino;
        private string CEPDestino;
        private string PaisDestino;
        private double Total;

        public int _CodigoProduto
        {
            get
            {
                return CodigoProduto;
            }
            set
            {
                if (this.CodigoProduto != value)
                    this.CodigoProduto = value;
            }
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

        public DateTime _DataPedido
        {
            get
            {
                return DataPedido;
            }
            set
            {
                if (this.DataPedido != value)
                    this.DataPedido = value;
            }
        }

        public DateTime _DataEntrega
        {
            get
            {
                return DataEntrega;
            }
            set
            {
                if (this.DataEntrega != value)
                    this.DataEntrega = value;
            }
        }

        public DateTime _DataEnvio
        {
            get
            {
                return DataEnvio;
            }
            set
            {
                if (this.DataEnvio != value)
                    this.DataEnvio = value;
            }
        }

        public int _CodigoTranportadora
        {
            get
            {
                return CodigoTranportadora;
            }
            set
            {
                if (this.CodigoTranportadora != value)
                    this.CodigoTranportadora = value;
            }
        }

        public double _Frete
        {
            get
            {
                return Frete;
            }
            set
            {
                if (this.Frete != value)
                    this.Frete = value;
            }
        }

        public string _NomeDestinatario
        {
            get
            {
                return NomeDestinatario;
            }
            set
            {
                if (this.NomeDestinatario != value)
                    this.NomeDestinatario = value;
            }
        }

        public string _EnderecoDestiantario
        {
            get
            {
                return EnderecoDestiantario;
            }
            set
            {
                if (this.EnderecoDestiantario != value)
                    this.EnderecoDestiantario = value;
            }
        }

        public string _CidadeDestino
        {
            get
            {
                return CidadeDestino;
            }
            set
            {
                if (this.CidadeDestino != value)
                    this.CidadeDestino = value;
            }
        }

        public string _RegiaoDestino
        {
            get
            {
                return RegiaoDestino;
            }
            set
            {
                if (this.RegiaoDestino != value)
                    this.RegiaoDestino = value;
            }
        }

        public string _CEPDestino
        {
            get
            {
                return CEPDestino;
            }
            set
            {
                if (this.CEPDestino != value)
                    this.CEPDestino = value;
            }
        }

        public string _PaisDestino
        {
            get
            {
                return PaisDestino;
            }
            set
            {
                if (this.PaisDestino != value)
                    this.PaisDestino = value;
            }
        }

        public double _Total
        {
            get { return Total; }
            set
            {
                if (this.Total != value)
                    this.Total = value;
            }
        }

    }
}