namespace SistemaDiagnostico.Datos.EF.MigrationsNIU
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearEmpleado : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cargo = c.String(),
                        Estado = c.String(),
                        Dni = c.String(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Direccion = c.String(),
                        Celular = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empleados");
        }
    }
}
