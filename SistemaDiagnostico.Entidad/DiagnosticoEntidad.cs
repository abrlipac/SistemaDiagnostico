using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.Entidad
{
    public class DiagnosticoEntidad
    {

        public int numeroDiagnostico { get; private set; }
        public  Empleado empleado{ get; private set; }
     

        public string Fecha { get; set; }
        public string Enfermedad { get; set; }

    }
}
