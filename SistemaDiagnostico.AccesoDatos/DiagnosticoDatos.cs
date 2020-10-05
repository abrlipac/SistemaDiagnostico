using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaDiagnostico.Entidad;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace SistemaDiagnostico.AccesoDatos
{
    public class DiagnosticoDatos
    {
        //metodo Grafico de diagnostico de enfermedades 
        public DataTable GrafEnfermedades()
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Grafico", sqlConnection);
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


        //metodo Grafico de diagnostico de enfermedades 
        public DataTable GrafEnfermedades2()
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Grafico2", sqlConnection);
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

        //metodo Grafico de diagnostico de enfermedades 
        public DataTable GrafEnfermedades3()
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Grafico3", sqlConnection);
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


        //metodo Grafico de diagnostico de enfermedades 
        public DataTable GrafEnfermedades4()
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Grafico4", sqlConnection);
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

        //metodo Grafico de diagnostico de enfermedades 
        public DataTable GrafEnfermedades5()
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Grafico5", sqlConnection);
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


        //metodo Grafico de diagnostico de enfermedades 
        public DataTable GrafEnfermedades6()
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Grafico6", sqlConnection);
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

        //metodo Grafico de diagnostico de enfermedades 
        public DataTable GrafEnfermedades7()
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Grafico7", sqlConnection);
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
                SqlCommand comando = new SqlCommand("USP_Diagnostico_S_A", sqlConnection);
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
                SqlCommand comando = new SqlCommand("USP_Diagnostico_S_Busqueda", sqlConnection);
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

        //metodo Buscar  Paciente - DNI
        public DataTable BuscarPD(string Busqueda)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {

                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Paciente_S_Busqueda_PD", sqlConnection);
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

        //metodo Insertar
        public string Insertar(DiagnosticoEntidad objDiagnostico)
        {
            string Rpta = "";

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Diagnostico_I", sqlConnection);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@diagnostico_id", SqlDbType.Int).Value = objDiagnostico.DiagnosticoId;
                comando.Parameters.Add("@pdniempleado", SqlDbType.VarChar).Value = objDiagnostico.dniEmpleado;
                comando.Parameters.Add("@pdni", SqlDbType.VarChar).Value = objDiagnostico.Dni;
                comando.Parameters.Add("@pfecha", SqlDbType.VarChar).Value = objDiagnostico.Fecha;
                comando.Parameters.Add("@penfermedad", SqlDbType.VarChar).Value = objDiagnostico.Enfermedad;

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
                comando.Parameters.Add("@pdni", SqlDbType.Int).Value = objEmpleado.Dni;
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
        public string Eliminar(int Id)
        {
            string Rpta = "";

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Diagnostico_D", sqlConnection);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pdiagnostico_id", SqlDbType.Int).Value = Id;

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
    }
}
