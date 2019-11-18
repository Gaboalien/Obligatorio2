using System;
using System.Collections.Generic;
using System.Text;

namespace DominioPosta
{
   public class ClienteComun : Cliente

    {
        private int cedula;
        private string nombre;
        private string celular;
        private string tipoCliente;
        
        #region Properties
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string TipoCliente 
        {
            get { return tipoCliente; }
            set { tipoCliente = value; }
        }


        #endregion

        public ClienteComun(string direccion, DateTime fechaRegistro, Usuario usuario, string mail, bool montevideo, int cedula, string nombre, string celular) 
            :base(direccion, fechaRegistro, usuario, mail, montevideo)
        {

            this.cedula = cedula;
            this.nombre = nombre;
            this.celular = celular;
            this.TipoCliente = "Común";
        }
        
        public override string ToString()
        {
            return string.Format("Nombre: {0}, Email: {1} (Tipo de cliente: {2})", nombre,Mail,tipoCliente);
        }




    }
}
