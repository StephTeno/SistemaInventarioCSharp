using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoContabilidadDeCosto
{
    public class Datos
    {
        //Algunas variables globales(MEGA IMPORTANTES NO TOCAR)
        public static bool si = false;
        public static MODELO.Producto Pro;
        public static List<MODELO.Producto> Pros = new List<MODELO.Producto>();
        public static MODELO.Entrada Entry;
        public static List<MODELO.Entrada> Entradas = new List<MODELO.Entrada>();
        public static List<MODELO.Salida> Salidas = new List<MODELO.Salida>();
        public static MODELO.Salida Exit;
        public static List<MODELO.Inventario> Inventory = new List<MODELO.Inventario>();
    }
}
