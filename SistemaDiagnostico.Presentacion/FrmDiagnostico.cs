using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using SbsSW.SwiPlCs;
using SistemaDiagnostico.PruebasUnitarias;

namespace SistemaDiagnostico.Presentacion
{
    public partial class FrmDiagnostico : Form
    {
        public FrmDiagnostico()
        {
            InitializeComponent();
        }

        public List<string> listasintomas = new List<string>();
        public string EmpleadoDni;
        string time;
        public string enfer1 = "", enfer2 = "", enfer3 = "", enfer4 = "", enfer5 = "", enfer6 = "", enfer7 = "";
        public string diagnostico;
        private void Limpiar()
        {
            txtCodigo.Clear();
            lstDiagnostico.Items.Clear();
            txtdni.Clear();
            txtNombre.Clear();
            chkcansancio.Checked=false;
            chkcongestionnasal.Checked = false;
            chkdificultadrespirar.Checked = false;
            chkdolorarticulaciones.Checked = false;
            chkdolorcabeza.Checked = false;
            chkdolorgarganta.Checked = false;
            chkdolormuscular.Checked = false;
            chkdolorpecho.Checked = false;
            chkerupcionespiel.Checked = false;
            chkescalofrios.Checked = false;
            chkfiebre.Checked = false;
            chkfiebreyescalofrios.Checked = false;
            chknauseas.Checked = false;
            chkojosrojos.Checked = false;
            chkperdidaapetito.Checked = false;
            chkperdidagustoolfato.Checked = false;
            chkTos.Checked = false;
            chktosconstante.Checked = false;
            chktosseca.Checked = false;
            chkvomito.Checked = false;


        }
        //metodo visualizar
        private void Visualizar()
        {
            btnInsertar.Visible = true;
            btnEliminar.Visible = false;
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
                // TODO: Listar
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

        private void Formatear()
        {
            dgvGrilla.Columns[0].Visible = false; //columna seleccionar
            dgvGrilla.Columns[1].Width = 80; //Id
            dgvGrilla.Columns[2].Width = 100; //Cargo
            dgvGrilla.Columns[3].Width = 200; //Apellido
            dgvGrilla.Columns[4].Width = 200; //Nombre
            dgvGrilla.Columns[5].Width = 100; //Dni
            dgvGrilla.Columns[6].Width = 200; //Apellido
            dgvGrilla.Columns[7].Width = 200; //Nombre
            dgvGrilla.Columns[8].Width = 200; //Fecha


            dgvGrilla.Columns[1].HeaderText = "Nro";
            dgvGrilla.Columns[2].HeaderText = "Cargo";
            dgvGrilla.Columns[3].HeaderText = "Apellido";
            dgvGrilla.Columns[4].HeaderText = "Nombre";
            dgvGrilla.Columns[5].HeaderText = "Dni";
            dgvGrilla.Columns[6].HeaderText = "Apellido";
            dgvGrilla.Columns[7].HeaderText = "Nombre";
            dgvGrilla.Columns[8].HeaderText = "Fecha";


        }

        private void Buscar()
        {
            try
            {
                string buscar = "";
                buscar = txtBuscar.Text;
                
                // TODO: Buscar

                this.Formatear();
                lblCantidad.Text = "Total de Registros: " + Convert.ToString(dgvGrilla.Rows.Count);

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

        private void BuscarPD()
        {
            
            try
            {
                string busqueda;
                DataTable Tabla = new DataTable();
                busqueda = txtdni.Text;

                // TODO: Buscar

                if (Tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("El dni que ingresó no existe", "Acceso al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtNombre.Text = Convert.ToString(Tabla.Rows[0][1]) + " " + Convert.ToString(Tabla.Rows[0][2]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }



        private void FrmDiagnostico_Load(object sender, EventArgs e)
        {

            DateTime today = DateTime.Today;
            time = today.GetDateTimeFormats('d')[0];
            lblfecha.Text = time;

            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\\bin");
            string[] p = { "-q", "-f", @"enfermedad.pl" };

            PlEngine.Initialize(p);
            
            this.Listar();

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
                    int nro;
                    string Rpta = "", Rpta2 = "", Rpta3 = "";
                    foreach (DataGridViewRow row in dgvGrilla.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            nro = Convert.ToInt32(row.Cells[1].Value);

                            // TODO: Eliminar
                            // Rpta2 = DetalleDiagnosticoNegocio.Eliminar(nro);
                            // Rpta3 = EnfermedadPosibleNegocio.Eliminar(nro);
                            // Rpta = DiagnosticoNegocio.Eliminar(nro);

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

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvGrilla.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvGrilla.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
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

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            this.BuscarPD();
        }

        private void btnDiagnosticar_Click(object sender, EventArgs e)
        {
            double porcentaje1 = 0;
            double porcentaje2 = 0;
            double porcentaje3 = 0;
            double porcentaje4 = 0;
            double porcentaje5 = 0;
            double porcentaje6 = 0;
            double porcentaje7 = 0;


            List<string> listaenfermedad = new List<string>();


            lstDiagnostico.Items.Clear();

            if (chkTos.Checked == true)
            {
                listasintomas.Add("tos");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "tos" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    listaenfermedad.Add(z["Z"].ToString());
                    
            }

            if (chkdolorgarganta.Checked == true)
            {
                listasintomas.Add("dolorgarganta");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "dolorgarganta" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    listaenfermedad.Add(z["Z"].ToString());

            }

            if (chkdolorcabeza.Checked == true)
            {
                listasintomas.Add("dolorcabeza");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "dolorcabeza" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                {
                    listaenfermedad.Add(z["Z"].ToString());
                }
            }


            if (chkcongestionnasal.Checked == true)
            {
                listasintomas.Add("congestionnasal");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "congestionnasal" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    listaenfermedad.Add(z["Z"].ToString());

            }

            if (chkfiebre.Checked == true)
            {
                listasintomas.Add("fiebre");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "fiebre" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    listaenfermedad.Add(z["Z"].ToString());

            }

            if (chkdolormuscular.Checked == true)
            {
                listasintomas.Add("dolormuscular");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "dolormuscular" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                {
                    listaenfermedad.Add(z["Z"].ToString());
                }
            }


            if (chkfiebreyescalofrios.Checked == true)
            {
                listasintomas.Add("fiebreescalofrios");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "fiebreescalofrios" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                {
                    listaenfermedad.Add(z["Z"].ToString());
                }
            }

            if (chkmalestargeneral.Checked == true)
            {
                listasintomas.Add("malestargeneral");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "malestargeneral" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    listaenfermedad.Add(z["Z"].ToString());

            }

            if (chkperdidaapetito.Checked == true)
            {
                listasintomas.Add("perdidaapetito");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "perdidaapetito" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    listaenfermedad.Add(z["Z"].ToString());

            }

            if (chknauseas.Checked == true)
            {
                listasintomas.Add("nauseas");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "nauseas" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    listaenfermedad.Add(z["Z"].ToString());

            }

            if (chkvomito.Checked == true)
            {
                listasintomas.Add("vomito");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "vomito" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                {
                    listaenfermedad.Add(z["Z"].ToString());
                }
            }

            if (chkcansancio.Checked == true)
            {
                listasintomas.Add("cansancio");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "cansancio" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                {
                    listaenfermedad.Add(z["Z"].ToString());
                }
            }

            if (chkdificultadrespirar.Checked == true)
            {
                listasintomas.Add("dificultadrespirar");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "dificultadrespirar" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    listaenfermedad.Add(z["Z"].ToString());

            }

            if (chkescalofrios.Checked == true)
            {
                listasintomas.Add("escalofrios");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "escalofrios" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    listaenfermedad.Add(z["Z"].ToString());

            }

            if (chktosseca.Checked == true)
            {
                listasintomas.Add("tosseca");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "tosseca" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    listaenfermedad.Add(z["Z"].ToString());

            }

            if (chkojosrojos.Checked == true)
            {
                listasintomas.Add("ojosrojos");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "ojosrojos" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    listaenfermedad.Add(z["Z"].ToString());

            }

            if (chkerupcionespiel.Checked == true)
            {
                listasintomas.Add("erupcionespiel");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "erupcionespiel" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    listaenfermedad.Add(z["Z"].ToString());

            }

            if (chkdolorarticulaciones.Checked == true)
            {
                listasintomas.Add("dolorarticulacion");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "dolorarticulacion" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    listaenfermedad.Add(z["Z"].ToString());

            }

            if (chkdolorpecho.Checked == true)
            {
                listasintomas.Add("dolorpecho");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "dolorpecho" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    listaenfermedad.Add(z["Z"].ToString());

            }

            if (chktosconstante.Checked == true)
            {
                listasintomas.Add("tosconstante");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "tosconstante" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    listaenfermedad.Add(z["Z"].ToString());

            }

            if (chkperdidagustoolfato.Checked == true)
            {
                listasintomas.Add("perdidagustoolfato");
                PlQuery consulta1 = new PlQuery("enfermedadde(Z," + "perdidagustoolfato" + ")");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    listaenfermedad.Add(z["Z"].ToString());

            }

            var result = from item in listaenfermedad.Cast<string>()
                         group item by item into g
                         select new
                         {
                             enfermedad = g.Key,
                             cantidad = g.Count()
                         };


            foreach (var item in result)
            {

                if (item.enfermedad == "gripe")
                {
                    porcentaje1 = (item.cantidad * 100) / 5;                    
                    lstDiagnostico.Items.Add(item.enfermedad + " " + porcentaje1 + "%");
                    enfer1 = item.enfermedad;
                }
                else if (item.enfermedad == "gripeA")
                {
                    porcentaje2 = (Convert.ToDouble(item.cantidad) * Convert.ToDouble(100));
                    porcentaje2 = Math.Round(porcentaje2 / Convert.ToDouble(6), 2);
                    lstDiagnostico.Items.Add("A-H1N1" + " " + porcentaje2 + "%");
                    enfer2 = "A-H1N1";

                }
                else if (item.enfermedad == "anemia")
                {
                    porcentaje3 = (item.cantidad * 100) / 5;
                    lstDiagnostico.Items.Add(item.enfermedad + " " + porcentaje3 + "%");
                    enfer3 = item.enfermedad;
                }
                else if (item.enfermedad == "rubeola")
                {

                    porcentaje4 = (Convert.ToDouble(item.cantidad) * Convert.ToDouble(100));
                    porcentaje4 = Math.Round(porcentaje4 / Convert.ToDouble(4), 2);
                    lstDiagnostico.Items.Add(item.enfermedad + " " + porcentaje4 + "%");
                    enfer4 = item.enfermedad;
                }
                else if (item.enfermedad == "dengue")
                {
                    porcentaje5 = (item.cantidad * 100) / 5;
                    lstDiagnostico.Items.Add(item.enfermedad + " " + porcentaje5 + "%");
                    enfer5 = item.enfermedad;
                }
                else if (item.enfermedad == "neumonia")
                {
                    porcentaje6 = (Convert.ToDouble(item.cantidad) * Convert.ToDouble(100));
                    porcentaje6 = Math.Round(porcentaje6 / Convert.ToDouble(4), 2);
                    lstDiagnostico.Items.Add(item.enfermedad + " " + porcentaje6 + "%");
                    enfer6 = item.enfermedad;
                }
                else if (item.enfermedad == "covid")
                {
                    porcentaje7 = (Convert.ToDouble(item.cantidad) * Convert.ToDouble(100));
                    porcentaje7 = Math.Round(porcentaje7 / Convert.ToDouble(7), 2);
                    lstDiagnostico.Items.Add("covid-19" + " " + porcentaje7 + "%");
                    enfer7 = "covid-19";
                }


            }


            if (porcentaje1>porcentaje2 && porcentaje1>porcentaje3 && porcentaje1>porcentaje4 
                && porcentaje1>porcentaje5 && porcentaje1 > porcentaje6  && porcentaje1 > porcentaje7)
            {
                diagnostico = enfer1;
            }
            else if (porcentaje2 > porcentaje1 && porcentaje2 > porcentaje3 && porcentaje2 > porcentaje4
                && porcentaje2 > porcentaje5 && porcentaje2 > porcentaje6 && porcentaje2 > porcentaje7)
            {
                diagnostico = enfer2;
            }
            else if(porcentaje3 > porcentaje1 && porcentaje3 > porcentaje2 && porcentaje3 > porcentaje4
                && porcentaje3 > porcentaje5 && porcentaje3 > porcentaje6 && porcentaje3 > porcentaje7)
            {
                diagnostico = enfer3;
            }
            else if(porcentaje4 > porcentaje1 && porcentaje4 > porcentaje2 && porcentaje4 > porcentaje3
                && porcentaje4 > porcentaje5 && porcentaje4 > porcentaje6 && porcentaje3 > porcentaje7)
            {
                diagnostico = enfer4;
            }
            else if(porcentaje5 > porcentaje1 && porcentaje5 > porcentaje2 && porcentaje5 > porcentaje3
                && porcentaje5 > porcentaje4 && porcentaje5 > porcentaje6 && porcentaje5 > porcentaje7)
            {
                diagnostico = enfer5;
            }
            else if(porcentaje6 > porcentaje1 && porcentaje6 > porcentaje2 && porcentaje6 > porcentaje3
                && porcentaje6 > porcentaje4 && porcentaje6 > porcentaje5 && porcentaje6 > porcentaje7)
            {
                diagnostico = enfer6;
            }
            else if(porcentaje7 > porcentaje1 && porcentaje7 > porcentaje2 && porcentaje7 > porcentaje3
                && porcentaje7 > porcentaje4 && porcentaje7 > porcentaje5 && porcentaje7 > porcentaje6)
            {
                diagnostico = enfer7;
            }
            else
            {
                diagnostico = "";
            }

                lbldiagnostico.Text = diagnostico;

        }


        private void chkbSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbSeleccionar.Checked == true)
            {
                dgvGrilla.Columns[0].Visible = true; //Columna Seleccionar
                btnEliminar.Visible = true;
               
            }
            else
            {
                dgvGrilla.Columns[0].Visible = false; //Columna Seleccionar
                btnEliminar.Visible = false;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";


                if (txtCodigo.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el codigo del diagnóstico",
                   "Sistema Diagnostico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (lbldiagnostico.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar mas sintomas para saber la enfermdad",
                    "Sistema Diagnostico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // TODO: Agregar
                    // Rpta = DiagnosticoNegocio.Insertar(Convert.ToInt32(txtCodigo.Text),EmpleadoDni, txtdni.Text.Trim(), lblfecha.Text, lbldiagnostico.Text);
                    if (Rpta.Equals("Correcto"))
                    {
                        this.MensajeCorrecto("Se grabo el registro en la BD correctamente...");

                        var result = from item in lstDiagnostico.Items.Cast<string>()
                                     group item by item into g
                                     select new
                                     {
                                         enfermedad = g.Key,
                                     };

                        foreach (var item in result)
                        {
                            // TODO: Agregar
                            // EnfermedadPosibleNegocio.Insertar(Convert.ToInt32(txtCodigo.Text), item.enfermedad);
                        }

                        for (int i = 0; i < listasintomas.Count(); i++)
                        {
                            // TODO: Agregar
                            // DetalleDiagnosticoNegocio.Insertar(Convert.ToInt32(txtCodigo.Text), listasintomas[i]);
                        }

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
            tabGeneral.SelectedIndex = 0; //Listado 0 - Formulario mantenimiento 1
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
