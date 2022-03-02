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
        public double total = VentanarRegistro.persona.tarjeta.totales.subtotal;
       
        public VentanaFacturacion()
        {
            InitializeComponent();
        }



        private void VentanaFacturacion_Load(object sender, EventArgs e)
        {
           

        }

        private void btnRFinalizar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Si continua se borrara todos los cambios", "Advertencia", botones, MessageBoxIcon.Warning);

            if (dr == DialogResult.OK)
            {
                this.Hide();

                VentanaCategoria redireccionar = new VentanaCategoria();
                redireccionar.Show();
                VentanarRegistro.persona.tarjeta.totales.subtotal = 0;

            }



        }

        private void btnAtrasF_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Se redirecionara a categoria", "Advertencia", botones, MessageBoxIcon.Warning);

            if (dr == DialogResult.OK)
            {
                this.Hide();

                VentanaCategoria redireccionar = new VentanaCategoria();
                redireccionar.Show();


            }
        }
    }
}
