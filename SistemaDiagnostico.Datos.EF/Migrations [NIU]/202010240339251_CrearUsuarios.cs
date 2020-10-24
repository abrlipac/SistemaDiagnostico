namespace SistemaDiagnostico.Datos.EF.MigrationsNIU
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearUsuarios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomUsuario = c.String(),
                        Clave = c.String(),
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
            DropTable("dbo.Usuarios");
        }
    }
}
