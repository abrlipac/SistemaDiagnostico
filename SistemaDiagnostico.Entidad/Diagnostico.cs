using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.Entidad
{
    public class Diagnostico
    {

        public int idDiagnostico { get; private set; }
        public  Empleado empleado{ get; private set; }
        public int idEmpleado { get; private set; }
        public Paciente paciente { get; private set; }
        public int idPaciente { get; private set; }
        public DateTime Fecha { get; private set; }
        public string Enfermedad { get; private set; }
        public ICollection<DetalleDiagnostico> Detalle { get; private set; }

        public static Diagnostico Agregar(Empleado _empleado, Paciente _paciente, string _enfermedad)
        {
            return new Diagnostico()
            {
                empleado = _empleado,
                idEmpleado = _empleado.IdEmpleado,
                paciente = _paciente,
                idPaciente = _paciente.IdPaciente,
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
