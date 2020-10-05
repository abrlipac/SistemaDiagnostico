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
    public class PacienteDatos
    {
        //Metodo Insertar
        public string Insertar(PacienteEntidad objPaciente)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Paciente_I", sqlCnx);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pdni", SqlDbType.Char).Value = objPaciente.Dni;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objPaciente.Nombre;
                comando.Parameters.Add("@papellido", SqlDbType.VarChar).Value = objPaciente.Apellido;
                comando.Parameters.Add("@psexo", SqlDbType.VarChar).Value = objPaciente.Sexo;
                comando.Parameters.Add("@pdireccion", SqlDbType.Text).Value = objPaciente.Direccion;
                comando.Parameters.Add("@pcelular", SqlDbType.Char).Value = objPaciente.Celular;
                comando.Parameters.Add("@pestado", SqlDbType.Char).Value = objPaciente.Estado;

                sqlCnx.Open();

                Rpta = comando.ExecuteNonQuery() == 1 ? "Correcto" : "No se puede insertar el registro";

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
        public string Actualizar(PacienteEntidad objPaciente)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Paciente_U", sqlCnx);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pdni", SqlDbType.Char).Value = objPaciente.Dni;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objPaciente.Nombre;
                comando.Parameters.Add("@papellido", SqlDbType.VarChar).Value = objPaciente.Apellido;
                comando.Parameters.Add("@psexo", SqlDbType.VarChar).Value = objPaciente.Sexo;
                comando.Parameters.Add("@pdireccion", SqlDbType.Text).Value = objPaciente.Direccion;
                comando.Parameters.Add("@pcelular", SqlDbType.Char).Value = objPaciente.Celular;
                comando.Parameters.Add("@pestado", SqlDbType.Char).Value = objPaciente.Estado;

                sqlCnx.Open();

                Rpta = comando.ExecuteNonQuery() == 1 ? "Correcto" : "No se puede actualizar el registro";

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

        //Metodo Existe
        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Paciente_Verificar", sqlCnx);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
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

        //Metodo Listar
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Paciente_S", sqlCnx);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                sqlCnx.Open();
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
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
        }
        //Metodo Buscar
        public DataTable Buscar(string Busqueda)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Paciente_S_Busqueda", sqlCnx);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pbusqueda", SqlDbType.VarChar).Value = Busqueda;
                sqlCnx.Open();
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
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
        }

        //Metodo Eliminar
        public string Eliminar(string Dni)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Paciente_D", sqlCnx);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pdni", SqlDbType.Char).Value = Dni;

                sqlCnx.Open();

                Rpta = comando.ExecuteNonQuery() == 1 ? "Correcto" : "No se puede eliminar el registro";

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
        public string Activar(int Dni)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Paciente_Activar", sqlCnx);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pdni", SqlDbType.Int).Value = Dni;

                sqlCnx.Open();

                Rpta = comando.ExecuteNonQuery() == 1 ? "Correcto" : "No se puede activar el registro";

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
        public string Desactivar(int Dni)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer la conexion
                sqlCnx = Conexion.getInstance().EstablecerConexion();
                //LLamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Paciente_Desactivar", sqlCnx);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pdni", SqlDbType.Int).Value = Dni;

                sqlCnx.Open();

                Rpta = comando.ExecuteNonQuery() == 1 ? "Correcto" : "No se puede desactivar el registro";

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
