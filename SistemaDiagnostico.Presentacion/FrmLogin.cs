using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDiagnostico.Negocio;

namespace SistemaDiagnostico.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string Usuario, Password;
                Usuario = txtUsuario.Text.Trim();
                Password = txtContraseña.Text.Trim();
                DataTable Tabla = new DataTable();
                Tabla = UsuarioNegocio.Login(Usuario, Password);

                if (Tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("La contraseña y/o usuario es incorrecto", "Acceso al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }         
                else
                {
                    if (Convert.ToString(Tabla.Rows[0][4]) == "I")
                    {
                        MessageBox.Show("El usuario no esta activo...", "Acceso al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MenuPrincipal MDI = new MenuPrincipal();

                        MDI.Apellido = Convert.ToString(Tabla.Rows[0][1]);
                        MDI.Nombre = Convert.ToString(Tabla.Rows[0][2]);
                        MDI.Cargo = Convert.ToString(Tabla.Rows[0][3]);
                        MDI.DNI = Convert.ToString(Tabla.Rows[0][5]);
                        MDI.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
    }
}
