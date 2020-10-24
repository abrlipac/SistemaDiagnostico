using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.Entidad
{
    public class Usuario: Persona
    {
        /// <summary>
        /// Identificador único del Usuario
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Nombre de usuario
        /// </summary>
        public string NomUsuario { get; private set; }
        /// <summary>
        /// Clave del Usuario
        /// </summary>
        public string Clave { get; private set; }
        /// <summary>
        /// Estado del Usuario
        /// </summary>
        public string Estado { get; private set; }


        public Usuario(string _dni, string _nombre, string _apellido, char _sexo, string _direccion, string _celular, string _nomUsuario, string _clave,string _estado)
          : base(_dni, _nombre, _apellido, _sexo, _direccion, _celular)
        {
            NomUsuario = _nomUsuario;
            Clave = _clave;
            Estado = _estado;
        }

        /// <summary>
        /// Permite registrar a un nuevo Usuario
        /// </summary>
        /// <param name="_dni">Dni del Usuario</param>
        /// <param name="_nombre">Nombre del Usuario</param>
        /// <param name="_apellido">Apellido del Usuario</param>
        /// <param name="_sexo">Sexo del Usuario</param>
        /// <param name="_direccion">Direccion del Usuario</param>
        /// <param name="_celular">Celular del Usuario</param>
        /// <param name="_nomUsuario">Cargo del Usuario</param>
        /// <param name="_clave">Cargo del Usuario</param>
        /// <param name="_estado">Estado del Usuario</param>
        /// <returns>Instancia nueva de la clase Usuario</returns>
        public static Usuario Agregar(string _dni, string _nombre, string _apellido, char _sexo, string _direccion, string _celular, string _nomUsuario, string _clave, string _estado = "A")
            => new Usuario(_dni, _nombre, _apellido, _sexo, _direccion, _celular, _nomUsuario, _clave, _estado);


        /// <summary>
        /// Permite modificar los datos del Usuario
        /// </summary>
        /// <param name="_dni">Nombre del Usuario</param>
        /// <param name="_nombre">Nombre del Usuario</param>
        /// <param name="_apellido">Apellido del Usuario</param>
        /// <param name="_sexo">Sexo del Usuario</param>
        /// <param name="_direccion">Direccion del Usuario</param>
        /// <param name="_celular">Celular del Usuario</param>
        /// <param name="_nomUsuario">Cargo del Usuario</param>
        /// <param name="_clave">Cargo del Usuario</param>
        public void ModificarDatos(string _dni, string _nombre, string _apellido, char _sexo, string _direccion, string _celular, string _nomUsuario, string _clave)
        {
            Dni = _dni;
            Nombre = _nombre;
            Apellido = _apellido;
            Sexo = _sexo;
            Direccion = _direccion;
            Celular = _celular;
            NomUsuario = _nomUsuario;
            Clave = _clave;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Desactivar()
            => Estado = "D";

    }
}
