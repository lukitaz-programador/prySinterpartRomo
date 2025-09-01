namespace prySinterpartRomo
{
    partial class frmLogin
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
            lblUsuarioo = new Label();
            lblContraseña = new Label();
            lblModulo = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            lstModulo = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblUsuarioo
            // 
            lblUsuarioo.AutoSize = true;
            lblUsuarioo.Font = new Font("Segoe UI", 12F);
            lblUsuarioo.Location = new Point(43, 39);
            lblUsuarioo.Name = "lblUsuarioo";
            lblUsuarioo.Size = new Size(67, 21);
            lblUsuarioo.TabIndex = 0;
            lblUsuarioo.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 12F);
            lblContraseña.Location = new Point(43, 88);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(92, 21);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña:";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Segoe UI", 12F);
            lblModulo.Location = new Point(43, 137);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(67, 21);
            lblModulo.TabIndex = 2;
            lblModulo.Text = "Módulo:";
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = Color.FromArgb(0, 0, 192);
            txtUsuario.Location = new Point(192, 37);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(188, 23);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.ForeColor = Color.Black;
            txtContraseña.Location = new Point(192, 86);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '#';
            txtContraseña.Size = new Size(188, 23);
            txtContraseña.TabIndex = 4;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // lstModulo
            // 
            lstModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            lstModulo.Enabled = false;
            lstModulo.ForeColor = Color.Black;
            lstModulo.FormattingEnabled = true;
            lstModulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            lstModulo.Location = new Point(192, 135);
            lstModulo.Name = "lstModulo";
            lstModulo.Size = new Size(188, 23);
            lstModulo.TabIndex = 5;
            lstModulo.SelectedIndexChanged += lstModulo_SelectedIndexChanged_1;
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Location = new Point(429, 63);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(429, 112);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 208);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lstModulo);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuarioo);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuarioo;
        private Label lblContraseña;
        private Label lblModulo;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private ComboBox lstModulo;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}