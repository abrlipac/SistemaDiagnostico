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
    public class DetalleDiagnosticoDatos
    {
        //metodo Insertar
        public string Insertar(DetalleDiagnosticoEntidad objDiagnostico)
        {
            string Rpta = "";

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Detalle_Diagnostico_I", sqlConnection);
                //Especificar el tipo de objeto
                comando.CommandType = CommandType.StoredProcedure;
                //Pasarle el parametro
                comando.Parameters.Add("@pdiagnostico_id", SqlDbType.Int).Value = objDiagnostico.DiagnosticoId;
                comando.Parameters.Add("@psintoma", SqlDbType.VarChar).Value = objDiagnostico.Sintoma;

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


        public string Eliminar(int Id)
        {
            string Rpta = "";

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlConnection = Conexion.getInstance().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Detalle_Diagnostico_D", sqlConnection);
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
