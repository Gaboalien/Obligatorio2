using System;
using System.Collections.Generic;
using System.Text;

namespace DominioPosta
{
    public class Almacen
    {
        private List<Cliente> clientes;
        private List<Producto> productos;
        private List<Compra> compras;
        private List<Usuario> usuarios;





        #region Singleton
        private static Almacen instancia;

        public static Almacen Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Almacen();
                }
                return instancia;
            }

        } 
        #endregion


        #region Properties
        public List<Cliente> Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }
        public List<Usuario> Usuarios
        {
            get { return usuarios; }
            set { usuarios = value; }
        }


        public List<Producto> Productos
        {
            get { return productos; }
            set { productos = value; }
        }


        public List<Compra> Compras
        {
            get { return compras; }
            set { compras = value; }
        } 
        #endregion


        
        private Almacen()
        {
            this.clientes = new List<Cliente>();
            this.productos = new List<Producto>();
            this.compras = new List<Compra>();
            this.usuarios = new List<Usuario>();


            PrecargarDatos();
        }


        private void PrecargarDatos()
        {
            //CARGA Y ALTA USUARIOS
            Usuario u1 = new Usuario("jorgito123", "1234",Usuario.EnumTipo.Cliente);
            Usuario u2 = new Usuario("pedro543", "1234", Usuario.EnumTipo.Cliente);
            Usuario u3 = new Usuario("martucho123", "1234", Usuario.EnumTipo.Cliente);
            Usuario u4 = new Usuario("axion12", "1234", Usuario.EnumTipo.Cliente);
            Usuario u5 = new Usuario("barDeMoe12", "1234", Usuario.EnumTipo.Cliente);
            Usuario u6 = new Usuario("tecnoMundo77", "1234", Usuario.EnumTipo.Cliente);

            Usuario adm = new Usuario("admin", "admin", Usuario.EnumTipo.Administrador);

            AltaUsuario(u1);
            AltaUsuario(u2);
            AltaUsuario(u3);
            AltaUsuario(u4);
            AltaUsuario(u5);
            AltaUsuario(u6);
            AltaUsuario(adm);

            //CARGA DE PRODUCTOS;
            Producto p1 = new Producto("Pescado", "Atún en lata", false, Producto.EnumCategoria.FRESCOS, 50);
            Producto p2 = new Producto("Cafetera", "Recargable capuccino", false, Producto.EnumCategoria.TECNOLOGIA, 2000);
            Producto p3 = new Producto("Mix verduras", "Verduras congeladas", false, Producto.EnumCategoria.CONGELADOS, 150);
            Producto p4 = new Producto("Alfombra", "Alfombra con decoración", true, Producto.EnumCategoria.TEXTILES, 800);
            Producto p5 = new Producto("Juego de living", "4 sillas y una mesa ", false, Producto.EnumCategoria.HOGAR, 5000);
            Producto p6 = new Producto("Philips Smart Tv 65'", "Tv 4k marca Philips", true, Producto.EnumCategoria.TECNOLOGIA, 25000);

            //CARGA DE CLIENTES;
            Cliente c1 = new ClienteComun("Union 123", Fecha("12/04/2019"), u1, "jorgito@gmail.com", false, 1234567, "Jorge", "099566411");
            Cliente c2 = new ClienteComun("Joaquin Suarez 354", Fecha("19/07/2018"), u2, "Manya@gmail.com", true, 7654321, "Pedro", "098766355");
            Cliente c3 = new ClienteComun("18 de Julio 678", Fecha("05/09/2019"), u3, "NTVG@gmail.com", false, 8796541, "Martín", "091765411");
            Cliente c4 = new ClienteEmpresa("Colonia 345", Fecha("16/09/2017"), u4, "axion@petrolera.com", false, "AXION", "Axion S.A.", 8765431222);
            Cliente c5 = new ClienteEmpresa("San Jose 432", Fecha("22/03/2018"), u5, "moe@bar.com", true, "Moe's", "Duff S.A.", 6574732151);
            Cliente c6 = new ClienteEmpresa("Boulevard 897", Fecha("07/02/2019"), u6, "TecMundo@tecnomundo.com", true, "Tecnomundo", "Mier S.R.L", 8765431222);

            //CARGA DE CANTIDADES DE PRODUCTOS;
            CantidadProducto cp1 = new CantidadProducto(2, p3);
            CantidadProducto cp2 = new CantidadProducto(1, p1);
            CantidadProducto cp3 = new CantidadProducto(5, p2);
            CantidadProducto cp4 = new CantidadProducto(2, p4);
            CantidadProducto cp5 = new CantidadProducto(1, p5);
            CantidadProducto cp6 = new CantidadProducto(2, p6);
            CantidadProducto cp7 = new CantidadProducto(4, p1);
            CantidadProducto cp8 = new CantidadProducto(1, p6);

            //CARGA Y ALTA DE COMPRAS;
            Compra compra1 = new Compra(Fecha("20/05/2019"), Compra.EnumFormaDePago.TARJETA, Compra.EnumFormaDeEntrega.DOMICILIO, c4);
            compra1.AltaCantidadProducto(cp2);
            compra1.AltaCantidadProducto(cp1);
            compra1.AltaCantidadProducto(cp4);
            c4.Compras.Add(compra1);
            AltaCompra(compra1);

            Compra compra2 = new Compra(Fecha("31/07/2019"), Compra.EnumFormaDePago.EFECTIVO, Compra.EnumFormaDeEntrega.DOMICILIO, c1);
            compra2.AltaCantidadProducto(cp3);
            compra2.AltaCantidadProducto(cp6);
            compra2.AltaCantidadProducto(cp4);
            c1.Compras.Add(compra2);
            AltaCompra(compra2);

            Compra compra3 = new Compra(Fecha("25/05/2018"), Compra.EnumFormaDePago.EFECTIVO, Compra.EnumFormaDeEntrega.RETIRO, c2);
            compra3.AltaCantidadProducto(cp4);
            compra3.AltaCantidadProducto(cp7);
            c2.Compras.Add(compra3);
            AltaCompra(compra3);

            Compra compra4 = new Compra(Fecha("20/05/2017"), Compra.EnumFormaDePago.TARJETA, Compra.EnumFormaDeEntrega.RETIRO, c3);
            compra4.AltaCantidadProducto(cp5);
            compra4.AltaCantidadProducto(cp8);
            compra4.AltaCantidadProducto(cp3);
            c3.Compras.Add(compra4);
            AltaCompra(compra4);

            //ALTAS DE PRODUCTOS
            AltaProducto(p1);
            AltaProducto(p2);
            AltaProducto(p3);
            AltaProducto(p4);
            AltaProducto(p5);
            AltaProducto(p6);
            AltaCliente(c1);
            AltaCliente(c2);
            AltaCliente(c3);
            AltaCliente(c4);
            AltaCliente(c5);
            AltaCliente(c6);
        }

        public Usuario BuscarUsuario(string username, string password)
        {
            foreach (Usuario usu in usuarios)
            {
                if (usu.Username.ToUpper() == username.ToUpper() && usu.Password == password)
                {
                    return usu;
                }
            }
            return null;
        }

        public void AltaUsuario(Usuario usu)
        {
            usuarios.Add(usu);
        }

        public void AltaProducto(Producto p)
        {
            productos.Add(p);
        }

        public void AltaCliente(Cliente c)
        {
            clientes.Add(c);
        }
        public void AltaCompra(Compra co)
        {
            compras.Add(co);
        }
        private static DateTime Fecha(string f)
        {
            DateTime pFecha = DateTime.ParseExact(f, "dd/MM/yyyy", null);
            pFecha.ToString("dd/MM/yyyy");
            return pFecha;
        }
    }
}
