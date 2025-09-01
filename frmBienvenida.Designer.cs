namespace prySinterpartRomo
{
    partial class frmBienvenida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTitulo = new Label();
            pctFiat = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctFiat).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.Location = new Point(41, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 37);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "¡Bienvenido a Sintepart!";
            // 
            // pctFiat
            // 
            pctFiat.Image = Properties.Resources.Fiatlogo;
            pctFiat.Location = new Point(119, 98);
            pctFiat.Name = "pctFiat";
            pctFiat.Size = new Size(143, 142);
            pctFiat.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFiat.TabIndex = 4;
            pctFiat.TabStop = false;
            // 
            // frmBienvenida
            // 
            ClientSize = new Size(388, 288);
            Controls.Add(pctFiat);
            Controls.Add(lblTitulo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBienvenida";
            Text = "Bienvenido";
            ((System.ComponentModel.ISupportInitialize)pctFiat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTitulo;
        private PictureBox pctFiat;
    }
}
