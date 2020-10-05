using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.AccesoDatos
{
    class Conexion
    {
        
        private string BD; //Nombre de la base de datos
        private string Server; //Nombre del servidor-IP-Dominio
        private string User; //Usuario del motor del SGBD (sa)
        private string Clave; //Clave del usuario del motor SGBD
        private bool Autenticacion; //Windows y SQL
        private static Conexion cnx = null;

        private Conexion()
        {
            this.BD = "db_Proyecto";
            this.Server = @"DESKTOP-VIQVK2F\SQLEXPRESS";
            this.User = "";
            this.Clave = "";
            this.Autenticacion = true; //Windows
        }

        public SqlConnection EstablecerConexion()
        {
            SqlConnection cadenaconex = new SqlConnection();
            try
            {
                cadenaconex.ConnectionString = "Server=" + this.Server + ";"
                    + "Database=" + this.BD + ";";

                if (this.Autenticacion) //Seguridad Windows
                {
                    cadenaconex.ConnectionString = cadenaconex.ConnectionString + "Integrated Security = SSPI";
                }
                else //Autenticacion SQL
                {
                    cadenaconex.ConnectionString = cadenaconex.ConnectionString + "User ID=" +
                        this.User + ";" + "Password=" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                cadenaconex = null;
                throw ex;
            }
            return cadenaconex;
        }

        public static Conexion getInstance()
        {
            if (cnx == null)
            {
                cnx = new Conexion();
            }
            return cnx;
        }
    }
}
