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
    public partial class VentanaFacturacion : Form
    {
        
        public VentanaFacturacion()
        {
            InitializeComponent();
        }



        private void VentanaFacturacion_Load(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            double total;
            total = 0;

            if (VentanarRegistro.producto.categoria == "Niños")
            {
                txaDescripcion.Text = "Categoria " + ventanaNino.producto.categoria+"\n";
                txaDescripcion.Text = "Producto " + ventanaNino.producto.nombreProducto + "\n";
                txaDescripcion.Text = "Talla " + ventanaNino.producto.talla + "\n";
                txaDescripcion.Text = "Precio " + ventanaNino.producto.precio + "\n";
                txaDescripcion.Text = "Subtotal " + ventanaNino.persona.pago.subtotal + "\n";

            }

            if (VentanarRegistro.producto.categoria == "Hombre")
            {
                txaDescripcion.Text = "Categoria " + VentanaHombre.producto.categoria + "\n";
                txaDescripcion.Text = "Producto " + VentanaHombre.producto.nombreProducto + "\n";
                txaDescripcion.Text = "Talla " + VentanaHombre.producto.talla + "\n";
                txaDescripcion.Text = "Precio " + VentanaHombre.producto.precio + "\n";
                txaDescripcion.Text = "Subtotal " + VentanaHombre.persona.pago.subtotal + "\n";
            }

            if(VentanarRegistro.producto.categoria == "Mujer")
            {
                txaDescripcion.Text = "Categoria " + VentanaMujer.producto.categoria + "\n";
                txaDescripcion.Text = "Producto " + VentanaMujer.producto.nombreProducto + "\n";
                txaDescripcion.Text = "Talla " + VentanaMujer.producto.talla + "\n";
                txaDescripcion.Text = "Precio " + VentanaMujer.producto.precio + "\n";
                txaDescripcion.Text = "Subtotal " + VentanaMujer.persona.pago.subtotal + "\n";
            }


        }
    }
}
