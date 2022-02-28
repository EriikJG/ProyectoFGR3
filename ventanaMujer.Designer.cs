namespace ProyectGR3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblDama = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbTalla = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.pct = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rbtMCamiseta = new System.Windows.Forms.RadioButton();
            this.rbtMBlusa = new System.Windows.Forms.RadioButton();
            this.rbtMBuso = new System.Windows.Forms.RadioButton();
            this.rbtMPantalon = new System.Windows.Forms.RadioButton();
            this.lblMTotal = new System.Windows.Forms.Label();
            this.btnMComprar = new System.Windows.Forms.Button();
            this.btnMAgregarCarrito = new System.Windows.Forms.Button();
            this.lblMPregunta = new System.Windows.Forms.Label();
            this.rbtMSi = new System.Windows.Forms.RadioButton();
            this.rbtMNo = new System.Windows.Forms.RadioButton();
            this.lblMSeleccionCategoria = new System.Windows.Forms.Label();
            this.cmbSeleccionCategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDama
            // 
            this.lblDama.AutoSize = true;
            this.lblDama.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDama.Location = new System.Drawing.Point(486, 9);
            this.lblDama.Name = "lblDama";
            this.lblDama.Size = new System.Drawing.Size(144, 50);
            this.lblDama.TabIndex = 0;
            this.lblDama.Text = "DAMA";
            this.lblDama.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Location = new System.Drawing.Point(411, 698);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(48, 16);
            this.lblTalla.TabIndex = 1;
            this.lblTalla.Text = "TALLA";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(411, 745);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(53, 16);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "COLOR";
            // 
            // cmbTalla
            // 
            this.cmbTalla.FormattingEnabled = true;
            this.cmbTalla.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cmbTalla.Location = new System.Drawing.Point(518, 698);
            this.cmbTalla.Name = "cmbTalla";
            this.cmbTalla.Size = new System.Drawing.Size(121, 24);
            this.cmbTalla.TabIndex = 3;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "BLANCO",
            "ROJO ",
            "VERDE",
            "AMARILLO",
            "AZUL",
            "ROSA",
            "GRIS",
            "NEGRO"});
            this.cmbColor.Location = new System.Drawing.Point(518, 737);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 24);
            this.cmbColor.TabIndex = 4;
            // 
            // pct
            // 
            this.pct.Image = ((System.Drawing.Image)(resources.GetObject("pct.Image")));
            this.pct.Location = new System.Drawing.Point(94, 49);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(256, 265);
            this.pct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct.TabIndex = 5;
            this.pct.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(735, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(94, 346);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 270);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(733, 339);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(258, 274);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // rbtMCamiseta
            // 
            this.rbtMCamiseta.AutoSize = true;
            this.rbtMCamiseta.Location = new System.Drawing.Point(145, 320);
            this.rbtMCamiseta.Name = "rbtMCamiseta";
            this.rbtMCamiseta.Size = new System.Drawing.Size(154, 20);
            this.rbtMCamiseta.TabIndex = 11;
            this.rbtMCamiseta.TabStop = true;
            this.rbtMCamiseta.Text = "CAMISETA ESPAÑA";
            this.rbtMCamiseta.UseVisualStyleBackColor = true;
            // 
            // rbtMBlusa
            // 
            this.rbtMBlusa.AutoSize = true;
            this.rbtMBlusa.Location = new System.Drawing.Point(797, 313);
            this.rbtMBlusa.Name = "rbtMBlusa";
            this.rbtMBlusa.Size = new System.Drawing.Size(128, 20);
            this.rbtMBlusa.TabIndex = 12;
            this.rbtMBlusa.TabStop = true;
            this.rbtMBlusa.Text = "BLUSA ENCAJE";
            this.rbtMBlusa.UseVisualStyleBackColor = true;
            // 
            // rbtMBuso
            // 
            this.rbtMBuso.AutoSize = true;
            this.rbtMBuso.Location = new System.Drawing.Point(162, 622);
            this.rbtMBuso.Name = "rbtMBuso";
            this.rbtMBuso.Size = new System.Drawing.Size(129, 20);
            this.rbtMBuso.TabIndex = 14;
            this.rbtMBuso.TabStop = true;
            this.rbtMBuso.Text = "SUÉTER SNOW";
            this.rbtMBuso.UseVisualStyleBackColor = true;
            this.rbtMBuso.CheckedChanged += new System.EventHandler(this.rbtMBuso_CheckedChanged);
            // 
            // rbtMPantalon
            // 
            this.rbtMPantalon.AutoSize = true;
            this.rbtMPantalon.Location = new System.Drawing.Point(788, 622);
            this.rbtMPantalon.Name = "rbtMPantalon";
            this.rbtMPantalon.Size = new System.Drawing.Size(171, 20);
            this.rbtMPantalon.TabIndex = 15;
            this.rbtMPantalon.TabStop = true;
            this.rbtMPantalon.Text = "PANTALÓN ULTIMATE";
            this.rbtMPantalon.UseVisualStyleBackColor = true;
            // 
            // lblMTotal
            // 
            this.lblMTotal.AutoSize = true;
            this.lblMTotal.Location = new System.Drawing.Point(871, 9);
            this.lblMTotal.Name = "lblMTotal";
            this.lblMTotal.Size = new System.Drawing.Size(70, 16);
            this.lblMTotal.TabIndex = 17;
            this.lblMTotal.Text = "TOTAL $ : ";
            // 
            // btnMComprar
            // 
            this.btnMComprar.Location = new System.Drawing.Point(476, 790);
            this.btnMComprar.Name = "btnMComprar";
            this.btnMComprar.Size = new System.Drawing.Size(86, 23);
            this.btnMComprar.TabIndex = 18;
            this.btnMComprar.Text = "COMPRAR";
            this.btnMComprar.UseVisualStyleBackColor = true;
            // 
            // btnMAgregarCarrito
            // 
            this.btnMAgregarCarrito.Location = new System.Drawing.Point(424, 819);
            this.btnMAgregarCarrito.Name = "btnMAgregarCarrito";
            this.btnMAgregarCarrito.Size = new System.Drawing.Size(186, 23);
            this.btnMAgregarCarrito.TabIndex = 19;
            this.btnMAgregarCarrito.Text = "AGREGAR AL CARRITO";
            this.btnMAgregarCarrito.UseVisualStyleBackColor = true;
            // 
            // lblMPregunta
            // 
            this.lblMPregunta.AutoSize = true;
            this.lblMPregunta.Location = new System.Drawing.Point(313, 868);
            this.lblMPregunta.Name = "lblMPregunta";
            this.lblMPregunta.Size = new System.Drawing.Size(195, 16);
            this.lblMPregunta.TabIndex = 20;
            this.lblMPregunta.Text = "¿Desea dirigirse a otra página?";
            // 
            // rbtMSi
            // 
            this.rbtMSi.AutoSize = true;
            this.rbtMSi.Location = new System.Drawing.Point(582, 864);
            this.rbtMSi.Name = "rbtMSi";
            this.rbtMSi.Size = new System.Drawing.Size(40, 20);
            this.rbtMSi.TabIndex = 21;
            this.rbtMSi.TabStop = true;
            this.rbtMSi.Text = "SI";
            this.rbtMSi.UseVisualStyleBackColor = true;
            // 
            // rbtMNo
            // 
            this.rbtMNo.AutoSize = true;
            this.rbtMNo.Location = new System.Drawing.Point(668, 864);
            this.rbtMNo.Name = "rbtMNo";
            this.rbtMNo.Size = new System.Drawing.Size(48, 20);
            this.rbtMNo.TabIndex = 22;
            this.rbtMNo.TabStop = true;
            this.rbtMNo.Text = "NO";
            this.rbtMNo.UseVisualStyleBackColor = true;
            // 
            // lblMSeleccionCategoria
            // 
            this.lblMSeleccionCategoria.AutoSize = true;
            this.lblMSeleccionCategoria.Location = new System.Drawing.Point(313, 914);
            this.lblMSeleccionCategoria.Name = "lblMSeleccionCategoria";
            this.lblMSeleccionCategoria.Size = new System.Drawing.Size(191, 16);
            this.lblMSeleccionCategoria.TabIndex = 23;
            this.lblMSeleccionCategoria.Text = "SELECCIONE LA CATEGORÍA";
            // 
            // cmbSeleccionCategoria
            // 
            this.cmbSeleccionCategoria.FormattingEnabled = true;
            this.cmbSeleccionCategoria.Items.AddRange(new object[] {
            "HOMBRE",
            "NIÑO",
            "MUJER",
            ""});
            this.cmbSeleccionCategoria.Location = new System.Drawing.Point(582, 907);
            this.cmbSeleccionCategoria.Name = "cmbSeleccionCategoria";
            this.cmbSeleccionCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbSeleccionCategoria.TabIndex = 24;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(518, 71);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(440, 301);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(223, 178);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(361, 809);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 978);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cmbSeleccionCategoria);
            this.Controls.Add(this.lblMSeleccionCategoria);
            this.Controls.Add(this.rbtMNo);
            this.Controls.Add(this.rbtMSi);
            this.Controls.Add(this.lblMPregunta);
            this.Controls.Add(this.btnMAgregarCarrito);
            this.Controls.Add(this.btnMComprar);
            this.Controls.Add(this.lblMTotal);
            this.Controls.Add(this.rbtMPantalon);
            this.Controls.Add(this.rbtMBuso);
            this.Controls.Add(this.rbtMBlusa);
            this.Controls.Add(this.rbtMCamiseta);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pct);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbTalla);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblTalla);
            this.Controls.Add(this.lblDama);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "ROPA DE MUJER";
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDama;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cmbTalla;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton rbtMCamiseta;
        private System.Windows.Forms.RadioButton rbtMBlusa;
        private System.Windows.Forms.RadioButton rbtMBuso;
        private System.Windows.Forms.RadioButton rbtMPantalon;
        private System.Windows.Forms.Label lblMTotal;
        private System.Windows.Forms.Button btnMComprar;
        private System.Windows.Forms.Button btnMAgregarCarrito;
        private System.Windows.Forms.Label lblMPregunta;
        private System.Windows.Forms.RadioButton rbtMSi;
        private System.Windows.Forms.RadioButton rbtMNo;
        private System.Windows.Forms.Label lblMSeleccionCategoria;
        private System.Windows.Forms.ComboBox cmbSeleccionCategoria;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}