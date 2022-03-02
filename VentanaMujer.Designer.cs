using System;

namespace ProyectGR3
{
    partial class VentanaMujer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaMujer));
            this.lblDama = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbMTalla = new System.Windows.Forms.ComboBox();
            this.cmbMColor = new System.Windows.Forms.ComboBox();
            this.lblMTotal = new System.Windows.Forms.Label();
            this.btnMComprar = new System.Windows.Forms.Button();
            this.btnMAgregarCarrito = new System.Windows.Forms.Button();
            this.lblMPregunta = new System.Windows.Forms.Label();
            this.lblMSeleccionCategoria = new System.Windows.Forms.Label();
            this.cmbMSeleccionCategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pct = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnMSi = new System.Windows.Forms.Button();
            this.btnMNo = new System.Windows.Forms.Button();
            this.btnMIr = new System.Windows.Forms.Button();
            this.btnFinalM = new System.Windows.Forms.Button();
            this.gpMujer = new System.Windows.Forms.GroupBox();
            this.rbtMPrenda2 = new System.Windows.Forms.RadioButton();
            this.rbtMPrenda1 = new System.Windows.Forms.RadioButton();
            this.rbtMPrenda3 = new System.Windows.Forms.RadioButton();
            this.rbtMPrenda4 = new System.Windows.Forms.RadioButton();
            this.btnAtrasM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.gpMujer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDama
            // 
            this.lblDama.AutoSize = true;
            this.lblDama.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDama.Location = new System.Drawing.Point(364, 7);
            this.lblDama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDama.Name = "lblDama";
            this.lblDama.Size = new System.Drawing.Size(115, 41);
            this.lblDama.TabIndex = 0;
            this.lblDama.Text = "DAMA";
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Location = new System.Drawing.Point(352, 429);
            this.lblTalla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(33, 13);
            this.lblTalla.TabIndex = 1;
            this.lblTalla.Text = "Talla:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(363, 512);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            // 
            // cmbMTalla
            // 
            this.cmbMTalla.FormattingEnabled = true;
            this.cmbMTalla.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cmbMTalla.Location = new System.Drawing.Point(389, 421);
            this.cmbMTalla.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMTalla.Name = "cmbMTalla";
            this.cmbMTalla.Size = new System.Drawing.Size(92, 21);
            this.cmbMTalla.TabIndex = 3;
            // 
            // cmbMColor
            // 
            this.cmbMColor.FormattingEnabled = true;
            this.cmbMColor.Items.AddRange(new object[] {
            "BLANCO",
            "ROJO ",
            "VERDE",
            "AMARILLO",
            "AZUL",
            "ROSA",
            "GRIS",
            "NEGRO"});
            this.cmbMColor.Location = new System.Drawing.Point(401, 504);
            this.cmbMColor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMColor.Name = "cmbMColor";
            this.cmbMColor.Size = new System.Drawing.Size(92, 21);
            this.cmbMColor.TabIndex = 4;
            // 
            // lblMTotal
            // 
            this.lblMTotal.AutoSize = true;
            this.lblMTotal.Location = new System.Drawing.Point(704, 28);
            this.lblMTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMTotal.Name = "lblMTotal";
            this.lblMTotal.Size = new System.Drawing.Size(60, 13);
            this.lblMTotal.TabIndex = 17;
            this.lblMTotal.Text = "TOTAL $ : ";
            // 
            // btnMComprar
            // 
            this.btnMComprar.Location = new System.Drawing.Point(401, 532);
            this.btnMComprar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMComprar.Name = "btnMComprar";
            this.btnMComprar.Size = new System.Drawing.Size(87, 22);
            this.btnMComprar.TabIndex = 18;
            this.btnMComprar.Text = "COMPRAR";
            this.btnMComprar.UseVisualStyleBackColor = true;
            this.btnMComprar.Click += new System.EventHandler(this.btnMComprar_Click);
            // 
            // btnMAgregarCarrito
            // 
            this.btnMAgregarCarrito.Location = new System.Drawing.Point(371, 558);
            this.btnMAgregarCarrito.Margin = new System.Windows.Forms.Padding(2);
            this.btnMAgregarCarrito.Name = "btnMAgregarCarrito";
            this.btnMAgregarCarrito.Size = new System.Drawing.Size(158, 27);
            this.btnMAgregarCarrito.TabIndex = 19;
            this.btnMAgregarCarrito.Text = "AGREGAR AL CARRITO";
            this.btnMAgregarCarrito.UseVisualStyleBackColor = true;
            this.btnMAgregarCarrito.Click += new System.EventHandler(this.btnMAgregarCarrito_Click);
            // 
            // lblMPregunta
            // 
            this.lblMPregunta.AutoSize = true;
            this.lblMPregunta.Location = new System.Drawing.Point(290, 603);
            this.lblMPregunta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMPregunta.Name = "lblMPregunta";
            this.lblMPregunta.Size = new System.Drawing.Size(153, 13);
            this.lblMPregunta.TabIndex = 20;
            this.lblMPregunta.Text = "¿Desea dirigirse a otra página?";
            // 
            // lblMSeleccionCategoria
            // 
            this.lblMSeleccionCategoria.AutoSize = true;
            this.lblMSeleccionCategoria.Location = new System.Drawing.Point(469, 605);
            this.lblMSeleccionCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMSeleccionCategoria.Name = "lblMSeleccionCategoria";
            this.lblMSeleccionCategoria.Size = new System.Drawing.Size(118, 13);
            this.lblMSeleccionCategoria.TabIndex = 23;
            this.lblMSeleccionCategoria.Text = "Seleccione la categoria";
            // 
            // cmbMSeleccionCategoria
            // 
            this.cmbMSeleccionCategoria.FormattingEnabled = true;
            this.cmbMSeleccionCategoria.Items.AddRange(new object[] {
            "HOMBRE",
            "NIÑO",
            ""});
            this.cmbMSeleccionCategoria.Location = new System.Drawing.Point(591, 605);
            this.cmbMSeleccionCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMSeleccionCategoria.Name = "cmbMSeleccionCategoria";
            this.cmbMSeleccionCategoria.Size = new System.Drawing.Size(127, 21);
            this.cmbMSeleccionCategoria.TabIndex = 24;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(338, 558);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(359, 172);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(122, 101);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(379, 18);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(603, 285);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(194, 183);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(99, 280);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 188);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(605, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pct
            // 
            this.pct.Image = ((System.Drawing.Image)(resources.GetObject("pct.Image")));
            this.pct.Location = new System.Drawing.Point(109, 85);
            this.pct.Margin = new System.Windows.Forms.Padding(2);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(192, 165);
            this.pct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct.TabIndex = 5;
            this.pct.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(547, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "$10.00";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(525, 101);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(101, 97);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 36;
            this.pictureBox11.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(547, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "$12.00";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(515, 353);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(101, 97);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 38;
            this.pictureBox7.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "$20.00";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(12, 362);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(101, 97);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 40;
            this.pictureBox8.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "$6.00";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(12, 130);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(101, 97);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 42;
            this.pictureBox9.TabStop = false;
            // 
            // btnMSi
            // 
            this.btnMSi.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnMSi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMSi.Location = new System.Drawing.Point(385, 619);
            this.btnMSi.Name = "btnMSi";
            this.btnMSi.Size = new System.Drawing.Size(55, 23);
            this.btnMSi.TabIndex = 72;
            this.btnMSi.Text = "SI";
            this.btnMSi.UseVisualStyleBackColor = false;
            this.btnMSi.Click += new System.EventHandler(this.btnMSi_Click);
            // 
            // btnMNo
            // 
            this.btnMNo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnMNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMNo.Location = new System.Drawing.Point(293, 619);
            this.btnMNo.Name = "btnMNo";
            this.btnMNo.Size = new System.Drawing.Size(55, 23);
            this.btnMNo.TabIndex = 73;
            this.btnMNo.Text = "NO";
            this.btnMNo.UseVisualStyleBackColor = false;
            this.btnMNo.Click += new System.EventHandler(this.btnMNo_Click);
            // 
            // btnMIr
            // 
            this.btnMIr.Location = new System.Drawing.Point(525, 638);
            this.btnMIr.Name = "btnMIr";
            this.btnMIr.Size = new System.Drawing.Size(75, 23);
            this.btnMIr.TabIndex = 74;
            this.btnMIr.Text = "Ir";
            this.btnMIr.UseVisualStyleBackColor = true;
            this.btnMIr.Click += new System.EventHandler(this.btnMIr_Click);
            // 
            // btnFinalM
            // 
            this.btnFinalM.BackColor = System.Drawing.Color.RosyBrown;
            this.btnFinalM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalM.Location = new System.Drawing.Point(632, 532);
            this.btnFinalM.Name = "btnFinalM";
            this.btnFinalM.Size = new System.Drawing.Size(86, 53);
            this.btnFinalM.TabIndex = 75;
            this.btnFinalM.Text = "Facturar";
            this.btnFinalM.UseVisualStyleBackColor = false;
            this.btnFinalM.Click += new System.EventHandler(this.btnFinalM_Click);
            // 
            // gpMujer
            // 
            this.gpMujer.Controls.Add(this.rbtMPrenda2);
            this.gpMujer.Controls.Add(this.rbtMPrenda1);
            this.gpMujer.Controls.Add(this.rbtMPrenda3);
            this.gpMujer.Controls.Add(this.rbtMPrenda4);
            this.gpMujer.Controls.Add(this.lblTalla);
            this.gpMujer.Controls.Add(this.cmbMTalla);
            this.gpMujer.Controls.Add(this.pictureBox5);
            this.gpMujer.Controls.Add(this.pictureBox4);
            this.gpMujer.Location = new System.Drawing.Point(12, 51);
            this.gpMujer.Name = "gpMujer";
            this.gpMujer.Size = new System.Drawing.Size(821, 448);
            this.gpMujer.TabIndex = 76;
            this.gpMujer.TabStop = false;
            // 
            // rbtMPrenda2
            // 
            this.rbtMPrenda2.AutoSize = true;
            this.rbtMPrenda2.Location = new System.Drawing.Point(644, 203);
            this.rbtMPrenda2.Margin = new System.Windows.Forms.Padding(2);
            this.rbtMPrenda2.Name = "rbtMPrenda2";
            this.rbtMPrenda2.Size = new System.Drawing.Size(87, 17);
            this.rbtMPrenda2.TabIndex = 77;
            this.rbtMPrenda2.TabStop = true;
            this.rbtMPrenda2.Text = "Blusa Encaje";
            this.rbtMPrenda2.UseVisualStyleBackColor = true;
            // 
            // rbtMPrenda1
            // 
            this.rbtMPrenda1.AutoSize = true;
            this.rbtMPrenda1.Location = new System.Drawing.Point(131, 203);
            this.rbtMPrenda1.Margin = new System.Windows.Forms.Padding(2);
            this.rbtMPrenda1.Name = "rbtMPrenda1";
            this.rbtMPrenda1.Size = new System.Drawing.Size(107, 17);
            this.rbtMPrenda1.TabIndex = 18;
            this.rbtMPrenda1.TabStop = true;
            this.rbtMPrenda1.Text = "Camiseta España";
            this.rbtMPrenda1.UseVisualStyleBackColor = true;
            // 
            // rbtMPrenda3
            // 
            this.rbtMPrenda3.AutoSize = true;
            this.rbtMPrenda3.Location = new System.Drawing.Point(131, 421);
            this.rbtMPrenda3.Margin = new System.Windows.Forms.Padding(2);
            this.rbtMPrenda3.Name = "rbtMPrenda3";
            this.rbtMPrenda3.Size = new System.Drawing.Size(86, 17);
            this.rbtMPrenda3.TabIndex = 17;
            this.rbtMPrenda3.TabStop = true;
            this.rbtMPrenda3.Text = "Sueter Snow";
            this.rbtMPrenda3.UseVisualStyleBackColor = true;
            // 
            // rbtMPrenda4
            // 
            this.rbtMPrenda4.AutoSize = true;
            this.rbtMPrenda4.Location = new System.Drawing.Point(644, 421);
            this.rbtMPrenda4.Margin = new System.Windows.Forms.Padding(2);
            this.rbtMPrenda4.Name = "rbtMPrenda4";
            this.rbtMPrenda4.Size = new System.Drawing.Size(108, 17);
            this.rbtMPrenda4.TabIndex = 16;
            this.rbtMPrenda4.TabStop = true;
            this.rbtMPrenda4.Text = "Pantalón Ultimate";
            this.rbtMPrenda4.UseVisualStyleBackColor = true;
            // 
            // btnAtrasM
            // 
            this.btnAtrasM.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAtrasM.Image = ((System.Drawing.Image)(resources.GetObject("btnAtrasM.Image")));
            this.btnAtrasM.Location = new System.Drawing.Point(17, 7);
            this.btnAtrasM.Name = "btnAtrasM";
            this.btnAtrasM.Size = new System.Drawing.Size(53, 38);
            this.btnAtrasM.TabIndex = 77;
            this.btnAtrasM.UseVisualStyleBackColor = false;
            this.btnAtrasM.Click += new System.EventHandler(this.btnAtrasM_Click);
            // 
            // VentanaMujer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAtrasM);
            this.Controls.Add(this.cmbMColor);
            this.Controls.Add(this.btnFinalM);
            this.Controls.Add(this.btnMIr);
            this.Controls.Add(this.btnMNo);
            this.Controls.Add(this.btnMSi);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.cmbMSeleccionCategoria);
            this.Controls.Add(this.lblMSeleccionCategoria);
            this.Controls.Add(this.lblMPregunta);
            this.Controls.Add(this.btnMAgregarCarrito);
            this.Controls.Add(this.btnMComprar);
            this.Controls.Add(this.lblMTotal);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pct);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblDama);
            this.Controls.Add(this.gpMujer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VentanaMujer";
            this.Text = "ROPA DE MUJER";
            this.Load += new System.EventHandler(this.VentanaMujer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.gpMujer.ResumeLayout(false);
            this.gpMujer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDama;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cmbMTalla;
        private System.Windows.Forms.ComboBox cmbMColor;
        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblMTotal;
        private System.Windows.Forms.Button btnMComprar;
        private System.Windows.Forms.Button btnMAgregarCarrito;
        private System.Windows.Forms.Label lblMPregunta;
        private System.Windows.Forms.Label lblMSeleccionCategoria;
        private System.Windows.Forms.ComboBox cmbMSeleccionCategoria;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btnMSi;
        private System.Windows.Forms.Button btnMNo;
        private System.Windows.Forms.Button btnMIr;
        private System.Windows.Forms.Button btnFinalM;
        private System.Windows.Forms.GroupBox gpMujer;
        private System.Windows.Forms.RadioButton rbtMPrenda2;
        private System.Windows.Forms.RadioButton rbtMPrenda1;
        private System.Windows.Forms.RadioButton rbtMPrenda3;
        private System.Windows.Forms.RadioButton rbtMPrenda4;
        private System.Windows.Forms.Button btnAtrasM;
    }
}