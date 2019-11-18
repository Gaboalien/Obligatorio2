using System;
using System.Collections.Generic;
using System.Text;

namespace DominioPosta
{
     public class Cliente
    {
        private string direccion;
        private DateTime fechaRegistro;
        private string mail;
        private bool montevideo;
        private List<Compra> compras;
        private Usuario usuario;


        #region Properties
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public List<Compra> Compras
        {
            get { return compras;}
            set { compras = value;}
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }




        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }


        public bool Montevideo
        {
            get { return montevideo; }
            set { montevideo = value; }
        }

        #endregion

        public Cliente(string direccion, DateTime fechaRegistro, Usuario usuario, string mail, bool montevideo)
        {
            this.direccion = direccion;
            this.fechaRegistro = fechaRegistro;
            this.usuario = usuario;
            this.mail = mail;
            this.montevideo = montevideo;
            this.compras = new List<Compra>();

        }




    }
}
