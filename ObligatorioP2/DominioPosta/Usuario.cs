using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioPosta
{
    public class Usuario 
    {
        public enum EnumTipo
        {
            Cliente = 1,
            Administrador
        }

        private string username;
        private string password;
        private EnumTipo tipo;
        private Cliente cliente;

        public Usuario(string username, string password, EnumTipo tipo)
        {
            this.username = username;
            this.password = password;
            this.tipo = tipo;     
        }

        #region Properties
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public EnumTipo Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        } 
        #endregion





    }
}
