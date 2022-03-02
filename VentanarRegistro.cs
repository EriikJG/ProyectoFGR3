using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectGR3
{
    public partial class VentanarRegistro : Form
    {
       public struct Precio
        {
            public double subtotal;
            public double total;
        }
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
           
            public double precioIndividual;
        }
        public struct Pago
        {
            public Precio totales;
            public string numeroTarjeta;
            public string clave;
        }

        public struct Persona
        {
            public string nombre;
            public string correo;
            public Direccion datosD;
            public Pago tarjeta;
        }
        static public Producto producto;
        static public Persona persona;
        
     

        static public int contadorUniversal;

        public VentanarRegistro()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            persona.tarjeta.totales.subtotal = 0;
            persona.tarjeta.totales.total = 0;
            contadorUniversal = 0;

        }
         
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            this.Hide();

            VentanaCategoria newform2 = new VentanaCategoria();
            newform2.Show();

        }

      
    }
}
