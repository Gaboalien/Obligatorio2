using System;
using System.Collections.Generic;
using System.Text;

namespace DominioPosta
{
    public class ClienteEmpresa : Cliente
    {
        private string nombreEmpresa;
        private string razonSocial;
        private long rut;
        private string tipoCliente;

        #region Properties
        public string NombreEmpresa
        {
            get { return nombreEmpresa; }
            set { nombreEmpresa = value; }

        }

        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }


        public long Rut
        {
            get { return rut; }
            set { rut = value; }
        }

        public string TipoCliente
        {
            get { return tipoCliente; }
            set { tipoCliente = value; }
        }



        #endregion

        public ClienteEmpresa(string direccion, DateTime fechaRegistro, Usuario usuario, string mail, bool montevideo, string nombreEmpresa, string razonSocial, long rut)
            :base(direccion, fechaRegistro, usuario, mail, montevideo)
        {
            this.nombreEmpresa = nombreEmpresa;
            this.razonSocial = razonSocial;
            this.rut = rut;
            this.tipoCliente = "Empresa";
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}, Email: {1} (Tipo de cliente: {2}) ", nombreEmpresa, Mail, tipoCliente);
        }



    }
}
