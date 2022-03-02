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
        public double numero = VentanarRegistro.persona.tarjeta.totales.subtotal;
       

        public ventanaNino()
        {
            InitializeComponent();


        }

        private void ventanaNino_Load(object sender, EventArgs e)
        {
            lblNPregunta.Enabled = true;
            btnNNo.Enabled = false;
            btnNSi.Enabled = true;
            btnNIr.Enabled = false;
            cmbNSeleccionCategoria.Enabled = false;
            lblNSeleccionCategoria.Enabled = false;
            btnFinal.Enabled = false;
            lblNTotal.Text="Total: $"+numero;

        }

        public void activarRedireccion()
        {
            lblNPregunta.Enabled = true;
            btnNSi.Enabled = true;
            btnNNo.Enabled = true;

        }

        public void ClearPanels()
        {
            cmbColorN.SelectedItem = null;
            cmbTallaN.SelectedItem = null;
            rbtNPrenda1.Checked = false;
            rbtNPrenda2.Checked = false;
            rbtNPrenda3.Checked = false;
            rbtNPrenda4.Checked = false;
        }



        private void btnNComprar_Click(object sender, EventArgs e)
        {

            if (rbtNPrenda1.Checked == true || rbtNPrenda2.Checked == true || rbtNPrenda3.Checked == true || rbtNPrenda4.Checked == true)
            {

                if (rbtNPrenda1.Checked)
                {
                    if (cmbTallaN.SelectedItem != null && cmbColorN.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtNPrenda1.Text;
                        VentanarRegistro.producto.color = cmbColorN.Text;
                        VentanarRegistro.producto.talla = cmbTallaN.Text;
                        VentanarRegistro.producto.precioIndividual = 10.00;
                        VentanarRegistro.persona.tarjeta.totales.subtotal  += 10;
                       
                        this.Hide();

                        VentanaFacturacion facturar = new VentanaFacturacion();
                        facturar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selecciona talla y color ", "Advertencia");
                    }

                }

                if (rbtNPrenda2.Checked)
                {
                    if (cmbTallaN.SelectedItem != null && cmbColorN.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtNPrenda2.Text;
                        VentanarRegistro.producto.color = cmbColorN.Text;
                        VentanarRegistro.producto.talla = cmbTallaN.Text;
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
                if (rbtNPrenda3.Checked)
                {
                    if (cmbTallaN.SelectedItem != null && cmbColorN.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtNPrenda3.Text;
                        VentanarRegistro.producto.color = cmbColorN.Text;
                        VentanarRegistro.producto.talla = cmbTallaN.Text;
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
                if (rbtNPrenda4.Checked)
                {
                    if (cmbTallaN.SelectedItem != null && cmbColorN.SelectedItem != null)
                    {
                        VentanarRegistro.producto.nombreProducto = rbtNPrenda4.Text;
                        VentanarRegistro.producto.color = cmbColorN.Text;
                        VentanarRegistro.producto.talla = cmbTallaN.Text;
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

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            int contador = 0;
           


                if (rbtNPrenda1.Checked == true || rbtNPrenda2.Checked == true || rbtNPrenda3.Checked == true || rbtNPrenda4.Checked == true)
                {

                    if (rbtNPrenda1.Checked)
                    {
                        if (cmbTallaN.SelectedItem != null && cmbColorN.SelectedItem != null)
                        {
                        VentanarRegistro.producto.categoria = "Niño";
                        VentanarRegistro.producto.nombreProducto = rbtNPrenda1.Text;
                        VentanarRegistro.producto.color = cmbColorN.Text;
                        VentanarRegistro.producto.talla = cmbTallaN.Text;
                        VentanarRegistro.producto.precioIndividual = 10.00;
                        VentanarRegistro.persona.tarjeta.totales.subtotal += 10;
                        contador++;
                        }
                        else
                        {
                          MessageBox.Show("Selecciona talla y color ", "Advertencia");
                        }

                    }

                    if (rbtNPrenda2.Checked)
                    {
                        if (cmbTallaN.SelectedItem != null && cmbColorN.SelectedItem != null)
                    {
                        VentanarRegistro.producto.categoria = "Niño";
                        VentanarRegistro.producto.nombreProducto = rbtNPrenda2.Text;
                        VentanarRegistro.producto.color = cmbColorN.Text;
                        VentanarRegistro.producto.talla = cmbTallaN.Text;
                        VentanarRegistro.producto.precioIndividual = 5.00;
                        VentanarRegistro.persona.tarjeta.totales.subtotal += 5;
                       
                        contador++;
                    }

                        else
                        {
                           MessageBox.Show("Selecciona talla y color ", "Advertencia");
                        }

                    }
                    if (rbtNPrenda3.Checked)
                    {
                        if (cmbTallaN.SelectedItem != null && cmbColorN.SelectedItem != null)
                        {
                        VentanarRegistro.producto.nombreProducto = rbtNPrenda3.Text;
                        VentanarRegistro.producto.color = cmbColorN.Text;
                        VentanarRegistro.producto.talla = cmbTallaN.Text;
                        VentanarRegistro.producto.precioIndividual = 8.00;
                        VentanarRegistro.persona.tarjeta.totales.subtotal += 8;
                        contador++;
                        }
                        else
                        {
                            MessageBox.Show("Selecciona talla y color ", "Advertencia");
                          }


                    }
                    if (rbtNPrenda4.Checked)
                    {
                        if (cmbTallaN.SelectedItem != null && cmbColorN.SelectedItem != null)
                        {
                        VentanarRegistro.producto.nombreProducto = rbtNPrenda4.Text;
                        VentanarRegistro.producto.color = cmbColorN.Text;
                        VentanarRegistro.producto.talla = cmbTallaN.Text;
                        VentanarRegistro.producto.precioIndividual = 20.00;
                        VentanarRegistro.persona.tarjeta.totales.subtotal += 20;
                        contador++;
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
            if (contador != 0)
            {
                btnFinal.Enabled = true;
                lblNTotal.Text = "Total: $" + numero;
                ClearPanels();
                activarRedireccion();
                btnNComprar.Enabled = false;
                btnAgregarCarrito.Enabled = false;
                gpNinos.Enabled = false;
                cmbTallaN.Enabled = false;
                cmbColorN.Enabled = false;
            }
            

        }

        private void btnNSi_Click(object sender, EventArgs e)
        {
            btnNNo.Enabled = true;
            btnNIr.Enabled = true;
            cmbNSeleccionCategoria.Enabled = true;
            lblNSeleccionCategoria.Enabled = true;
        }

        private void btnNNo_Click(object sender, EventArgs e)
        {
            btnNSi.Enabled = true;
            btnNNo.Enabled = false;
            btnAgregarCarrito.Enabled = true;
            gpNinos.Enabled = true;
            cmbTallaN.Enabled = true;
            cmbColorN.Enabled = true;
            btnNIr.Enabled = false;
            cmbNSeleccionCategoria.Enabled = false;
            cmbNSeleccionCategoria.SelectedItem = null;
            lblNSeleccionCategoria.Enabled = false;
        }

        private void btnNIr_Click(object sender, EventArgs e)
        {
            if (cmbNSeleccionCategoria.Text == "Hombre")
            {
                this.Hide();

                VentanaHombre redireccionar = new VentanaHombre();
                redireccionar.Show();
            }
            else
            {

                if (cmbNSeleccionCategoria.Text == "Mujer")
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

        private void btnAtrasN_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Si continua se borrara todos los cambios", "Advertencia", botones, MessageBoxIcon.Warning);

            if(dr == DialogResult.OK)
            {
                this.Hide();

                VentanaCategoria redireccionar = new VentanaCategoria();
                redireccionar.Show();
                VentanarRegistro.persona.tarjeta.totales.subtotal = 0;

            }    
               
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            VentanaFacturacion facturar = new VentanaFacturacion();

            facturar.Show();
        }
    }
}
