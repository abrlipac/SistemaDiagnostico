using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.Entidad
{
    public class DetalleDiagnosticoEntidad
    {
        /// <summary>
        /// Representa el identificador del detalle de Diagnostico
        /// </summary>
        public int DiagnosticoId { get; private set; }
        /// <summary>
        /// Representa la descripcion del detalle de Diagnostico
        /// </summary>
        public string Sintoma { get; private set; }

    }
}
