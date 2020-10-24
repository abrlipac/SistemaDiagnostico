namespace SistemaDiagnostico.Datos.EF.MigrationsNIU
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearDiagnosticos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetallesDiagnostico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DetalleDiagnostico_Id = c.Int(nullable: false),
                        Sintoma = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Diagnosticos", t => t.DetalleDiagnostico_Id, cascadeDelete: true)
                .Index(t => t.DetalleDiagnostico_Id);
            
            CreateTable(
                "dbo.Diagnosticos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Empleado_Id = c.Int(nullable: false),
                        Paciente_Id = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Enfermedad = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empleados", t => t.Empleado_Id, cascadeDelete: true)
                .ForeignKey("dbo.Pacientes", t => t.Paciente_Id, cascadeDelete: true)
                .Index(t => t.Empleado_Id)
                .Index(t => t.Paciente_Id);

            AddForeignKey("dbo.Diagnosticos", "Empleado_Id", "dbo.Empleados", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetallesDiagnostico", "DetalleDiagnostico_Id", "dbo.Diagnosticos");
            DropForeignKey("dbo.Diagnosticos", "Paciente_Id", "dbo.Pacientes");
            DropForeignKey("dbo.Diagnosticos", "Empleado_Id", "dbo.Empleados");
            DropIndex("dbo.Diagnosticos", new[] { "Paciente_Id" });
            DropIndex("dbo.Diagnosticos", new[] { "Empleado_Id" });
            DropIndex("dbo.DetallesDiagnostico", new[] { "DetalleDiagnostico_Id" });
            DropTable("dbo.Diagnosticos");
            DropTable("dbo.DetallesDiagnostico");
        }
    }
}
