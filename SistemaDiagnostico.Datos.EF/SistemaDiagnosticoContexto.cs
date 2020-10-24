using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDiagnostico.Entidad;

namespace SistemaDiagnostico.Datos.EF
{
    public class SistemaDiagnosticoContexto : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<DetalleDiagnostico> DetallesDiagnostico { get; set; }
    }
}
