namespace ProyectGR3
{
    partial class VentanaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaCategoria));
            this.lblPagP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltxtPagP = new System.Windows.Forms.Label();
            this.lblEcategoria = new System.Windows.Forms.Label();
            this.cbmCategoria = new System.Windows.Forms.ComboBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPagP
            // 
            this.lblPagP.AutoSize = true;
            this.lblPagP.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagP.Location = new System.Drawing.Point(302, 44);
            this.lblPagP.Name = "lblPagP";
            this.lblPagP.Size = new System.Drawing.Size(169, 21);
            this.lblPagP.TabIndex = 0;
            this.lblPagP.Text = "PÁGINA PRINCIPAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbltxtPagP
            // 
            this.lbltxtPagP.AutoSize = true;
            this.lbltxtPagP.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtPagP.Location = new System.Drawing.Point(247, 175);
            this.lbltxtPagP.Name = "lbltxtPagP";
            this.lbltxtPagP.Size = new System.Drawing.Size(286, 20);
            this.lbltxtPagP.TabIndex = 2;
            this.lbltxtPagP.Text = " Elija la categoria en la que desea comprar";
            // 
            // lblEcategoria
            // 
            this.lblEcategoria.AutoSize = true;
            this.lblEcategoria.Location = new System.Drawing.Point(230, 266);
            this.lblEcategoria.Name = "lblEcategoria";
            this.lblEcategoria.Size = new System.Drawing.Size(55, 13);
            this.lblEcategoria.TabIndex = 3;
            this.lblEcategoria.Text = "Categoria:";
            // 
            // cbmCategoria
            // 
            this.cbmCategoria.FormattingEnabled = true;
            this.cbmCategoria.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Niños"});
            this.cbmCategoria.Location = new System.Drawing.Point(338, 258);
            this.cbmCategoria.Name = "cbmCategoria";
            this.cbmCategoria.Size = new System.Drawing.Size(144, 21);
            this.cbmCategoria.TabIndex = 4;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(338, 344);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // VentanaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.cbmCategoria);
            this.Controls.Add(this.lblEcategoria);
            this.Controls.Add(this.lbltxtPagP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPagP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaCategoria";
            this.Text = "Categoría";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPagP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltxtPagP;
        private System.Windows.Forms.Label lblEcategoria;
        private System.Windows.Forms.ComboBox cbmCategoria;
        private System.Windows.Forms.Button btnSiguiente;
    }
}