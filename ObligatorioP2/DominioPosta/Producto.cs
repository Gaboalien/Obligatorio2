using System;
using System.Collections.Generic;
using System.Text;

namespace DominioPosta
{
    public class Producto
    {
        #region Definicion Enums

        public enum EnumCategoria
        {
            FRESCOS = 1,
            CONGELADOS,
            HOGAR,
            TEXTILES,
            TECNOLOGIA
        }

        #endregion

        private static int ultId = 1;
        private int id;
        private string nombre;
        private string descripcion;
        private bool exclusividad;
        private EnumCategoria categoria;
        private int precio;

        public Producto(string nombre, string descripcion, bool exclusividad, EnumCategoria categoria, int precio)
        {
            this.id = ultId++;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.exclusividad = exclusividad;
            this.categoria = categoria;
            this.precio = precio;
        }

        #region Properties
        public int ID

        {
            get { return id; }
            set { id = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        public bool Exclusividad
        {
            get { return exclusividad; }
            set { exclusividad = value; }
        }


        public EnumCategoria Categoria
        {
            get { return categoria; }
        }


        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        #endregion

        public override string ToString()
        {
            return string.Format("{0}: {1} {2} (${3})" ,id , nombre, categoria, precio);
        }




    }
}
