using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Producto
    {
        //Variables a utilizar
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double CostoUnitario { get; set; }
        public int Cantidad { get; set; }
        //Contructores de la clase
        public Producto()
        {
        }
        public Producto(string codigo, string nombre, string categoria, double costoUnitario, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Categoria = categoria;
            CostoUnitario = costoUnitario;
            Cantidad = cantidad;
        }
        //Métodos
        //Este método calcula el costo total y lo almacena en una lista
        public List<double> CalcularTotal(List<Producto> Productos)
        {
            List<double> Totales = new List<double>();
            foreach (Producto producto in Productos)
            {
                double Total = producto.CostoUnitario * Convert.ToDouble(producto.Cantidad);
                Totales.Add(Total);
            }
            return Totales;
        }
        //Este método calcula el costo total de todos los productos juntos y lo retorna en un double
        public double CalcularTotalAbsoluto(List<Producto> Productos)
        {
            double Total = 0;
            foreach (Producto producto in Productos)
            {
                Total += producto.CostoUnitario * Convert.ToDouble(producto.Cantidad);
            }
            return Total;
        }
    }
}
