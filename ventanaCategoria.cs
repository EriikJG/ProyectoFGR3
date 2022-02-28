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
        Program.Producto cliente = new Program.Producto ();
        public VentanaCategoria()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            cliente.categoria = cbmCategoria.Text;

            if (cliente.categoria == "Niños")
            {
                this.Hide();

                ventanaNino ventanaNino = new ventanaNino();
                ventanaNino.Show();
            }

            if (cliente.categoria == "Hombre")
            {
                this.Hide();

                VentanaHombre ventanaHombre = new VentanaHombre();
                ventanaHombre.Show();
            }
               

        }

        private void VentanaCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
