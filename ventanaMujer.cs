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
    public partial class VentanaMujer : Form
    {
        public double numero = VentanarRegistro.producto.precio.subtotal;
        public VentanaMujer ()
        {
            InitializeComponent();
        }

        private void VentanaMujer_Load(object sender, EventArgs e)
        {
            lblMPregunta.Enabled = true;
            btnMNo.Enabled = false;
            btnMSi.Enabled = true;
            btnMIr.Enabled = false;
            cmbMSeleccionCategoria.Enabled = false;
            lblMSeleccionCategoria.Enabled = false;
            btnFinalM.Enabled = false;
            lblMTotal.Text = "Total: $" + numero;
        }
        public void activarRedireccion()
        {
            lblMPregunta.Enabled = true;
            btnMSi.Enabled = true;
            btnMNo.Enabled = true;

        }

        public void ClearPanels()
        {
            cmbMColor.SelectedItem = null;
            cmbMTalla.SelectedItem = null;
            rbtMPrenda1.Checked = false;
            rbtMPrenda2.Checked = false;
            rbtMPrenda3.Checked = false;
            rbtMPrenda4.Checked = false;
        }

        private void btnMComprar_Click(object sender, EventArgs e)
        {
            if (rbtMPrenda1.Checked == true || rbtMPrenda2.Checked == true || rbtMPrenda3.Checked == true || rbtMPrenda4.Checked == true)
            {

                if (rbtMPrenda1.Checked)
                {
                    if (cmbMTalla.SelectedItem != null && cmbMColor.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtMPrenda1.Text;
                        VentanarRegistro.producto.color = Convert.ToString(cmbMColor.SelectedText);
                        VentanarRegistro.producto.talla = Convert.ToString(cmbMTalla.SelectedText);
                        VentanarRegistro.producto.precio.subtotal += 10;
                        this.Hide();

                        VentanaFacturacion facturar = new VentanaFacturacion();
                        facturar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selecciona talla y color ", "Advertencia");
                    }

                }

                if (rbtMPrenda2.Checked)
                {
                    if (cmbMTalla.SelectedItem != null && cmbMColor.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtMPrenda2.Text;
                        VentanarRegistro.producto.color = Convert.ToString(cmbMColor.SelectedText);
                        VentanarRegistro.producto.talla = Convert.ToString(cmbMTalla.SelectedText);
                        VentanarRegistro.producto.precio.subtotal += 5;
                        this.Hide();

                        VentanaFacturacion facturar = new VentanaFacturacion();
                        facturar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selecciona talla y color ", "Advertencia");
                    }

                }
                if (rbtMPrenda3.Checked)
                {
                    if (cmbMTalla.SelectedItem != null && cmbMColor.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtMPrenda3.Text;
                        VentanarRegistro.producto.color = Convert.ToString(cmbMColor.SelectedText);
                        VentanarRegistro.producto.talla = Convert.ToString(cmbMTalla.SelectedText);
                        VentanarRegistro.producto.precio.subtotal += 8;
                        this.Hide();

                        VentanaFacturacion facturar = new VentanaFacturacion();
                        facturar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selecciona talla y color ", "Advertencia");
                    }


                }
                if (rbtMPrenda4.Checked)
                {
                    if (cmbMTalla.SelectedItem != null && cmbMColor.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtMPrenda4.Text;
                        VentanarRegistro.producto.color = Convert.ToString(cmbMColor.SelectedText);
                        VentanarRegistro.producto.talla = Convert.ToString(cmbMTalla.SelectedText);
                        VentanarRegistro.producto.precio.subtotal += 20;
                        this.Hide();

                        VentanaFacturacion facturar = new VentanaFacturacion();
                        facturar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selecciona talla y color ", "Advertencia");
                    }
                }
            }
            else
            {
                MessageBox.Show("SELECIONE AL MENOS UNO ", "Advertencia");
            }
        }

        private void btnMAgregarCarrito_Click(object sender, EventArgs e)
        {
            int contador2 = 0;
            if (rbtMPrenda1.Checked == true || rbtMPrenda2.Checked == true || rbtMPrenda3.Checked == true || rbtMPrenda4.Checked == true)
            {

                if (rbtMPrenda1.Checked)
                {
                    if (cmbMTalla.SelectedItem != null && cmbMColor.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtMPrenda1.Text;
                        VentanarRegistro.producto.color = Convert.ToString(cmbMColor.SelectedText);
                        VentanarRegistro.producto.talla = Convert.ToString(cmbMTalla.SelectedText);
                        VentanarRegistro.producto.precio.subtotal += 10;
                        this.Hide();

                        VentanaFacturacion facturar = new VentanaFacturacion();
                        facturar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selecciona talla y color ", "Advertencia");
                    }

                }

                if (rbtMPrenda2.Checked)
                {
                    if (cmbMTalla.SelectedItem != null && cmbMColor.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtMPrenda2.Text;
                        VentanarRegistro.producto.color = Convert.ToString(cmbMColor.SelectedText);
                        VentanarRegistro.producto.talla = Convert.ToString(cmbMTalla.SelectedText);
                        VentanarRegistro.producto.precio.subtotal += 5;
                        this.Hide();

                        VentanaFacturacion facturar = new VentanaFacturacion();
                        facturar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selecciona talla y color ", "Advertencia");
                    }

                }
                if (rbtMPrenda3.Checked)
                {
                    if (cmbMTalla.SelectedItem != null && cmbMColor.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtMPrenda3.Text;
                        VentanarRegistro.producto.color = Convert.ToString(cmbMColor.SelectedText);
                        VentanarRegistro.producto.talla = Convert.ToString(cmbMTalla.SelectedText);
                        VentanarRegistro.producto.precio.subtotal += 8;
                        this.Hide();

                        VentanaFacturacion facturar = new VentanaFacturacion();
                        facturar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selecciona talla y color ", "Advertencia");
                    }


                }
                if (rbtMPrenda4.Checked)
                {
                    if (cmbMTalla.SelectedItem != null && cmbMColor.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtMPrenda4.Text;
                        VentanarRegistro.producto.color = Convert.ToString(cmbMColor.SelectedText);
                        VentanarRegistro.producto.talla = Convert.ToString(cmbMTalla.SelectedText);
                        VentanarRegistro.producto.precio.subtotal += 20;
                        this.Hide();

                        VentanaFacturacion facturar = new VentanaFacturacion();
                        facturar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selecciona talla y color ", "Advertencia");
                    }
                }
            }
            else
            {
                MessageBox.Show("SELECIONE AL MENOS UNO ", "Advertencia");
            }
            numero = VentanarRegistro.producto.precio.subtotal;
            if (contador2 != 0)
            {
                btnFinalM.Enabled = true;
                lblMTotal.Text = "Total: $" + numero;
                ClearPanels();
                activarRedireccion();
                btnMComprar.Enabled = false;
                btnMAgregarCarrito.Enabled = false;
                gpMujer.Enabled = false;
                cmbMTalla.Enabled = false;
                cmbMColor.Enabled = false;
            }

        }

        private void btnMSi_Click(object sender, EventArgs e)
        {
            btnMNo.Enabled = true;
            btnMIr.Enabled = true;
            cmbMSeleccionCategoria.Enabled = true;
            lblMSeleccionCategoria.Enabled = true;
        }

        private void btnMNo_Click(object sender, EventArgs e)
        {
            btnMSi.Enabled = true;
            btnMNo.Enabled = false;
            btnMAgregarCarrito.Enabled = true;
            gpMujer.Enabled = true;
            cmbMTalla.Enabled = true;
            cmbMColor.Enabled = true;
            btnMIr.Enabled = false;
            cmbMSeleccionCategoria.Enabled = false;
            cmbMSeleccionCategoria.SelectedItem = null;
            lblMSeleccionCategoria.Enabled = false;
        }

        private void btnMIr_Click(object sender, EventArgs e)
        {
            if (cmbMSeleccionCategoria.Text == "Niño")
            {
                this.Hide();

                ventanaNino redireccionar = new ventanaNino();
                redireccionar.Show();
            }
            else
            {

                if (cmbMSeleccionCategoria.Text == "Hombre")
                {
                    this.Hide();

                    VentanaHombre redireccionar1 = new VentanaHombre();
                    redireccionar1.Show();
                }
                else
                {
                    MessageBox.Show("Seleccione a donde desea redirigirse ");
                }
            }
        }

        private void btnAtrasM_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Si continua se borrara todos los cambios", "Advertencia", botones, MessageBoxIcon.Warning);

            if (dr == DialogResult.OK)
            {
                this.Hide();

                VentanaCategoria redireccionar = new VentanaCategoria();
                redireccionar.Show();
                VentanarRegistro.producto.precio.subtotal = 0;

            }
        }

        private void btnFinalM_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentanaFacturacion facturar = new VentanaFacturacion();
            facturar.Show();
        }

        private void gpMujer_Enter(object sender, EventArgs e)
        {

        }
    }
}
