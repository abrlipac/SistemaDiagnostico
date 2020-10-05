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
    public partial class FrmPaciente : Form
    {

        public FrmPaciente()
        {
            InitializeComponent();
        }

        //MetodoLimpiar
        private void Limpiar()
        {
            txtDNI.Text = "";
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCelular.Clear();
            txtEstado.Clear();
            errorAlerta.Clear();
            rdbFemenino.Checked = false;
            rdbMasculino.Checked = false;
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

        //Metodo Listar
        private void Listar()
        {
            try
            {
                dgvGrilla.DataSource = PacienteNegocio.Listar();
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

        //Metodo void Formatear
        private void Formatear()
        {
            dgvGrilla.Columns[0].Visible = false;//columna seleccionar
            dgvGrilla.Columns[1].Width = 80; //Dni
            dgvGrilla.Columns[2].Width = 100; //Nombre
            dgvGrilla.Columns[3].Width = 200; //Apellido
            dgvGrilla.Columns[4].Width = 80; //Sexo
            dgvGrilla.Columns[5].Width = 100; //Direccion
            dgvGrilla.Columns[6].Width = 80; //Celular
            dgvGrilla.Columns[7].Width = 80; //Estado

            dgvGrilla.Columns[1].HeaderText = "Dni";
            dgvGrilla.Columns[2].HeaderText = "Nombre";
            dgvGrilla.Columns[3].HeaderText = "Apellido";
            dgvGrilla.Columns[4].HeaderText = "Sexo";
            dgvGrilla.Columns[5].HeaderText = "Direccion";
            dgvGrilla.Columns[6].HeaderText = "Celular";
            dgvGrilla.Columns[7].HeaderText = "Estado";
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
                dgvGrilla.DataSource = PacienteNegocio.Buscar(Buscar);
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



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Esta seguro de eliminar el registro(s) seleccionado(s)?", "Eliminar Registro(s)",
                                           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string dni;
                    string Rpta = "";
                    foreach (DataGridViewRow row in dgvGrilla.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            dni = Convert.ToString(row.Cells[1].Value);
                            Rpta = PacienteNegocio.Eliminar(dni);

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
                string sexo = "";

                this.Limpiar();
                this.Visualizar();
                btnActualizar.Visible = true;
                btnInsertar.Visible = false;
                //Campos de la tabla de la BD
                txtDNI.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["dni"].Value);
                txtNombre.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["nombre"].Value);
                txtApellido.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["apellido"].Value);
                sexo = Convert.ToString(dgvGrilla.CurrentRow.Cells["sexo"].Value);
                if (sexo.Equals("M"))
                {
                    rdbMasculino.Checked = true;
                }
                else
                {
                    rdbFemenino.Checked = true;
                }
                txtDireccion.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["direccion"].Value);
                txtCelular.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["celular"].Value);
                txtEstado.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["estado"].Value);
                tabPaciente.SelectedIndex = 1; //Tab Mantenimiento
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar el campo nombre...");
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string sexo = "";
                string Rpta = "";

                if (txtDNI.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos en algunos campos");
                    errorAlerta.SetError(txtDNI, "Ingrese Dni"); //Error provider
                }
                else
                {

                    if (rdbMasculino.Checked==true)
                    {
                        sexo = "M";
                    }else if (rdbFemenino.Checked==true) {
                        sexo = "F";
                    }

                    Rpta = PacienteNegocio.Insertar(txtDNI.Text.Trim(), txtNombre.Text.Trim(), txtApellido.Text.Trim(), sexo,(txtDireccion.Text.Trim()),
                                                    txtCelular.Text.Trim(), txtEstado.Text.Trim());
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string sexo = "";
                string Rpta = "";


                if (txtNombre.Text == string.Empty || txtDNI.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos en algunos campos");
                    errorAlerta.SetError(txtNombre, "Ingrese paciente"); //Error provider
                }
                else
                {
                    if (rdbMasculino.Checked == true)
                    {
                        sexo = "M";
                    }
                    else if (rdbFemenino.Checked == true)
                    {
                        sexo = "F";
                    }

                    Rpta = PacienteNegocio.Actualizar(txtDNI.Text.Trim(),
                                                     txtNombre.Text.Trim(), txtApellido.Text.Trim(),sexo, txtDireccion.Text.Trim(),
                                                     txtCelular.Text.Trim(), txtEstado.Text.Trim());
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
            tabPaciente.SelectedIndex = 0; //Listado 0 - Formulario mantenimiento 1
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            Listar();
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
                            Rpta = PacienteNegocio.Activar(codigo);

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
                            Rpta = PacienteNegocio.Desactivar(codigo);

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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
