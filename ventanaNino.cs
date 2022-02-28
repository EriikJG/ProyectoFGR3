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

        public ventanaNino()
        {
            InitializeComponent();
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
