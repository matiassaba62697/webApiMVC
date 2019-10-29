namespace curso.WebApiMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creotablascontrol : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogErroresSistemas",
                c => new
                    {
                        IdLog = c.Int(nullable: false, identity: true),
                        FechaLogError = c.DateTime(nullable: false),
                        Controlador = c.String(),
                        ClaseLogError = c.String(),
                        MetodoLogError = c.String(),
                        HelpLink = c.String(),
                        HResul = c.String(),
                        InnerExeption = c.String(),
                        Source = c.String(),
                        StackTrace = c.String(),
                        TargetSize = c.String(),
                        ComentarioDesarrolador = c.String(),
                    })
                .PrimaryKey(t => t.IdLog);
            
            CreateTable(
                "dbo.Responses",
                c => new
                    {
                        IdResponse = c.Int(nullable: false, identity: true),
                        code = c.Int(nullable: false),
                        message = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.IdResponse);
            
        }
        
        public override void Down()
        {
            //DropTable("dbo.Responses");
            //DropTable("dbo.LogErroresSistemas");
        }
    }
}
