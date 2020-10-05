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
    public partial class FrmEmpleado : Form
    {
        
        public FrmEmpleado()
        {
            InitializeComponent();

        }
        //metodo Limpiar
        private void Limpiar()
        {
         
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCargo.Clear();
            txtDireccion.Clear();
            txtCelular.Clear();
            txtEstado.Clear();
            errorAlerta.Clear();

        }
        //metodo visualizar
        private void Visualizar()
        {
            btnInsertar.Visible = true;
            btnActualizar.Visible = true;
            btnEliminar.Visible = false;
            btnActivar.Visible = false;
            btnDesactivar.Visible = false;
            dgvGrilla.Columns[0].Visible = false;
        }

        //Metodo Mensaje Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Diagnostico", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Metodo Mensaje Correcto
        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Diagnostico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metodo Listar
        private void Listar()
        {
            try
            {
                dgvGrilla.DataSource = EmpleadoNegocio.Listar();
                this.Formatear();
                this.Limpiar();
                this.Visualizar();
                lblCantidad.Text = "Total de Registros: " + Convert.ToString(dgvGrilla.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Metodo Formatear
        private void Formatear()
        {
            dgvGrilla.Columns[0].Visible = false; //columna seleccionar
            dgvGrilla.Columns[1].Width = 80; //Id
            dgvGrilla.Columns[2].Width = 200; //Nombre
            dgvGrilla.Columns[3].Width = 200; //Apellido
            dgvGrilla.Columns[4].Width = 100; //Cargo
            dgvGrilla.Columns[5].Width = 200; //Direccion
            dgvGrilla.Columns[6].Width = 100; //Celular
            dgvGrilla.Columns[7].Width = 50; //Estado

            dgvGrilla.Columns[1].HeaderText = "Dni";
            dgvGrilla.Columns[2].HeaderText = "Nombre";
            dgvGrilla.Columns[3].HeaderText = "Apellido";
            dgvGrilla.Columns[4].HeaderText = "Cargo";
            dgvGrilla.Columns[5].HeaderText = "Direccion";
            dgvGrilla.Columns[6].HeaderText = "Celular";
            dgvGrilla.Columns[7].HeaderText = "Estado";

        }

        //metodo Buscar
        private void Buscar()
        {
            try
            {
                string buscar = "";
                buscar = txtBuscar.Text;
                dgvGrilla.DataSource = EmpleadoNegocio.Buscar(buscar);
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


                if (txtNombre.Text == string.Empty )
                {
                    this.MensajeError("Faltan ingresar algunos datos en los campos....");
                    errorAlerta.SetError(txtNombre, "Ingrese Nombre"); //error provider
                  
                }
                else if (txtApellido.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos en los campos....");
                    errorAlerta.SetError(txtApellido, "Ingrese Apellido");
                }
                else if (txtCargo.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos en los campos....");
                    errorAlerta.SetError(txtCargo, "Ingrese Cargo");
                }
                else if (txtDireccion.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos en los campos....");
                    errorAlerta.SetError(txtDireccion, "Ingrese Cargo");
                }
                else if (txtCelular.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos en los campos....");
                    errorAlerta.SetError(txtCelular, "Ingrese Cargo");
                }
                else if (txtEstado.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos en los campos....");
                    errorAlerta.SetError(txtEstado, "Ingrese Cargo");
                }
                else
                {
                    Rpta = EmpleadoNegocio.Insertar(txtDni.Text.Trim(),txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtCargo.Text.Trim(), txtDireccion.Text.Trim(), txtCelular.Text.Trim(), txtEstado.Text.Trim());
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
                string Rpta = "";
                string nombre = txtNombre.Text;

                if (txtNombre.Text == string.Empty || txtDni.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar algunos datos en los campos....");
                    errorAlerta.SetError(txtNombre, "Ingrese Empleado"); //error provider
                }
                else
                {
                    Rpta = EmpleadoNegocio.Actualizar(txtDni.Text.Trim(), txtNombre.Text.Trim(), txtApellido.Text.Trim(),
                                                      txtCargo.Text.Trim(), txtDireccion.Text.Trim(), txtCelular.Text.Trim(), txtEstado.Text.Trim());
                    if (Rpta.Equals("Correcto"))
                    {
                        this.MensajeCorrecto("Se Actualizo el registro en la BD correctamente.....");
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            this.Listar();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.Visualizar();
            tabGeneral.SelectedIndex = 0; //Listado 0 - formulario Insertar Empleado
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Está seguro de eliminar el(los) registro(s) seleccionado(s)?",
                    "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string dni;
                    string Rpta = "";
                    foreach (DataGridViewRow row in dgvGrilla.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            dni = Convert.ToString(row.Cells[1].Value);
                            Rpta = EmpleadoNegocio.Eliminar(dni);

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

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Está seguro de Activar el(los) registro(s) seleccionado(s)?",
                    "Activar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string dni;
                    string Rpta = "";
                    foreach (DataGridViewRow row in dgvGrilla.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            dni = Convert.ToString(row.Cells[1].Value);
                            Rpta = EmpleadoNegocio.Activar(dni);

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
                    string dni;
                    string Rpta = "";
                    foreach (DataGridViewRow row in dgvGrilla.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            dni = Convert.ToString(row.Cells[1].Value);
                            Rpta = EmpleadoNegocio.Desactivar(dni);

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

        private void chkbSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbSeleccionar.Checked == true)
            {
                dgvGrilla.Columns[0].Visible = true; //Columna Seleccionar
                btnActivar.Visible = true;
                btnEliminar.Visible = true;
                btnDesactivar.Visible = true;
            }
            else
            {
                dgvGrilla.Columns[0].Visible = false; //Columna Seleccionar
                btnActivar.Visible = false;
                btnEliminar.Visible = false;
                btnDesactivar.Visible = false;

            }
        }

        private void dgvGrilla_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvGrilla.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvGrilla.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void dgvGrilla_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                this.Visualizar();
                btnBuscar.Visible = true;
                btnInsertar.Visible = false;
                txtDni.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["dniEmpleado"].Value);
                txtNombre.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["nombre"].Value);
                txtApellido.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["apellido"].Value);
                txtCargo.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["cargo"].Value);
                txtDireccion.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["direccion"].Value);
                txtCelular.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["celular"].Value);
                txtEstado.Text = Convert.ToString(dgvGrilla.CurrentRow.Cells["estado"].Value);

                tabGeneral.SelectedIndex = 1; //Tab Insertar Empleado

            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar el campo nombre...");
            }
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
