using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.Entidad
{
    public abstract class Persona
    {
        protected string Dni { get; set; }
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected char Sexo { get; set; }
        protected string Direccion { get; set; }
        protected string Celular { get; set; }
        
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
