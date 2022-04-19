namespace EFCF.Estudiantes.LarghiF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EstadoDelEstudiante : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EFCFEstudiantes", "Activo", c => c.Boolean(nullable: false));
            Sql("Update EFCFEstudiantes Set Activo=0");
        }
        
        public override void Down()
        {
            DropColumn("dbo.EFCFEstudiantes", "Activo");
        }
    }
}
