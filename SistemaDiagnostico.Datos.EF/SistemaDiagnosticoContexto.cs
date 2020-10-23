using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDiagnostico.Entidad;

namespace SistemaDiagnostico.Datos.EF
{
    class SistemaDiagnosticoContexto : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
    }
}
