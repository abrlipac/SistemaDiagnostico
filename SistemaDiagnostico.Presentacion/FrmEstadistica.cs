using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;
using SistemaDiagnostico.Negocio;



namespace SistemaDiagnostico.Presentacion
{
    public partial class FrmEstadistica : Form
    {
        public FrmEstadistica()
        {
            InitializeComponent();
        }

        private void FrmEstadistica_Load(object sender, EventArgs e)
        {
            DataTable Tabla = new DataTable();
            DataTable Tabla2 = new DataTable();
            DataTable Tabla3 = new DataTable();
            DataTable Tabla4 = new DataTable();
            DataTable Tabla5 = new DataTable();
            DataTable Tabla6 = new DataTable();
            DataTable Tabla7 = new DataTable();

            Tabla = DiagnosticoNegocio.GrafEnfermedades();
            Tabla2 = DiagnosticoNegocio.GrafEnfermedades2();
            Tabla3 = DiagnosticoNegocio.GrafEnfermedades3();
            Tabla4 = DiagnosticoNegocio.GrafEnfermedades4();
            Tabla5 = DiagnosticoNegocio.GrafEnfermedades5();
            Tabla6 = DiagnosticoNegocio.GrafEnfermedades6();
            Tabla7 = DiagnosticoNegocio.GrafEnfermedades7();

            int dato = Convert.ToInt32(Tabla.Rows[0][0]);
            int dato2 = Convert.ToInt32(Tabla2.Rows[0][0]);
            int dato3 = Convert.ToInt32(Tabla3.Rows[0][0]);
            int dato4 = Convert.ToInt32(Tabla4.Rows[0][0]);
            int dato5 = Convert.ToInt32(Tabla5.Rows[0][0]);
            int dato6 = Convert.ToInt32(Tabla6.Rows[0][0]);
            int dato7 = Convert.ToInt32(Tabla7.Rows[0][0]);

            Title titulo = new Title("Estadistica de las enfermedades");
            chart1.Titles.Add(titulo);

            Series serie = chart1.Series.Add("anemia");
            serie.Label = dato.ToString();
            serie.Points.Add(dato);

            Series serie2 = chart1.Series.Add("gripe");
            serie2.Label = dato2.ToString();
            serie2.Points.Add(dato2);

            Series serie3 = chart1.Series.Add("A-H1N1");
            serie3.Label = dato3.ToString();
            serie3.Points.Add(dato3);

            Series serie4 = chart1.Series.Add("rubeola");
            serie4.Label = dato4.ToString();
            serie4.Points.Add(dato4);

            Series serie5 = chart1.Series.Add("dengue");
            serie5.Label = dato5.ToString();
            serie5.Points.Add(dato5);

            Series serie6 = chart1.Series.Add("neumonia");
            serie6.Label = dato6.ToString();
            serie6.Points.Add(dato6);

            Series serie7 = chart1.Series.Add("covid-19");
            serie7.Label = dato7.ToString();
            serie7.Points.Add(dato7);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
