namespace EFCF.Estudiantes.LarghiF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatalogoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EFCFEstudiantes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 100),
                        Apellido = c.String(nullable: false, maxLength: 100),
                        Promedio = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EFCFEstudiantes");
        }
    }
}
