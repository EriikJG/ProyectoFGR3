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
            if (txtNombre.Text != "" && txtCorreo.Text != "" && txtTarjeta.Text != "" && txtClave.Text != "" && txtCalleP.Text != "" && txtCalleS.Text != ""
                && txtNCasa.Text != "")
            {


                VentanarRegistro.persona.nombre = txtNombre.Text;
                VentanarRegistro.persona.correo = txtCorreo.Text;
                VentanarRegistro.persona.tarjeta.numeroTarjeta = txtTarjeta.Text;
                VentanarRegistro.persona.tarjeta.clave = txtClave.Text;
                VentanarRegistro.persona.datosD.calleP = txtCalleP.Text;
                VentanarRegistro.persona.datosD.calleS = txtCalleS.Text;
                VentanarRegistro.persona.datosD.Ncasa = txtNCasa.Text;

                txaDescripcion.Text = "ULTIMO PRODUCTO SELECCIONADO: " + "\nNombre Del producto: " + VentanarRegistro.producto.nombreProducto + "\nTalla: " + VentanarRegistro.producto.talla
                 + "\nColor: " + VentanarRegistro.producto.color + "\nCategoria: " + VentanarRegistro.producto.categoria + "\n Precio Individual: " + VentanarRegistro.producto.precioIndividual
                 + "\n USUARIO:" + "\nNombre:" + VentanarRegistro.persona.nombre + "\nCorreo: " + VentanarRegistro.persona.correo + "\n" + "\nDIRECCIÓN: " +
                 "\nCalle Principal:" + VentanarRegistro.persona.datosD.calleP + "\nCalle Secundaria: " + VentanarRegistro.persona.datosD.calleS +
                 "\nNúmero de Casa: " + VentanarRegistro.persona.datosD.Ncasa +"\n" + "\n TOTALES A PAGAR:  " + " \nSubtotal Compra: $" + VentanarRegistro.persona.tarjeta.totales.subtotal
                 + " \nTotal Compra: $" + total;

                MessageBox.Show("Gracias por la compra", "Mensaje");

            }
            else
            {
                MessageBox.Show("LLENE TODOS LOS CAMPOS", "Advertencia");
            }
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

        private void btnCerrarF_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult dr = MessageBox.Show("HASTA PRONTO", "Mensaje", botones, MessageBoxIcon.Information);

            if (dr == DialogResult.OK)
            {
                this.Hide();

                VentanarRegistro redireccionar1 = new VentanarRegistro();
                redireccionar1.Show();
                VentanarRegistro.persona.tarjeta.totales.subtotal = 0;

            }
        }
    }
}
