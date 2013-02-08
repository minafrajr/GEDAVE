/***********************************************************************
 * Classe:  Categoria.cs
 * Proprietário:  Carlos
 * Finalidade: Definição da classe Categoria
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects
{
    public class Categoria
    {
        private int CodigoCategoria;
        private string NomeCategoria;
        private string DescricaoCategoria;
        private string Figura;

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

        public string _NomeCategoria
        {
            get
            {
                return NomeCategoria;
            }
            set
            {
                if (this.NomeCategoria != value)
                    this.NomeCategoria = value;
            }
        }

        public string _DescricaoCategoria
        {
            get
            {
                return DescricaoCategoria;
            }
            set
            {
                if (this.DescricaoCategoria != value)
                    this.DescricaoCategoria = value;
            }
        }

        public string _Figura
        {
            get
            {
                return Figura;
            }
            set
            {
                if (this.Figura != value)
                    this.Figura = value;
            }
        }

    }
}