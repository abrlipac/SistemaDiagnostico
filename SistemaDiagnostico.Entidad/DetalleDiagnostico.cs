using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.Entidad
{
    public class DetalleDiagnostico
    {
        /// <summary>
        /// Representa el identificador del detalle de Diagnostico
        /// </summary>
        public int Id { get; private set; }

        [ForeignKey("Diagnostico")]
        public int Diagnostico_Id { get; private set; }
        public Diagnostico Diagnostico { get; private set; }
        /// <summary>
        /// Representa la descripcion del detalle de Diagnostico
        /// </summary>
        public string Sintoma { get; private set; }

    }
}
