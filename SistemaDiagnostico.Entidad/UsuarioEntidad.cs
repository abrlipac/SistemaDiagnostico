using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.Entidad
{
    public class UsuarioEntidad
    {
        public int UsuarioId { get; set; }
        public string Dni { get; set; }
        public string NomUsuario { get; set; }
        public string Clave { get; set; }
        public string Estado { get; set; }

    }
}
