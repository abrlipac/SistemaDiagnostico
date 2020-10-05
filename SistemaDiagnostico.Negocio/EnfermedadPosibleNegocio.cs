using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaDiagnostico.AccesoDatos;
using SistemaDiagnostico.Entidad;

namespace SistemaDiagnostico.Negocio
{
    public class EnfermedadPosibleNegocio
    {

        //Metodo Insertar
        public static string Insertar(int Diagnostico_id, string posEnfermedad)
        {
            EnfermedadPosibleDatos objDetalleDiagnosticoD = new EnfermedadPosibleDatos();

            EnfermedadPosibleEntidad objDetalleDiagnosticoE = new EnfermedadPosibleEntidad();
            objDetalleDiagnosticoE.DiagnosticoId = Diagnostico_id;
            objDetalleDiagnosticoE.PosEnfermedad = posEnfermedad;

            return objDetalleDiagnosticoD.Insertar(objDetalleDiagnosticoE);

        }


        //Metodo Eliminar
        public static string Eliminar(int Id)
        {
            EnfermedadPosibleDatos objDiagnostico = new EnfermedadPosibleDatos();
            return objDiagnostico.Eliminar(Id);
        }


    }
}
