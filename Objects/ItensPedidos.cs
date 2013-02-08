/***********************************************************************
 * Classe:  ItensPedidos.cs
 * Proprietário:  Carlos
 * Finalidade: Definição da classe ItensPedidos
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects
{


    public class ItensPedidos
    {
        private int NumeroPedido;
        private int CodigoProduto;
        private double PrecoUnitario;
        private uint Quantidade;
        private double Desconto;

        public int _NumeroPedido
        {
            get
            {
                return NumeroPedido;
            }
            set
            {
                if (this.NumeroPedido != value)
                    this.NumeroPedido = value;
            }
        }

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

        public double _PrecoUnitario
        {
            get
            {
                return PrecoUnitario;
            }
            set
            {
                if (this.PrecoUnitario != value)
                    this.PrecoUnitario = value;
            }
        }

        public uint _Quantidade
        {
            get
            {
                return Quantidade;
            }
            set
            {
                if (this.Quantidade != value)
                    this.Quantidade = value;
            }
        }

        public double _Desconto
        {
            get
            {
                return Desconto;
            }
            set
            {
                if (this.Desconto != value)
                    this.Desconto = value;
            }
        }

    }
}