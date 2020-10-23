using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.Entidad
{
    public class Diagnostico
    {
        public int IdDiagnostico { get; private set; }
        public  Empleado Empleado{ get; private set; }
        public int IdEmpleado { get; private set; }
        public Paciente Paciente { get; private set; }
        public int IdPaciente { get; private set; }
        public DateTime Fecha { get; private set; }
        public string Enfermedad { get; private set; }
        public ICollection<DetalleDiagnostico> Detalle { get; private set; }

        public static Diagnostico Agregar(Empleado _empleado, Paciente _paciente, string _enfermedad)
        {
            return new Diagnostico()
            {
                Empleado = _empleado,
                IdEmpleado = _empleado.Id,
                Paciente = _paciente,
                IdPaciente = _paciente.Id,
                Fecha = DateTime.Now,
                Enfermedad = _enfermedad
            };
        }

        public Diagnostico()
        {
            Detalle = new List<DetalleDiagnostico>();
        }

    }
}
