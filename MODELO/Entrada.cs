using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Entrada
    {
        public int NoDoc { get; set; }
        public string NoProveedor { get; set; }
        public string Proveedor { get; set; }
        public string CodigoProducto { get; set; }
        public double PrecioCompra { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }

        public Entrada()
        {
        }

        public Entrada(int noDoc, string noProveedor, string proveedor, string codigoProducto, double precioCompra, int cantidad, DateTime fecha)
        {
            NoDoc = noDoc;
            NoProveedor = noProveedor;
            Proveedor = proveedor;
            CodigoProducto = codigoProducto;
            PrecioCompra = precioCompra;
            Cantidad = cantidad;
            Fecha = fecha;
        }
    }
}
