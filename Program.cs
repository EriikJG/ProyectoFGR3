using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectGR3
{
    internal static class Program
    {
        public struct Direccion
        {
            public string calleP;
            public string calleS;
            public string Ncasa;
        }
        public struct Producto
        {
            public string nombreProducto;
            public string talla;
            public string color;
            public string categoria;
            public double precio;
        }
        public struct Pago
        {
            public string numeroTarjeta;
            public int clave;
        }

            public struct Persona
        {
            public string nombre;
            public string correo;
            public Direccion datosD;
            public Pago tarjeta;
        }
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RopaDeNino());
        }

    }
}
