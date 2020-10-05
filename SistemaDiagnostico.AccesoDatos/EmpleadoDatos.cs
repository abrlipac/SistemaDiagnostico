using SistemaDiagnostico.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.AccesoDatos
{
    public class EmpleadoDatos
    {
        //metodo listar 
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Empleado_S", sqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

        }

        //metodo Buscar 
        public DataTable Buscar(string Busqueda)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Empleado_S_Busqueda", sqlConnection);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pbusqueda", SqlDbType.VarChar).Value = Busqueda;
                sqlConnection.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

        }

        //metodo Verificar 
        public string Existe(string Valor)
        {
            string Rpta = "";

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Empleado_Verificar", sqlConnection);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pvalor", SqlDbType.VarChar).Value = Valor;
                SqlParameter PExiste = new SqlParameter();
                PExiste.ParameterName = "@pexiste";
                PExiste.SqlDbType = SqlDbType.Int;
                PExiste.Direction = ParameterDirection.Output;
                sqlConnection.Open();

                Rpta = Convert.ToString(PExiste.Value);


            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }
            return Rpta;
        }

        //metodo Insertar
        public string Insertar(EmpleadoEntidad objEmpleado)
        {
            string Rpta = "";

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Empleado_I", sqlConnection);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pdni", SqlDbType.VarChar).Value = objEmpleado.Dni;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objEmpleado.Nombre;
                comando.Parameters.Add("@papellido", SqlDbType.VarChar).Value = objEmpleado.Apellido;
                comando.Parameters.Add("@pcargo", SqlDbType.VarChar).Value = objEmpleado.Cargo;
                comando.Parameters.Add("@pdireccion", SqlDbType.VarChar).Value = objEmpleado.Direccion;
                comando.Parameters.Add("@pcelular", SqlDbType.VarChar).Value = objEmpleado.Celular;
                comando.Parameters.Add("@pestado", SqlDbType.VarChar).Value = objEmpleado.Estado;

                sqlConnection.Open();

                Rpta = comando.ExecuteNonQuery() == 1 ? "Correcto" : "No se pudo Insertar el Registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }
            return Rpta;
        }

        //Metodo Actualizar
        public string Actualizar(EmpleadoEntidad objEmpleado)
        {
            string Rpta = "";

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Empleado_U", sqlConnection);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pdni", SqlDbType.VarChar).Value = objEmpleado.Dni;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objEmpleado.Nombre;
                comando.Parameters.Add("@papellido", SqlDbType.VarChar).Value = objEmpleado.Apellido;
                comando.Parameters.Add("@pcargo", SqlDbType.VarChar).Value = objEmpleado.Cargo;
                comando.Parameters.Add("@pdireccion", SqlDbType.VarChar).Value = objEmpleado.Direccion;
                comando.Parameters.Add("@pcelular", SqlDbType.VarChar).Value = objEmpleado.Celular;
                comando.Parameters.Add("@pestado", SqlDbType.VarChar).Value = objEmpleado.Estado;

                sqlConnection.Open();

                Rpta = comando.ExecuteNonQuery() == 1 ? "Correcto" : "No se pudo Actualizar el Registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }
            return Rpta;
        }

        //Metodo Eliminar
        public string Eliminar(string Dni)
        {
            string Rpta = "";

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Empleado_D", sqlConnection);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pdni", SqlDbType.Char).Value = Dni;

                sqlConnection.Open();

                Rpta = comando.ExecuteNonQuery() == 1 ? "Correcto" : "No se pudo Eliminar el Registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }
            return Rpta;
        }

        //Metodo Activar
        public string Activar(string Dni)
        {
            string Rpta = "";

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Empleado_Activar", sqlConnection);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pdni", SqlDbType.VarChar).Value = Dni;

                sqlConnection.Open();

                Rpta = comando.ExecuteNonQuery() == 1 ? "Correcto" : "No se pudo Activar el Registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }
            return Rpta;
        }

        //Metodo Desactivar
        public string Desactivar(string Dni)
        {
            string Rpta = "";

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Empleado_Desactivar", sqlConnection);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pdni", SqlDbType.Int).Value = Dni;

                sqlConnection.Open();

                Rpta = comando.ExecuteNonQuery() == 1 ? "Correcto" : "No se pudo Desactivar el Registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }
            return Rpta;
        }
    }
}
