using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.Entidad
{
    public class Paciente: Persona
    {
        /// <summary>
        /// Identificador único del Paciente
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Estado del Paciente
        /// </summary>
        public string Estado { get; private set; }


        public Paciente(string _dni, string _nombre, string _apellido, char _sexo, string _direccion, string _celular, string _estado)
          : base(_dni, _nombre, _apellido, _sexo, _direccion, _celular)
        {
            Dni = _dni;
            Nombre = _nombre;
            Apellido = _apellido;
            Sexo = _sexo;
            Direccion = _direccion;
            Celular = _celular;
            Estado = _estado;
        }

        /// <summary>
        /// Permite registrar a un nuevo Paciente
        /// </summary>
        /// <param name="_dni">Dni del Paciente</param>
        /// <param name="_nombre">Nombre del Paciente</param>
        /// <param name="_apellido">Apellido del Paciente</param>
        /// <param name="_sexo">Sexo del Paciente</param>
        /// <param name="_direccion">Direccion del empleado</param>
        /// <param name="_celular">Celular del empleado</param>
        /// <param name="_estado">Estado del empleado</param>
        /// <returns>Instancia nueva de la clase Empleado</returns>
        public static Paciente Agregar( string _dni, string _nombre, string _apellido, char _sexo, string _direccion, string _celular, string _estado = "A")
            => new Paciente(_dni, _nombre, _apellido, _sexo, _direccion, _celular, _estado);

        /// <summary>
        /// Permite modificar los datos del Paciente
        /// </summary>
        /// <param name="_dni">Nombre del Paciente</param>
        /// <param name="_nombre">Nombre del Paciente</param>
        /// <param name="_apellido">Apellido del Paciente</param>
        /// <param name="_sexo">Sexo del Paciente</param>
        /// <param name="_direccion">Direccion del Paciente</param>
        /// <param name="_celular">Celular del Paciente</param>

        public void ModificarDatos(string _dni, string _nombre, string _apellido, char _sexo, string _direccion, string _celular)
        {
            Dni = _dni;
            Nombre = _nombre;
            Apellido = _apellido;
            Sexo = _sexo;
            Direccion = _direccion;
            Celular = _celular;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Desactivar()
            => Estado = "D";

    }
}
