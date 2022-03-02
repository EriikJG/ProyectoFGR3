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
            public Precio precio;
<<<<<<< HEAD
=======
            public double precioIndividual;
>>>>>>> parent of c09f69b (cambios finales2.0)
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
        static public Producto producto;
        static public Persona persona;
    
        public VentanarRegistro()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            producto.precio.subtotal = 0;
            producto.precio.total = 0;
<<<<<<< HEAD
=======

>>>>>>> parent of c09f69b (cambios finales2.0)
        }
         
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            this.Hide();

            VentanaCategoria newform2 = new VentanaCategoria();
            newform2.Show();

        }

      
    }
}
