using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Salida
    {
        public int NoDoc { get; set; }
        public int NoCliente { get; set; }
        public string Cliente { get; set; }
        public string CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioVenta { get; set; } 
        public DateTime Fecha { get; set; }

        public Salida()
        {
        }

        public Salida(int noDoc, int noCliente, string cliente, string codigoProducto, int cantidad, DateTime fecha)
        {
            NoDoc = noDoc;
            NoCliente = noCliente;
            Cliente = cliente;
            CodigoProducto = codigoProducto;
            Cantidad = cantidad;
            PrecioVenta = -1;
            Fecha = fecha;
        } 
    }
}
