using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDiagnostico.AccesoDatos;
using SistemaDiagnostico.Entidad;
using System.Data;

namespace SistemaDiagnostico.Negocio
{
    public class UsuarioNegocio
    {
        //Metodo Login
        public static DataTable Login(string usuario, string password)
        {
            UsuarioDatos objUsuario = new UsuarioDatos();
            return objUsuario.Login(usuario, password);
        }


        //Metodo Login Verificar
        public static DataTable LoginVerificar(string Busqueda)
        {
            UsuarioDatos objUsuario = new UsuarioDatos();
            return objUsuario.LoginVerificar(Busqueda);
        }


        //Metodo Listar
        public static DataTable Listar()
        {
            UsuarioDatos objUsuario = new UsuarioDatos();
            return objUsuario.Listar();
        }

        //Metodo Buscar
        public static DataTable Buscar(string Busqueda)
        {
            UsuarioDatos objUsuario = new UsuarioDatos();
            return objUsuario.Buscar(Busqueda);
        }

        //Metodo Insertar
        public static string Insertar(string Dni, string Usuario, string Clave, string Estado)
        {
            UsuarioDatos objUsuarioD = new UsuarioDatos();

            string Existe = objUsuarioD.Existe(Usuario);

            if (Existe.Equals("1"))
            {
                return "El usuario ya existe en la BD...";
            }
            else
            {
                UsuarioEntidad objUsuarioE = new UsuarioEntidad();
                objUsuarioE.Dni = Dni;
                objUsuarioE.NomUsuario = Usuario;
                objUsuarioE.Clave = Clave;
                objUsuarioE.Estado = Estado;
                return objUsuarioD.Insertar(objUsuarioE);
            }
        }


        //Metodo Actualizar
        public static string Actualizar(int id, string Dni, string Usuario, string Clave, string Estado)
        {
            UsuarioDatos objUsuarioD = new UsuarioDatos();

            string Existe = objUsuarioD.Existe(Usuario);

            if (Existe.Equals("1"))
            {
                return "El usuario ya existe en la BD...";
            }
            else
            {
                UsuarioEntidad objUsuarioE = new UsuarioEntidad();
                objUsuarioE.UsuarioId = id;
                objUsuarioE.Dni = Dni;
                objUsuarioE.NomUsuario = Usuario;
                objUsuarioE.Clave = Clave;
                objUsuarioE.Estado = Estado;
                return objUsuarioD.Actualizar(objUsuarioE);
            }
        }

        //Metodo Eliminar
        public static string Eliminar(int id)
        {
            UsuarioDatos objUsuarioD = new UsuarioDatos();
            return objUsuarioD.Eliminar(id);
        }

        //Metodo Activar
        public static string Activar(int id)
        {
            UsuarioDatos objUsuarioD = new UsuarioDatos();
            return objUsuarioD.Activar(id);
        }

        //Metodo Desactivar
        public static string Desactivar(int id)
        {
            UsuarioDatos objUsuarioD = new UsuarioDatos();
            return objUsuarioD.Desactivar(id);
        }
    }
}
