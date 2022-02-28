﻿using System;
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
    public partial class VentanarRegistro : Form
    {
        public VentanarRegistro()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
        }


        private void controlBotones()
        {
            if (txtNombre.Text.Trim() != string.Empty && txtNombre.Text.All(Char.IsLetter))
            {
                btnIngresar.Enabled = true;
                errorProvider1.SetError(txtNombre, "");
            }
            else
            {
                if (!(txtNombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(txtNombre, "El nombre sólo debe contener letras");
                }
                else
                {

                    errorProvider1.SetError(txtNombre, "Debe introducir su nombre");
                    btnIngresar.Enabled = false;
                    txtNombre.Focus();
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentanaCategoria newframe = new VentanaCategoria();
            newframe.Show();

            
        }
    }
}