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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        //Metodo Limpiar
        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtUsuario.Clear();
            txtDni.Clear();
            txtClave.Clear();
            txtEstado.Clear();
            //errorAlerta.Clear();

        }

        //Metodo void Visualizar
        private void Visualizar()
        {
            btnInsertar.Visible = true;
            btnActualizar.Visible = true;
            btnEliminar.Visible = false;
            btnActivar.Visible = false;
            btnDesactivar.Visible = false;
            dgvGrilla.Columns[0].Visible = false;
        }

        //Metodo void Formatear
        private void Formatear()
        {
            dgvGrilla.Columns[0].Visible = false;//columna seleccionar
            dgvGrilla.Columns[1].Width = 80; //Codigo
            dgvGrilla.Columns[2].Width = 100; //Dni
            dgvGrilla.Columns[3].Width = 200; //Apellido
            dgvGrilla.Columns[4].Width = 80; //Sexo
            dgvGrilla.Columns[5].Width = 100; //Direccion


            dgvGrilla.Columns[1].HeaderText = "Codigo";
            dgvGrilla.Columns[2].HeaderText = "Dni";
            dgvGrilla.Columns[3].HeaderText = "Usuario";
            dgvGrilla.Columns[4].HeaderText = "Clave";
            dgvGrilla.Columns[5].HeaderText = "Estado";

        }

        //Metodo Listar
        private void Listar()
        {
            try
            {
                // dgvGrilla.DataSource = UsuarioNegocio.Listar();
                this.Formatear();
                this.Limpiar();
                this.Visualizar();
                lblCantidad.Text = "Total de registros: " + Convert.ToString(dgvGrilla.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Metodo Mensaje Correcto
        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Diagnostico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metodo Mensaje Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Diagnostico", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Metodo Buscar
        private void Buscar()
        {
            try
            {
                string Buscar;
                Buscar = txtBuscar.Text;
                // dgvGrilla.DataSource = UsuarioNegocio.Buscar(Buscar);
                this.Formatear();
                lblCantidad.Text = "Total de registros: " + Convert.ToString(dgvGrilla.Rows.Count);

                if (dgvGrilla.Rows.Count < 1)
                {
                    MessageBox.Show("No hay resultados en la búsqueda");
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {

                string Rpta = "";

                if (txtDni.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos en algunos campos");
                    errorAlerta.SetError(txtDni, "Ingrese Dni"); //Error provider
                }
                else if (txtUsuario.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos en algunos campos");
                    errorAlerta.SetError(txtUsuario, "Ingrese Usuario"); //Error provider
                }
                else if (txtClave.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos en algunos campos");
                    errorAlerta.SetError(txtClave, "Ingrese Clave"); //Error provider
                }
                else if (txtEstado.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos en algunos campos");
                    errorAlerta.SetError(txtEstado, "Ingrese Estado"); //Error provider
                }
                else
                {

                    // Rpta = UsuarioNegocio.Insertar(txtDni.Text.Trim(), txtUsuario.Text.Trim(), txtClave.Text.Trim(), txtEstado.Text.Trim());
                    if (Rpta.Equals("Correcto"))
                    {
                        this.MensajeCorrecto("Se grabo el registro en la BD correctamente...");
                        this.Limpiar();
                        this.Visualizar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Listar();
            txtCodigo.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Esta seguro de eliminar el registro(s) seleccionado(s)?", "Eliminar Registro(s)",
                                           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int id;
                    string Rpta = "";
                    foreach (DataGridViewRow row in dgvGrilla.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            id = Convert.ToInt32(row.Cells[1].Value);
                            // Rpta = UsuarioNegocio.Eliminar(id);

                            if (Rpta == "Correcto")
                            {
                                this.MensajeCorrecto("Se elimino el los registro(s) correctamente..." +
                                    Convert.ToString(row.Cells[1].Value));
                                chkbSeleccionar.Checked = false;
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }

                    chkbSeleccionar.Checked = false;
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void chkbSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbSeleccionar.Checked)
            {
                dgvGrilla.Columns[0].Visible = true; //columna seleccionar
                btnActivar.Visible = true;
                btnDesactivar.Visible = true;
                btnEliminar.Visible = true;
            }
            else
            {
                dgvGrilla.Columns[0].Visible = false; //columna seleccionar
                btnActivar.Visible = false;
                btnDesactivar.Visible = false;
                btnEliminar.Visible = false;
            }
        }

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvGrilla.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkbEliminar = (DataGridViewCheckBoxCell)dgvGrilla.Rows[e.RowIndex].Cells["Seleccionar"];
                chkbEliminar.Value = !Convert.ToBoolean(chkbEliminar.Value);
            }
        }

        private void dgvGrilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                this.Limpiar();
                this.Visualizar();
                btnActualizar.Visible = true;
                btnInsertar.Visible = false;
                //Campos de la tabla de la BD
                txtCodigo.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["usuario_id"].Value);
                txtDni.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["dniEmpleado"].Value);
                txtUsuario.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["usuario"].Value);
                txtClave.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["clave"].Value);
                txtEstado.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["estado"].Value);
                tabUsuario.SelectedIndex = 1; //Tab Mantenimiento
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar el campo nombre...");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                string Rpta = "";


                if (txtCodigo.Text == string.Empty || txtDni.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos en algunos campos");
                    errorAlerta.SetError(txtDni, "Ingrese paciente"); //Error provider
                }
                else
                {

                    // Rpta = UsuarioNegocio.Actualizar(Convert.ToInt32(txtCodigo.Text.Trim()), txtDni.Text.Trim(), txtUsuario.Text.Trim(), txtClave.Text.Trim(), txtEstado.Text.Trim());
                    if (Rpta.Equals("Correcto"))
                    {
                        this.MensajeCorrecto("Se actualizo el registro en la BD correctamente...");
                        this.Limpiar();
                        this.Visualizar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Limpiar();
            this.Visualizar();
            tabUsuario.SelectedIndex = 0; //Listado 0 - Formulario mantenimiento 1
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Está seguro de Activar el(los) registro(s) seleccionado(s)?",
                    "Activar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in dgvGrilla.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            // Rpta = UsuarioNegocio.Activar(codigo);

                            if (Rpta == "Correcto")
                            {
                                this.MensajeCorrecto("Se activo el(los) registro(s) correctamente "
                                    + Convert.ToString(row.Cells[1].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    chkbSeleccionar.Checked = false;
                    this.Listar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Está seguro de desactivar el(los) registro(s) seleccionado(s)?",
                    "Desactivar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in dgvGrilla.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            // Rpta = UsuarioNegocio.Desactivar(codigo);

                            if (Rpta == "Correcto")
                            {
                                this.MensajeCorrecto("Se desactivo el(los) registro(s) correctamente "
                                    + Convert.ToString(row.Cells[1].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    chkbSeleccionar.Checked = false;
                    this.Listar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
