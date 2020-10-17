using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.Entidad
{
    public class Empleado : Persona
    {
        public int _Id { get; private set; }
        public string _Cargo { get; private set; }
        public string _Estado { get; private set; }
       
        public Empleado(int id, string dni, string nombre, string apellido, char sexo, string direccion, string celular, string cargo, string estado)
          : base(dni, nombre, apellido,  sexo,  direccion,  celular)
        {
            _Id = id;
            _Cargo = cargo;
            _Estado = estado;
        }

    public static Empleado Agregar(int id, string dni, string nombre, string apellido, char sexo, string direccion, string celular, string cargo, string estado)
          => new Empleado(id, dni, nombre, apellido, sexo , direccion,celular, cargo, estado);
    
    public void Activar()
      => _Estado = "A";
    public void Desactivar()
      => _Estado = "D";

    } 
   
}
