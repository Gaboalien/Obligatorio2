using System;
using System.Collections.Generic;
using System.Text;

namespace DominioPosta
{
   public class Compra
    {
        #region Definicion Enums
        public enum EnumFormaDePago
        {
            TARJETA = 1,
            EFECTIVO
        }

        public enum EnumFormaDeEntrega
        {
            DOMICILIO = 1,
            RETIRO
        }

        #endregion

        private List<CantidadProducto> prods;
        private DateTime fecha;
        private EnumFormaDePago formaDePago;
        private EnumFormaDeEntrega formaDeEntrega;
        private Cliente cliente;

        #region Properties

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public List<CantidadProducto> Prods
        {
            get { return prods; }
            set { prods = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


        public EnumFormaDePago FormaDePago
        {
            get { return formaDePago; }
        }


        public EnumFormaDeEntrega FormaDeEntrega
        {
            get { return formaDeEntrega; }
            set { formaDeEntrega = value; }
        } 
        #endregion

        public Compra( DateTime fecha, EnumFormaDePago formaDePago, EnumFormaDeEntrega formaDeEntrega, Cliente cliente)
        {

            this.prods = new List<CantidadProducto>();
            this.fecha = fecha;
            this.formaDePago = formaDePago;
            this.formaDeEntrega = formaDeEntrega;
            this.cliente = cliente;
        }

        public void AltaCantidadProducto(CantidadProducto cp)
        {
            prods.Add(cp);
        }

        public override string ToString()
        {
            return string.Format("Usuario de cliente: {0}, Direccion de cliente: {1}, Fecha de compra: {2}, Cantidad de productos: {3} ", cliente.Usuario, cliente.Direccion, fecha.ToShortDateString(), prods.Count);
        }

    }
}

