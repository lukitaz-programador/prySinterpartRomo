using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySinterpartRomo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        int intentos = 0;

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtContraseña.Enabled = false;
                txtContraseña.Text = "";
            }
            else
            {
                txtContraseña.Enabled = true;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                lstModulo.Enabled = false;
                lstModulo.SelectedIndex = -1;
            }
            else
            {
                lstModulo.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            lstModulo.SelectedIndex = -1;
        }

        private void lstModulo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstModulo.SelectedIndex == -1)
            {
                btnAceptar.Enabled = false;
            }
            else
            {
                btnAceptar.Enabled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool Acceso = false;

            if (intentos == 2)
            {
                this.Close();
            }

            switch (txtUsuario.Text)
            {
                case "Adm":
                    if (lstModulo.Text=="ADM" || lstModulo.Text == "COM" || lstModulo.Text == "VTA")
                    {
                        if (txtContraseña.Text=="@1a")
                        {
                            Acceso = true;
                        }
                        else
                        {
                            intentos++;
                            MessageBox.Show("Contraseña inválida");
                            
                        }
                    }
                    else
                    {
                        intentos++;
                        MessageBox.Show("Módulo inválido");
                        
                    }
                        break;

                case "John":
                    if (lstModulo.Text == "SIST")
                    {
                        if (txtContraseña.Text == "*2b")
                        {
                            Acceso = true;
                        }
                        else
                        {
                            intentos++;
                            MessageBox.Show("Contraseña inválida");
                            
                        }
                    }
                    else
                    {
                        intentos++;
                        MessageBox.Show("Módulo inválido");
                        
                    }
                    break;

                case "Ceci":
                    if (lstModulo.Text == "ADM" || lstModulo.Text=="VTA")
                    {
                        if (txtContraseña.Text == "*@3c")
                        {
                            Acceso = true;
                        }
                        else
                        {
                            intentos++;
                            MessageBox.Show("Contraseña inválida");
                            
                        }
                    }
                    else
                    {
                        intentos++;
                        MessageBox.Show("Módulo inválido");
                        
                    }
                    break;

                case "God":
                        if (txtContraseña.Text == "*@#4d")
                        {
                            Acceso = true;
                        }
                        else
                        {
                            intentos++;
                            MessageBox.Show("Contraseña inválida");
                            
                        }
                    break;
            }

            if (Acceso)
            {
                frmBienvenida frmBienvenida = new frmBienvenida();
                Hide();
                frmBienvenida.ShowDialog();
                Show();
            }
        }
    }
}


