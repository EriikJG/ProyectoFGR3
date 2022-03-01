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
    public partial class ventanaNino : Form
    {
        Program.Producto[] arregloNinos = new Program.Producto[4];
        public ventanaNino()
        {
            InitializeComponent();
            arregloNinos[0].precio = 10;
            arregloNinos[1].precio = 5;
            arregloNinos[2].precio = 8;
            arregloNinos[3].precio = 20;

        }

        private void ventanaNino_Load(object sender, EventArgs e)
        {

        }

        private void btnNComprar_Click(object sender, EventArgs e)
        {
            
            
            this.Hide();

            VentanaFacturacion facturar = new VentanaFacturacion();
            facturar.Show();

        }
    }
}
