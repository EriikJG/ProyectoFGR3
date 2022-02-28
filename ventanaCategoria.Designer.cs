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
            this.lblPgPrincipal = new System.Windows.Forms.Label();
            this.lbltxtcategoria = new System.Windows.Forms.Label();
            this.lblcategoriaP = new System.Windows.Forms.Label();
            this.cmbCategoriaP = new System.Windows.Forms.ComboBox();
            this.btnSiguienteP = new System.Windows.Forms.Button();
            this.picbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPgPrincipal
            // 
            this.lblPgPrincipal.AutoSize = true;
            this.lblPgPrincipal.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPgPrincipal.Location = new System.Drawing.Point(301, 55);
            this.lblPgPrincipal.Name = "lblPgPrincipal";
            this.lblPgPrincipal.Size = new System.Drawing.Size(202, 25);
            this.lblPgPrincipal.TabIndex = 0;
            this.lblPgPrincipal.Text = "PÁGINA PRINCIPAL";
            // 
            // lbltxtcategoria
            // 
            this.lbltxtcategoria.AutoSize = true;
            this.lbltxtcategoria.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtcategoria.Location = new System.Drawing.Point(256, 176);
            this.lbltxtcategoria.Name = "lbltxtcategoria";
            this.lbltxtcategoria.Size = new System.Drawing.Size(309, 21);
            this.lbltxtcategoria.TabIndex = 1;
            this.lbltxtcategoria.Text = "Elija la  categoria en la que desea comprar";
            // 
            // lblcategoriaP
            // 
            this.lblcategoriaP.AutoSize = true;
            this.lblcategoriaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoriaP.Location = new System.Drawing.Point(271, 253);
            this.lblcategoriaP.Name = "lblcategoriaP";
            this.lblcategoriaP.Size = new System.Drawing.Size(57, 13);
            this.lblcategoriaP.TabIndex = 2;
            this.lblcategoriaP.Text = "Categoría:";
            // 
            // cmbCategoriaP
            // 
            this.cmbCategoriaP.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCategoriaP.FormattingEnabled = true;
            this.cmbCategoriaP.Items.AddRange(new object[] {
            "Para Niños",
            "Para Hombre",
            "Para Mujer"});
            this.cmbCategoriaP.Location = new System.Drawing.Point(349, 245);
            this.cmbCategoriaP.Name = "cmbCategoriaP";
            this.cmbCategoriaP.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoriaP.TabIndex = 3;
            // 
            // btnSiguienteP
            // 
            this.btnSiguienteP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteP.Location = new System.Drawing.Point(361, 329);
            this.btnSiguienteP.Name = "btnSiguienteP";
            this.btnSiguienteP.Size = new System.Drawing.Size(88, 29);
            this.btnSiguienteP.TabIndex = 4;
            this.btnSiguienteP.Text = "Siguiente";
            this.btnSiguienteP.UseVisualStyleBackColor = true;
            // 
            // picbImagen
            // 
            this.picbImagen.Image = global::ProyectGR3.Properties.Resources.dfe2bf416023b848bb590f2ff5509162;
            this.picbImagen.Location = new System.Drawing.Point(349, 84);
            this.picbImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picbImagen.Name = "picbImagen";
            this.picbImagen.Size = new System.Drawing.Size(100, 50);
            this.picbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbImagen.TabIndex = 5;
            this.picbImagen.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.picbImagen);
            this.Controls.Add(this.btnSiguienteP);
            this.Controls.Add(this.cmbCategoriaP);
            this.Controls.Add(this.lblcategoriaP);
            this.Controls.Add(this.lbltxtcategoria);
            this.Controls.Add(this.lblPgPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "CATEGORIA";
            ((System.ComponentModel.ISupportInitialize)(this.picbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPgPrincipal;
        private System.Windows.Forms.Label lbltxtcategoria;
        private System.Windows.Forms.Label lblcategoriaP;
        private System.Windows.Forms.ComboBox cmbCategoriaP;
        private System.Windows.Forms.Button btnSiguienteP;
        private System.Windows.Forms.PictureBox picbImagen;
    }
}