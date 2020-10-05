using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaDiagnostico.AccesoDatos;
using SistemaDiagnostico.Entidad;


namespace SistemaDiagnostico.Negocio
{
    public class DetalleDiagnosticoNegocio
    {
        //Metodo Insertar
        public static string Insertar(int Diagnostico_id, string Sintoma)
        {
            DetalleDiagnosticoDatos objDetalleDiagnosticoD = new DetalleDiagnosticoDatos();

            DetalleDiagnosticoEntidad objDetalleDiagnosticoE = new DetalleDiagnosticoEntidad();
            objDetalleDiagnosticoE.DiagnosticoId = Diagnostico_id;
            objDetalleDiagnosticoE.Sintoma = Sintoma;

            return objDetalleDiagnosticoD.Insertar(objDetalleDiagnosticoE);

        }


        //Metodo Eliminar
        public static string Eliminar(int Id)
        {
            DetalleDiagnosticoDatos objDiagnostico = new DetalleDiagnosticoDatos();
            return objDiagnostico.Eliminar(Id);
        }



    }
}
