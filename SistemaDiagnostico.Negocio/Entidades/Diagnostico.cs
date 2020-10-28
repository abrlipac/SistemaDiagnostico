using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.Entidad
{
    public class Diagnostico
    {
        public int Id { get; private set; }
        public Empleado Empleado { get; private set; }
        [ForeignKey("Empleado")]
        public int Empleado_Id { get; private set; }
        public Paciente Paciente { get; private set; }
        [ForeignKey("Paciente")]
        public int Paciente_Id { get; private set; }
        public DateTime Fecha { get; private set; }
        public string Enfermedad { get; private set; }
        public ICollection<DetalleDiagnostico> Detalles { get; private set; }

        public static Diagnostico Agregar(Empleado _empleado, Paciente _paciente, string _enfermedad)
        {
            return new Diagnostico()
            {
                Empleado = _empleado,
                Empleado_Id = _empleado.Id,
                Paciente = _paciente,
                Paciente_Id = _paciente.Id,
                Fecha = DateTime.Now,
                Enfermedad = _enfermedad
            };
        }

        public Diagnostico()
        {
            Detalles = new List<DetalleDiagnostico>();
        }

    }
}
