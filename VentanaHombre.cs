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
    public partial class VentanaHombre : Form
    {
        public double numero = VentanarRegistro.persona.tarjeta.totales.subtotal;
        public VentanaHombre()
        {
            InitializeComponent();
        }


        private void VentanaHombre_Load(object sender, EventArgs e)
        {
            
            lblHPregunta.Enabled = true;
            btnHNo.Enabled = false;
            btnHSi.Enabled = true;
            btnHIr.Enabled = false;
            cmbHSeleccionCategoria.Enabled = false;
            lblHSeleccionCategoria.Enabled = false;
            btnFinalH.Enabled = false;
            lblHTotal.Text = "Total: $" + numero;
        }
        public void activarRedireccion()
        {
            lblHPregunta.Enabled = true;
            btnHSi.Enabled = true;
            btnHNo.Enabled = true;

        }

        public void ClearPanels()
        {
            cmbHColor.SelectedItem = null;
            cmbHTalla.SelectedItem = null;
            rbtHPrenda1.Checked = false;
            rbtHPrenda2.Checked = false;
            rbtHPrenda3.Checked = false;
            rbtHPrenda4.Checked = false;
        }

        private void btnHComprar_Click(object sender, EventArgs e)
        {
            if (rbtHPrenda1.Checked == true || rbtHPrenda2.Checked == true || rbtHPrenda3.Checked == true || rbtHPrenda4.Checked == true)
            {

                if (rbtHPrenda1.Checked)
                {
                    if (cmbHTalla.SelectedItem != null && cmbHColor.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtHPrenda1.Text;
                        VentanarRegistro.producto.color = cmbHColor.Text;
                        VentanarRegistro.producto.talla =cmbHTalla.Text;
                        VentanarRegistro.producto.precioIndividual = 5.00;
                        VentanarRegistro.persona.tarjeta.totales.subtotal += 5;
                        this.Hide();

                        VentanaFacturacion facturar = new VentanaFacturacion();
                        facturar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selecciona talla y color ", "Advertencia");
                    }

                }

                if (rbtHPrenda2.Checked)
                {
                    if (cmbHTalla.SelectedItem != null && cmbHColor.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtHPrenda2.Text;
                        VentanarRegistro.producto.color = cmbHColor.Text;
                        VentanarRegistro.producto.talla = cmbHTalla.Text;
                        VentanarRegistro.producto.precioIndividual = 12.00;
                        VentanarRegistro.persona.tarjeta.totales.subtotal += 12;
                        this.Hide();

                        VentanaFacturacion facturar = new VentanaFacturacion();
                        facturar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selecciona talla y color ", "Advertencia");
                    }

                }
                if (rbtHPrenda3.Checked)
                {
                    if (cmbHTalla.SelectedItem != null && cmbHColor.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtHPrenda3.Text;
                        VentanarRegistro.producto.color = cmbHColor.Text;
                        VentanarRegistro.producto.talla = cmbHTalla.Text;
                        VentanarRegistro.producto.precioIndividual = 8.00;
                        VentanarRegistro.persona.tarjeta.totales.subtotal += 8;
                        this.Hide();

                        VentanaFacturacion facturar = new VentanaFacturacion();
                        facturar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selecciona talla y color ", "Advertencia");
                    }


                }
                if (rbtHPrenda4.Checked)
                {
                    if (cmbHTalla.SelectedItem != null && cmbHColor.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtHPrenda4.Text;
                        VentanarRegistro.producto.color = cmbHColor.Text;
                        VentanarRegistro.producto.talla = cmbHTalla.Text;
                        VentanarRegistro.producto.precioIndividual = 20.00;
                        VentanarRegistro.persona.tarjeta.totales.subtotal += 20;
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

        private void btnHAgregarC_Click(object sender, EventArgs e)
        {
            int contador1 = 0;

            if (rbtHPrenda1.Checked == true || rbtHPrenda2.Checked == true || rbtHPrenda3.Checked == true || rbtHPrenda4.Checked == true)
            {

                if (rbtHPrenda1.Checked)
                {
                    if (cmbHTalla.SelectedItem != null && cmbHColor.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtHPrenda1.Text;
                        VentanarRegistro.producto.color = cmbHColor.Text;
                        VentanarRegistro.producto.talla = cmbHTalla.Text;
                        VentanarRegistro.producto.precioIndividual = 5.00;
                        VentanarRegistro.persona.tarjeta.totales.subtotal += 5;
                        contador1++;
                    }
                    else
                    {
                        MessageBox.Show("Selecciona talla y color ", "Advertencia");
                    }

                }

                if (rbtHPrenda2.Checked)
                {
                    if (cmbHTalla.SelectedItem != null && cmbHColor.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtHPrenda2.Text;
                        VentanarRegistro.producto.color = cmbHColor.Text;
                        VentanarRegistro.producto.talla = cmbHTalla.Text;
                        VentanarRegistro.producto.precioIndividual = 12.00;
                        VentanarRegistro.persona.tarjeta.totales.subtotal += 12;
                        contador1++;
                    }
                    else
                    {
                        MessageBox.Show("Selecciona talla y color ", "Advertencia");
                    }

                }
                if (rbtHPrenda3.Checked)
                {
                    if (cmbHTalla.SelectedItem != null && cmbHColor.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtHPrenda3.Text;
                        VentanarRegistro.producto.color = cmbHColor.Text;
                        VentanarRegistro.producto.talla = cmbHTalla.Text;
                        VentanarRegistro.producto.precioIndividual = 8.00;
                        VentanarRegistro.persona.tarjeta.totales.subtotal += 8;
                        contador1++;
                    }
                    else
                    {
                        MessageBox.Show("Selecciona talla y color ", "Advertencia");
                    }


                }
                if (rbtHPrenda4.Checked)
                {
                    if (cmbHTalla.SelectedItem != null && cmbHColor.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtHPrenda4.Text;
                        VentanarRegistro.producto.color = cmbHColor.Text;
                        VentanarRegistro.producto.talla = cmbHTalla.Text;
                        VentanarRegistro.producto.precioIndividual = 20.00;
                        VentanarRegistro.persona.tarjeta.totales.subtotal += 20;
                        contador1++;
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

            numero = VentanarRegistro.persona.tarjeta.totales.subtotal;
            if (contador1 != 0)
            {
                btnFinalH.Enabled = true;
                lblHTotal.Text = "Total: $" + numero;
                ClearPanels();
                activarRedireccion();
                btnHComprar.Enabled = false;
                btnHAgregarC.Enabled = false;
                gpHombre.Enabled = false;
                cmbHTalla.Enabled = false;
                cmbHColor.Enabled = false;
            }


        }

        private void btnHSi_Click(object sender, EventArgs e)
        {
            btnHNo.Enabled = true;
            btnHIr.Enabled = true;
            cmbHSeleccionCategoria.Enabled = true;
            lblHSeleccionCategoria.Enabled = true;
        }

        private void btnHNo_Click(object sender, EventArgs e)
        {
            btnHSi.Enabled = true;
            btnHNo.Enabled = false;
            btnHAgregarC.Enabled = true;
            gpHombre.Enabled = true;
            cmbHTalla.Enabled = true;
            cmbHColor.Enabled = true;
            btnHIr.Enabled = false;
            cmbHSeleccionCategoria.Enabled = false;
            cmbHSeleccionCategoria.SelectedItem = null;
            lblHSeleccionCategoria.Enabled = false;
        }

        private void btnHIr_Click(object sender, EventArgs e)
        {
            if (cmbHSeleccionCategoria.Text == "Niño")
            {
                this.Hide();

                ventanaNino redireccionar = new ventanaNino();
                redireccionar.Show();
            }
            else
            {

                if (cmbHSeleccionCategoria.Text == "Mujer")
                {
                    this.Hide();

                    VentanaMujer redireccionar = new VentanaMujer();
                    redireccionar.Show();
                }
                else
                {
                    MessageBox.Show("Seleccione a donde desea redirigirse ");
                }
            }
        }

        private void btnAtrasH_Click(object sender, EventArgs e)
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

        private void btnFinalH_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentanaFacturacion facturar = new VentanaFacturacion();
            facturar.Show();
        }

 
    }
}
