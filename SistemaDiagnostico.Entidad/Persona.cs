using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.Entidad
{
    public abstract class Persona
    {
        protected string _Dni { get; set; }
        protected string _Nombre { get; set; }
        protected string _Apellido { get; set; }
        protected char _Sexo { get; set; }
        protected string _Direccion { get; set; }
        protected string _Celular { get; set; }
        
        public Persona(string dni, string nombre, string apellido, char sexo, string direccion, string celular)
        {
            _Dni = dni;
            _Nombre = nombre;
            _Apellido = apellido;
            _Sexo = sexo;
            _Direccion = direccion; 
            _Celular = celular;

        }

        public void ActualizarDatosPersonales(string dni = _Dni, string nombre = _Nombre, string apellido = _Apellido, char sexo = _Sexo, string direccion = _Direccion, string celular = _Celular)
        {
          _Dni = dni;
          _Nombre = nombre;
          _Apellido = apellido;
          _Sexo = sexo;
          _Direccion = direccion;
          _Celular = celular;
        }
  }
}
