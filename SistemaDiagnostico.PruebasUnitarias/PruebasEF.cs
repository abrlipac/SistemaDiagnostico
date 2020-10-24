using System;
using System.Data.Entity;
using System.Data.EntityClient;
using SistemaDiagnostico.Datos.EF;
using SistemaDiagnostico.Entidad;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SistemaDiagnostico.PruebasUnitarias
{
    [TestClass]
    public class PruebasEF
    {
        [TestMethod]
        public void Insert_AreEqualTrue_IfAddAndFind()
        {
            Empleados empleado = new Empleados
            {
                Dni = "76368626",
                Nombre = "Abraham",
                Apellido = "Lipa",
                Direccion = "Av. Leguia 123",
                Celular = "942917242",
                Cargo = "Medico",
                Estado = "A"
            };

            using (var db = new SDiagnostico())
            {
                db.Empleados.Add(empleado);
                db.SaveChanges();

                var dniBuscado = db.Empleados.Where(e => e.Dni == "76368626").First().Dni;
                Assert.AreEqual(empleado.Dni, dniBuscado);
            }
        }
        [TestMethod]
        public void Update_ShouldTrue_IfFindAndFind()
        {
            using (var db = new SDiagnostico())
            {
                var empleado = db.Empleados.Where(e => e.Dni == "76368626").First();
                empleado.Apellido = "Lipa Calabilla";
                db.Empleados.Add(empleado);

                db.Entry(empleado).State = System.Data.EntityState.Modified;
                db.SaveChanges();
            }

            using (var db = new SDiagnostico())
            {
                var empleadoBuscado = db.Empleados.Where(e => e.Dni == "76368626").First();
                var apellidoBuscado = empleadoBuscado.Apellido;
                Assert.AreEqual("Lipa Calabilla", apellidoBuscado);
            }
        }
        [TestMethod]
        public void Delete_ShouldTrue_IfRemoveAndFind()
        {
            using (var db = new SDiagnostico())
            {
                var empleado = db.Empleados.Where(e => e.Dni == "76368626").First();
                db.Empleados.Remove(empleado);
                db.SaveChanges();

                Assert.ThrowsException<InvalidOperationException>(() => db.Empleados.Where(e => e.Dni == "76368626").First());
            }
        }
    }
}
