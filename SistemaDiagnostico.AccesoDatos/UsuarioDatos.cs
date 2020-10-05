using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using SistemaDiagnostico.Entidad;


namespace SistemaDiagnostico.AccesoDatos
{
    public class UsuarioDatos
    {

        //Metodo Login
        public DataTable Login(string Usuario, string Password)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion y verificar
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Usuario_Login", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pusuario", SqlDbType.VarChar).Value = Usuario;
                comando.Parameters.Add("@ppassword", SqlDbType.VarChar).Value = Password;
                sqlCnx.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }

        }


        //Metodo Login Verificar
        public DataTable LoginVerificar(string Busqueda)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion y verificar
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Usuario_Login_V", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pbusqueda", SqlDbType.VarChar).Value = Busqueda;
                sqlCnx.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }

        }

        //Metodo Listar
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion y verificar
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Usuario_S", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                sqlCnx.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }

        }


        //Metodo Buscar
        public DataTable Buscar(string Busqueda)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion y verificar
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Usuario_S_Busqueda", sqlCnx);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasale el parametro
                comando.Parameters.Add("@pbusqueda", SqlDbType.VarChar).Value = Busqueda;
                sqlCnx.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }

        }



        //Metodo Existe
        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion y verificar
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Usuario_Verificar", sqlCnx);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasale el parametro
                comando.Parameters.Add("@pvalor", SqlDbType.VarChar).Value = Valor;
                SqlParameter PExiste = new SqlParameter();
                PExiste.ParameterName = "@pexiste";
                PExiste.SqlDbType = SqlDbType.Int;
                PExiste.Direction = ParameterDirection.Output;

                comando.Parameters.Add(PExiste);
                sqlCnx.Open();

                Rpta = Convert.ToString(PExiste.Value);

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }

            return Rpta;
        }

        //Metodo Insertar
        public string Insertar(UsuarioEntidad objUsuario)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion y verificar
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Usuario_I", sqlCnx);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasale el parametro
                comando.Parameters.Add("@pdni", SqlDbType.VarChar).Value = objUsuario.Dni;
                comando.Parameters.Add("@pusuario", SqlDbType.VarChar).Value = objUsuario.NomUsuario;
                comando.Parameters.Add("@pclave", SqlDbType.VarChar).Value = objUsuario.Clave;
                comando.Parameters.Add("@pestado", SqlDbType.Char).Value = objUsuario.Estado;

                sqlCnx.Open();

                Rpta = comando.ExecuteNonQuery() == 1 ? "Correcto" : "Nose pudo insertar el registro";


            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }

            return Rpta;
        }



        //Metodo Actualizar
        public string Actualizar(UsuarioEntidad objUsuario)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion y verificar
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Usuario_U", sqlCnx);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasale el parametro
                comando.Parameters.Add("@pusuario_id", SqlDbType.Int).Value = objUsuario.UsuarioId;
                comando.Parameters.Add("@pdni", SqlDbType.Char).Value = objUsuario.Dni;
                comando.Parameters.Add("@pusuario", SqlDbType.VarChar).Value = objUsuario.NomUsuario;
                comando.Parameters.Add("@pclave", SqlDbType.VarChar).Value = objUsuario.Clave;
                comando.Parameters.Add("@pestado", SqlDbType.Char).Value = objUsuario.Estado;

                sqlCnx.Open();

                Rpta = comando.ExecuteNonQuery() == 1 ? "Correcto" : "Nose pudo Actualizar el registro";


            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }

            return Rpta;
        }


        //Metodo Eliminar
        public string Eliminar(int Id)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion y verificar
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Usuario_D", sqlCnx);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasale el parametro
                comando.Parameters.Add("@pusuario_id", SqlDbType.Int).Value = Id;

                sqlCnx.Open();

                Rpta = comando.ExecuteNonQuery() == 1 ? "Correcto" : "Nose pudo Eliminar el registro";


            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }

            return Rpta;
        }





        //Metodo Activar
        public string Activar(int Id)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion y verificar
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Usuario_Activar", sqlCnx);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasale el parametro
                comando.Parameters.Add("@pusuario_id", SqlDbType.Int).Value = Id;

                sqlCnx.Open();

                Rpta = comando.ExecuteNonQuery() == 1 ? "Correcto" : "Nose pudo Activar el registro";


            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }

            return Rpta;
        }


        //Metodo Desactivar
        public string Desactivar(int Id)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion y verificar
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Usuario_Desactivar", sqlCnx);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasale el parametro
                comando.Parameters.Add("@pusuario_id", SqlDbType.Int).Value = Id;

                sqlCnx.Open();

                Rpta = comando.ExecuteNonQuery() == 1 ? "Correcto" : "Nose pudo Desactivar el registro";


            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }

            return Rpta;
        }


    }
}
