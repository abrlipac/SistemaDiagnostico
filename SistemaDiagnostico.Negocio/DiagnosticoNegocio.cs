using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDiagnostico.AccesoDatos;
using SistemaDiagnostico.Entidad;
using System.Data;


namespace SistemaDiagnostico.Negocio
{
    public class DiagnosticoNegocio
    {

        //Metodo Grafico enfermedades
        public static DataTable GrafEnfermedades()
        {
            DiagnosticoDatos objDiagnostico = new DiagnosticoDatos();
            return objDiagnostico.GrafEnfermedades();
        }
        //Metodo Grafico enfermedades
        public static DataTable GrafEnfermedades2()
        {
            DiagnosticoDatos objDiagnostico = new DiagnosticoDatos();
            return objDiagnostico.GrafEnfermedades2();
        }

        //Metodo Grafico enfermedades
        public static DataTable GrafEnfermedades3()
        {
            DiagnosticoDatos objDiagnostico = new DiagnosticoDatos();
            return objDiagnostico.GrafEnfermedades3();
        }
        //Metodo Grafico enfermedades
        public static DataTable GrafEnfermedades4()
        {
            DiagnosticoDatos objDiagnostico = new DiagnosticoDatos();
            return objDiagnostico.GrafEnfermedades4();
        }
        //Metodo Grafico enfermedades
        public static DataTable GrafEnfermedades5()
        {
            DiagnosticoDatos objDiagnostico = new DiagnosticoDatos();
            return objDiagnostico.GrafEnfermedades5();
        }
        //Metodo Grafico enfermedades
        public static DataTable GrafEnfermedades6()
        {
            DiagnosticoDatos objDiagnostico = new DiagnosticoDatos();
            return objDiagnostico.GrafEnfermedades6();
        }
        //Metodo Grafico enfermedades
        public static DataTable GrafEnfermedades7()
        {
            DiagnosticoDatos objDiagnostico = new DiagnosticoDatos();
            return objDiagnostico.GrafEnfermedades7();
        }


        //Metodo Listar
        public static DataTable Listar()
        {
            DiagnosticoDatos objDiagnostico = new DiagnosticoDatos();
            return objDiagnostico.Listar();
        }

        //Metodo Buscar
        public static DataTable Buscar(string Busqueda)
        {
            DiagnosticoDatos objDiagnostico = new DiagnosticoDatos();
            return objDiagnostico.Buscar(Busqueda);
        }


        //Metodo Buscar Paciente-Diagnostico
        public static DataTable BuscarPD(string Busqueda)
        {
            DiagnosticoDatos objDiagnostico = new DiagnosticoDatos();
            return objDiagnostico.BuscarPD(Busqueda);
        }


        //Metodo Eliminar
        public static string Eliminar(int Id)
        {
            DiagnosticoDatos objDiagnostico = new DiagnosticoDatos();
            return objDiagnostico.Eliminar(Id);
        }


        //Metodo Insertar
        public static string Insertar(int Diagnostico_id, string dniEmpleado, string Dni, string Fecha, string Enfermedad)
        {
            DiagnosticoDatos objDiagnosticoD = new DiagnosticoDatos();

            DiagnosticoEntidad objDiagnosticoE = new DiagnosticoEntidad();
            objDiagnosticoE.DiagnosticoId = Diagnostico_id;
            objDiagnosticoE.dniEmpleado = dniEmpleado;
            objDiagnosticoE.Dni = Dni;
            objDiagnosticoE.Fecha = Fecha;
            objDiagnosticoE.Enfermedad = Enfermedad;
            return objDiagnosticoD.Insertar(objDiagnosticoE);
            
        }
    }
}
