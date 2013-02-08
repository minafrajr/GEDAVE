/***********************************************************************
 * Classe:  Transportadora.cs
 * Proprietário:  Carlos
 * Finalidade: Definição da classe Transportadora
 ***********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects
{
    public class Transportadora
    {
        private int CodigoTransportadora;
        private string NomeEmpresaTransp;
        private string TelefoneTransp;

        public int _CodigoTransportadora
        {
            get
            {
                return CodigoTransportadora;
            }
            set
            {
                if (this.CodigoTransportadora != value)
                    this.CodigoTransportadora = value;
            }
        }

        public string _NomeEmpresaTransp
        {
            get
            {
                return NomeEmpresaTransp;
            }
            set
            {
                if (this.NomeEmpresaTransp != value)
                    this.NomeEmpresaTransp = value;
            }
        }

        public string _TelefoneTransp
        {
            get
            {
                return TelefoneTransp;
            }
            set
            {
                if (this.TelefoneTransp != value)
                    this.TelefoneTransp = value;
            }
        }

    }
}