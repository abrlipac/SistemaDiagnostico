using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDiagnostico.AccesoDatos;
using SistemaDiagnostico.Entidad;
using System.Data;

namespace SistemaDiagnostico.Negocio
{
    public class PacienteNegocio
    {
        //Metodo Insertar
        public static string Insertar(string Dni, string Nombre, string Apellido, string Sexo, string Direccion, string Celular, string Estado)
        {
            PacienteDatos objPacienteD = new PacienteDatos();

            string Existe = objPacienteD.Existe(Dni);

            if (Existe.Equals("1"))
            {
                return "El Paciente ya existe en la BD....";
            }
            else
            {
                Paciente objPacienteE = new Paciente();
                objPacienteE.Dni = Dni;
                objPacienteE.Nombre = Nombre;
                objPacienteE.Apellido = Apellido;
                objPacienteE.Sexo = Sexo;
                objPacienteE.Direccion = Direccion;
                objPacienteE.Celular = Celular;
                objPacienteE.Estado = Estado;
                return objPacienteD.Insertar(objPacienteE);
            }
        }

        //Metodo Actualizar
        public static string Actualizar(string Dni, string Nombre, string Apellido, string Sexo, string Direccion, string Celular, string Estado)
        {
            PacienteDatos objPacienteD = new PacienteDatos();
           
            string Existe = objPacienteD.Existe(Dni);


            if (Existe.Equals("1"))
            {
                    return "El Paciente ya existe en la BD....";
            }

            else
            {
                PacienteEntidad objPacienteE = new PacienteEntidad();
                objPacienteE.Dni = Dni;
                objPacienteE.Nombre = Nombre;
                objPacienteE.Apellido = Apellido;
                objPacienteE.Sexo = Sexo;
                objPacienteE.Direccion = Direccion;
                objPacienteE.Celular = Celular;
                objPacienteE.Estado = Estado;
                return objPacienteD.Actualizar(objPacienteE);
            }
            
        }

        //Metodo Listar
        public static DataTable Listar()
        {
            PacienteDatos objPaciente = new PacienteDatos();
            return objPaciente.Listar();
        }

        //Metodo Buscar
        public static DataTable Buscar(string Busqueda)
        {
            PacienteDatos objPaciente = new PacienteDatos();
            return objPaciente.Buscar(Busqueda);
        }

        //Metodo Eliminar
        public static string Eliminar(string Dni)
        {
            PacienteDatos objPaciente = new PacienteDatos();
            return objPaciente.Eliminar(Dni);
        }

        //Metodo Activar
        public static string Activar(int Dni)
        {
            PacienteDatos objPaciente = new PacienteDatos();
            return objPaciente.Activar(Dni);
        }

        //Metodo Desactivar
        public static string Desactivar(int Dni)
        {
            PacienteDatos objPaciente = new PacienteDatos();
            return objPaciente.Desactivar(Dni);
        }
    }
}
