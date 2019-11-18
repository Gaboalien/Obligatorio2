using System;
using System.Collections.Generic;
using System.Text;

namespace DominioPosta
{
   public class CantidadProducto
    {
        private int cantidad;
        private Producto prod;


        #region Properties
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        public Producto Prod
        {
            get { return prod; }
            set { prod = value; }
        } 
        #endregion

        public CantidadProducto(int cantidad, Producto prod)
        {
            this.cantidad = cantidad;
            this.prod = prod;
        }
    }
}
