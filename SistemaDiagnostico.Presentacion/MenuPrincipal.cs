using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDiagnostico.Negocio;

namespace SistemaDiagnostico.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        private FrmEmpleado ForEmpleado;
        private FrmPaciente ForPaciente;
        private FrmDiagnostico ForDiagnostico;
        private FrmUsuario ForUsuario;
        private FrmEstadistica forEstadistica;


        public string Apellido;
        public string Nombre;
        public string Cargo;
        public string DNI;



        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = "Bienvenido : " + Nombre + ", " + Apellido +
                                " - Cargo: [ " + Cargo + " ]";


            if (this.Cargo.Equals("Administrador"))
            {
                usuarioToolStripMenuItem.Enabled = true;
                empleadoToolStripMenuItem.Enabled = true;
                pacienteToolStripMenuItem.Enabled = true;
                diagnosticoToolStripMenuItem.Enabled = true;
               
            }
            else
            {
                usuarioToolStripMenuItem.Enabled = false;
                toolUsuario.Enabled = false;
                empleadoToolStripMenuItem.Enabled = false;
                toolEmpleado.Enabled = false;
                pacienteToolStripMenuItem.Enabled = true;
                diagnosticoToolStripMenuItem.Enabled = true;
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ForUsuario == null)
            {
                ForUsuario = new FrmUsuario();
                ForUsuario.MdiParent = this;
                ForUsuario.FormClosed += new FormClosedEventHandler(CerrarForma4);
                ForUsuario.Show();
            }
            else
            {
                ForUsuario.Activate();
            }
        }

        void CerrarForma(object sender, FormClosedEventArgs e)
        {
            ForPaciente = null;
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ForPaciente == null)
            {
                ForPaciente = new FrmPaciente();
                ForPaciente.MdiParent = this;
                ForPaciente.FormClosed += new FormClosedEventHandler(CerrarForma);
                ForPaciente.Show();
            }
            else
            {
                ForPaciente.Activate();
            }
        }

        void CerrarForma2(object sender, FormClosedEventArgs e)
        {
            ForDiagnostico = null;
        }

        private void diagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ForDiagnostico == null)
            {
                DataTable Tabla = new DataTable();
                Tabla = UsuarioNegocio.LoginVerificar(DNI);

                ForDiagnostico = new FrmDiagnostico();
                ForDiagnostico.MdiParent = this;
                ForDiagnostico.EmpleadoDni = Convert.ToString(Tabla.Rows[0][0]);
                ForDiagnostico.FormClosed += new FormClosedEventHandler(CerrarForma2);
                ForDiagnostico.Show();
            }
            else
            {
                ForDiagnostico.Activate();
            }
        }

        void CerrarForma3(object sender, FormClosedEventArgs e)
        {
            ForEmpleado = null;
        }
        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ForEmpleado == null)
            {
                ForEmpleado = new FrmEmpleado();
                ForEmpleado.MdiParent = this;
                ForEmpleado.FormClosed += new FormClosedEventHandler(CerrarForma3);
                ForEmpleado.Show();
            }
            else
            {
                ForEmpleado.Activate();
            }
        }


        void CerrarForma4(object sender, FormClosedEventArgs e)
        {
            ForUsuario = null;
        }

        private void toolUsuario_Click(object sender, EventArgs e)
        {
            if (ForUsuario == null)
            {
                ForUsuario = new FrmUsuario();
                ForUsuario.MdiParent = this;
                ForUsuario.FormClosed += new FormClosedEventHandler(CerrarForma4);
                ForUsuario.Show();
            }
            else
            {
                ForUsuario.Activate();
            }
        }

        private void toolEmpleado_Click(object sender, EventArgs e)
        {
            if (ForEmpleado == null)
            {
                ForEmpleado = new FrmEmpleado();
                ForEmpleado.MdiParent = this;
                ForEmpleado.FormClosed += new FormClosedEventHandler(CerrarForma3);
                ForEmpleado.Show();
            }
            else
            {
                ForEmpleado.Activate();
            }
        }

        private void toolPaciente_Click(object sender, EventArgs e)
        {
            if (ForPaciente == null)
            {
                ForPaciente = new FrmPaciente();
                ForPaciente.MdiParent = this;
                ForPaciente.FormClosed += new FormClosedEventHandler(CerrarForma);
                ForPaciente.Show();
            }
            else
            {
                ForPaciente.Activate();
            }
        }

        private void toolDiagnostico_Click(object sender, EventArgs e)
        {

            if (ForDiagnostico == null)
            {
                DataTable Tabla = new DataTable();
                Tabla = UsuarioNegocio.LoginVerificar(DNI);

                ForDiagnostico = new FrmDiagnostico();
                ForDiagnostico.MdiParent = this;
                ForDiagnostico.EmpleadoDni = Convert.ToString(Tabla.Rows[0][0]);
                ForDiagnostico.FormClosed += new FormClosedEventHandler(CerrarForma2);
                ForDiagnostico.Show();

            }
            else
            {
                ForDiagnostico.Activate();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Esta seguro que desea salir?",
                "Cerrar Sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                this.Close();
                FrmLogin Frm = new FrmLogin();
                Frm.Show();
            }
        }

        void CerrarForma5(object sender, FormClosedEventArgs e)
        {
            forEstadistica = null;
        }

        private void toolEstadistica_Click(object sender, EventArgs e)
        {
            if (forEstadistica == null)
            {
                forEstadistica = new FrmEstadistica();
                forEstadistica.MdiParent = this;
                forEstadistica.FormClosed += new FormClosedEventHandler(CerrarForma5);
                forEstadistica.Show();
            }
            else
            {
                forEstadistica.Activate();
            }
        }
    }
}
