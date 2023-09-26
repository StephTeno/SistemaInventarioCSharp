using MODELO;
using System.Windows.Forms;

namespace Controlador
{
    public class Controller
    {
        public DataGridView RellenarProductos(DataGridView Propus, MODELO.Producto Products)
        {
            Propus.Rows.Add(Products.Codigo, Products.Nombre, Products.Categoria);
            return Propus;
        }
        public DataGridView ActualizarProductos(DataGridView Pros, List<MODELO.Producto> Products)
        {
            foreach(Producto Product in Products)
            {
                Pros.Rows.Add(Product.Codigo, Product.Nombre, Product.Categoria);
            }
            return Pros;
        }
        public void EliminarProducto(int Pos, List<MODELO.Producto> Productos, DataGridView ola)
        {
            if(Pos > -1 && Pos < Productos.Count)
            {
                Productos.RemoveAt(Pos);
                ola.Rows.RemoveAt(Pos);
            }
        }

        public void RellenarEntradas(DataGridView Entradas, List<Entrada> Entry, List<Producto> Products)
        {
            Entradas.Rows.Clear();
            foreach (Entrada Ent in Entry)
            {
                foreach (Producto Product in Products)
                {
                    if (Ent.CodigoProducto == Product.Codigo)
                    {
                        Entradas.Rows.Add(Ent.CodigoProducto, Product.Nombre, Ent.PrecioCompra, Ent.Cantidad, Ent.PrecioCompra * Ent.Cantidad);
                    }
                    
                }
            }
        }
        public void RellenarSalidas(DataGridView Salidas, List<Salida> Exit, List<Producto> Products)
        {
            Salidas.Rows.Clear();
            foreach(Salida Ex in Exit)
            {
                foreach(Producto Product in Products)
                {
                    if (Ex.CodigoProducto == Product.Codigo)
                    {
                        Salidas.Rows.Add(Ex.CodigoProducto, Product.Nombre, Ex.Cantidad, Ex.PrecioVenta, Ex.Cantidad * Ex.PrecioVenta );
                    }
                }
            }
        }
        public void AsignarPrecioVenta(List<Salida> Ext, List<Entrada> Ent)
        {
            foreach(Entrada En in Ent)
            {
                foreach(Salida Ex in Ext)
                {
                    if(En.CodigoProducto == Ex.CodigoProducto)
                    {
                        Ex.PrecioVenta = En.PrecioCompra + (En.PrecioCompra * 0.3);
                    }
                }
            }
        }
        public Producto EncontrarProduct(Entrada Entry, List<Producto> Productos)
        {
            Producto Propu = new Producto();
            foreach (Producto Product in Productos)
            {
                if(Product.Codigo == Entry.CodigoProducto)
                {
                    Product.CostoUnitario = Entry.PrecioCompra;
                    Propu = Product;
                }
            }
            return Propu;
        }
        public Salida ValidarSalida(List<Entrada> Entries, TextBox NoDoc, TextBox NoCliente,
            TextBox Cliente, TextBox ProdCod, NumericUpDown Cantidad, DateTimePicker Fecha)
        {
            Salida Exit = new Salida();
            bool Existe = false;
            foreach(Entrada Entry in Entries)
            {
                if(Entry.CodigoProducto == ProdCod.Text)
                {
                    Exit.NoDoc = int.Parse(NoDoc.Text);
                    Exit.NoCliente = int.Parse(NoCliente.Text);
                    Exit.Cliente = Cliente.Text;
                    Exit.CodigoProducto = ProdCod.Text;
                    Exit.Cantidad = Convert.ToInt32(Cantidad.Value);
                    Exit.PrecioVenta = Entry.PrecioCompra + (Entry.PrecioCompra * 0.3);
                    Exit.Fecha = Fecha.Value;
                    Existe = true;
                }
            }
            if(Existe)
            {
                MessageBox.Show("No hay una entrada existente para esa salida");
            }
            return Exit;
        }
        public List<Inventario> RegistrarSalida(List<Inventario> Inv, List<Salida> Exits)
        {
            foreach(Inventario Invt in Inv)
            {
                foreach(Salida Exit in Exits)
                {
                    if(Invt.Productos.Codigo == Exit.CodigoProducto)
                    {
                        Invt.Salidas = Exit.Cantidad;
                    }
                }
            }
            return Inv;
        }
        public void RepararInventario(List<Inventario> Inv, List<Entrada> Entradas, 
            List<Salida> Salidas)
        {
            List<int> Ent = new List<int>();
            List<int> Sal = new List<int>();
            foreach(Inventario In in Inv)
            {
                foreach(Entrada Entrada in Entradas)
                {
                    foreach(Salida Salida in Salidas)
                    {
                        string Codigo = Entrada.CodigoProducto;
                        if(Salida.CodigoProducto == Codigo && In.Productos.Codigo == Codigo)
                        {
                            Ent.Add(Entrada.Cantidad);
                            Sal.Add(Salida.Cantidad);
                            In.Entradas = Ent.Sum();
                            In.Salidas = Ent.Sum();
                        }
                    }
                }
            }

        }
        public void RellenarInventario(List<Inventario> Inv, DataGridView Inventario)
        {
            Inventario.Rows.Clear();
            foreach(Inventario In in Inv)
            {
                Inventario.Rows.Add(In.Productos.Codigo, In.Productos.Nombre, In.Productos.Categoria,
                    In.Entradas, In.Salidas, In.CalcularStock(), In.CalcularIngresos(), In.CalcularEgresos());
            }
        }
    }
}