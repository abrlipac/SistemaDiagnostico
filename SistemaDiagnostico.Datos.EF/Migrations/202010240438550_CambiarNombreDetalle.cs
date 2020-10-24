namespace SistemaDiagnostico.Datos.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiarNombreDetalle : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.DetallesDiagnostico", name: "DetalleDiagnostico_Id", newName: "Diagnostico_Id");
            RenameIndex(table: "dbo.DetallesDiagnostico", name: "IX_DetalleDiagnostico_Id", newName: "IX_Diagnostico_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.DetallesDiagnostico", name: "IX_Diagnostico_Id", newName: "IX_DetalleDiagnostico_Id");
            RenameColumn(table: "dbo.DetallesDiagnostico", name: "Diagnostico_Id", newName: "DetalleDiagnostico_Id");
        }
    }
}
