using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.Entidad
{
    public abstract class Persona
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public char Sexo { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        
        public Persona(string _dni, string _nombre, string _apellido, char _sexo, string _direccion, string _celular)
        {
            Dni = _dni;
            Nombre = _nombre;
            Apellido = _apellido;
            Sexo = _sexo;
            Direccion = _direccion; 
            Celular = _celular;
        }
    }
}
