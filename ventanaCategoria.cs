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
        
        public VentanaCategoria()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            VentanarRegistro.producto.categoria =  cbmCategoria.Text;
            
                

                if (VentanarRegistro.producto.categoria == "Niños")
                {
                    this.Hide();

                    ventanaNino ventanaNinos = new ventanaNino();
                    ventanaNinos.Show();
                    
            }

                if (VentanarRegistro.producto.categoria == "Hombre")
                {
                    this.Hide();

                    VentanaHombre ventanaHombre = new VentanaHombre();
                    ventanaHombre.Show();
                }
                if (VentanarRegistro.producto.categoria == "Mujer")
                {
                    this.Hide();

                    VentanaHombre ventanaMujer = new VentanaHombre();
                    ventanaMujer.Show();
                }

            


        }

        private void VentanaCategoria_Load(object sender, EventArgs e)
        {
            
        }
    }
}
