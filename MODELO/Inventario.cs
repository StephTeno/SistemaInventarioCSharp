using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Inventario
    {
        //variables de invenario
        public Producto Productos { get; set; }
        public int Entradas { get; set; }
        public int Salidas { get; set; }
        public int Stock { get; set; }
        public double Ingresos { get; set; }
        public double Egresos { get; set; }
        //Sus constructores
        public Inventario()
        {
        }
        public Inventario(Producto productos, int entradas, int salidas)
        {
            Productos = productos;
            Entradas = entradas;
            Salidas = salidas;
            Stock = CalcularStock();
            Ingresos = CalcularIngresos();
            Egresos = CalcularEgresos();
        }
        //Métodos de inventario
        public int CalcularStock()
        {
            int Stock = (Entradas - Salidas);
            return Stock;
        }
        public double CalcularIngresos()
        {
            double Ingresos = Productos.CostoUnitario * Convert.ToDouble(Entradas);
            return Ingresos;
        }
        public double CalcularEgresos()
        {
            double Egresos = Productos.CostoUnitario * Convert.ToDouble(Salidas);
            return Egresos;
        }
    }
}
