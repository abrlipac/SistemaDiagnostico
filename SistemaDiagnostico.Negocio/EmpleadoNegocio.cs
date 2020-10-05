using SistemaDiagnostico.AccesoDatos;
using SistemaDiagnostico.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDiagnostico.Negocio
{
    public class EmpleadoNegocio
    {
        //Metodo Listar
        public static DataTable Listar()
        {
            EmpleadoDatos objEmpleado = new EmpleadoDatos();
            return objEmpleado.Listar();
        }

        //Metodo Buscar
        public static DataTable Buscar(string Busqueda)
        {
            EmpleadoDatos objEmpleado = new EmpleadoDatos();
            return objEmpleado.Buscar(Busqueda);
        }

        //Metodo Insertar
        public static string Insertar(string Dni, string Nombre, string Apellido, string Cargo, string Direccion, string Celular, string Estado)
        {
            EmpleadoDatos objEmpleadoD = new EmpleadoDatos();

            string Existe = objEmpleadoD.Existe(Dni);

            if (Existe.Equals("1"))
            {
                return "El Empleado ya existe en la BD....";
            }
            else
            {
                EmpleadoEntidad objEmpleadoE = new EmpleadoEntidad();
                objEmpleadoE.Dni = Dni;
                objEmpleadoE.Nombre = Nombre;
                objEmpleadoE.Apellido = Apellido;
                objEmpleadoE.Cargo = Cargo;
                objEmpleadoE.Direccion = Direccion;
                objEmpleadoE.Celular = Celular;
                objEmpleadoE.Estado = Estado;
                return objEmpleadoD.Insertar(objEmpleadoE);
            }
        }

        //Metodo Actualizar
        public static string Actualizar(string Dni, string Nombre, string Apellido, string Cargo, string Direccion, string Celular, string Estado)
        {
            EmpleadoDatos objEmpleadoD = new EmpleadoDatos();

            string Existe = objEmpleadoD.Existe(Dni);

            if (Existe.Equals("1"))
            {
                    return "El Empleado ya existe en la BD....";
            }
            else
            {
                    EmpleadoEntidad objEmpleadoE = new EmpleadoEntidad();
                    objEmpleadoE.Dni = Dni;
                    objEmpleadoE.Nombre = Nombre;
                    objEmpleadoE.Apellido = Apellido;
                    objEmpleadoE.Cargo = Cargo;
                    objEmpleadoE.Direccion = Direccion;
                    objEmpleadoE.Celular = Celular;
                    objEmpleadoE.Estado = Estado;
                    return objEmpleadoD.Actualizar(objEmpleadoE);
            }            
        }

        //Metodo Eliminar
        public static string Eliminar(string Dni)
        {
            EmpleadoDatos objEmpleado = new EmpleadoDatos();
            return objEmpleado.Eliminar(Dni);
        }

        //Metodo Activar
        public static string Activar(string Dni)
        {
            EmpleadoDatos objEmpleado = new EmpleadoDatos();
            return objEmpleado.Activar(Dni);
        }
        //Metodo Desactivar
        public static string Desactivar(string Dni)
        {
            EmpleadoDatos objEmpleado = new EmpleadoDatos();
            return objEmpleado.Desactivar(Dni);
        }
    }
}
