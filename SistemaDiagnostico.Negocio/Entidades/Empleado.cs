using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.Entidad
{
    public class Empleado : Persona
    {
        /// <summary>
        /// Identificador único del Empleado
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Cargo del Empleado
        /// </summary>
        public string Cargo { get; private set; }
        /// <summary>
        /// Estado del Empleado
        /// </summary>
        public string Estado { get; private set; }

        public Empleado(string _dni, string _nombre, string _apellido, char _sexo, string _direccion, string _celular, string _cargo, string _estado)
          : base(_dni, _nombre, _apellido,  _sexo,  _direccion,  _celular)
        {
            Cargo = _cargo;
            Estado = _estado;
        }

        /// <summary>
        /// Permite registrar a un nuevo Empleado
        /// </summary>
        /// <param name="_dni">Dni del empleado</param>
        /// <param name="_nombre">Nombre del empleado</param>
        /// <param name="_apellido">Apellido del empleado</param>
        /// <param name="_sexo">Sexo del empleado</param>
        /// <param name="_direccion">Direccion del empleado</param>
        /// <param name="_celular">Celular del empleado</param>
        /// <param name="_cargo">Cargo del empleado</param>
        /// <param name="_estado">Estado del empleado</param>
        /// <returns>Instancia nueva de la clase Empleado</returns>
        public static Empleado Agregar( string _dni, string _nombre, string _apellido, char _sexo, string _direccion, string _celular, string _cargo, string _estado="A")
            => new Empleado(_dni, _nombre, _apellido, _sexo , _direccion, _celular, _cargo, _estado);


        /// <summary>
        /// Permite modificar los datos del Empleado
        /// </summary>
        /// <param name="_dni">Nombre del empleado</param>
        /// <param name="_nombre">Nombre del empleado</param>
        /// <param name="_apellido">Apellido del empleado</param>
        /// <param name="_sexo">Sexo del empleado</param>
        /// <param name="_direccion">Direccion del empleado</param>
        /// <param name="_celular">Celular del empleado</param>
        /// <param name="_cargo">Cargo del empleado</param>
        public void ModificarDatos(string _dni, string _nombre, string _apellido, char _sexo, string _direccion, string _celular, string _cargo)         
        {
            Dni = _dni;
            Nombre = _nombre;
            Apellido = _apellido;
            Sexo = _sexo;
            Direccion = _direccion;
            Celular = _celular;
            Cargo = _cargo;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Desactivar()
            => Estado = "D";

    } 
   
}
