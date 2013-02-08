/***********************************************************************
 * Classe:  Produto.cs
 * Proprietário:  Carlos
 * Finalidade: Definição da classe Produto
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects
{
    public class Produto
    {
        private int CodigoProduto;
        private string NomeProduto;
        private int CodigoFornecedor;
        private int CodigoCategoria;
        private uint QuantidadepUnidade;
        private double PrecoUnitario;
        private uint UnidadeEstocada;
        private uint UnidadesPedidas;
        private uint NiveldeReposicao;
        private bool Descontinuado;

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

        public string _NomeProduto
        {
            get
            {
                return NomeProduto;
            }
            set
            {
                if (this.NomeProduto != value)
                    this.NomeProduto = value;
            }
        }

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

        public int _CodigoCategoria
        {
            get
            {
                return CodigoCategoria;
            }
            set
            {
                if (this.CodigoCategoria != value)
                    this.CodigoCategoria = value;
            }
        }

        public uint _QuantidadepUnidade
        {
            get
            {
                return QuantidadepUnidade;
            }
            set
            {
                if (this.QuantidadepUnidade != value)
                    this.QuantidadepUnidade = value;
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

        public uint _UnidadeEstocada
        {
            get
            {
                return UnidadeEstocada;
            }
            set
            {
                if (this.UnidadeEstocada != value)
                    this.UnidadeEstocada = value;
            }
        }

        public uint _UnidadesPedidas
        {
            get
            {
                return UnidadesPedidas;
            }
            set
            {
                if (this.UnidadesPedidas != value)
                    this.UnidadesPedidas = value;
            }
        }

        public uint _NiveldeReposicao
        {
            get
            {
                return NiveldeReposicao;
            }
            set
            {
                if (this.NiveldeReposicao != value)
                    this.NiveldeReposicao = value;
            }
        }

        public bool _Descontinuado
        {
            get
            {
                return Descontinuado;
            }
            set
            {
                if (this.Descontinuado != value)
                    this.Descontinuado = value;
            }
        }

    }
}