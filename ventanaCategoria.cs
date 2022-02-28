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
    public partial class VentanaCategoria : Form
    {
        Program.Producto producto = new Program.Producto ();
        public VentanaCategoria()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            producto.categoria = cbmCategoria.Text;
            
                

                if (producto.categoria == "Niños")
                {
                    this.Hide();

                    ventanaNino ventanaNinos = new ventanaNino();
                    ventanaNinos.Show();
                    
            }

                if (producto.categoria == "Hombre")
                {
                    this.Hide();

                    VentanaHombre ventanaHombre = new VentanaHombre();
                    ventanaHombre.Show();
                }
                if (producto.categoria == "Mujer")
                {
                    this.Hide();

                    VentanaMujer ventanaMujer = new VentanaMujer();
                    ventanaMujer.Show();
                }

            


        }

        private void VentanaCategoria_Load(object sender, EventArgs e)
        {
            
        }
    }
}
