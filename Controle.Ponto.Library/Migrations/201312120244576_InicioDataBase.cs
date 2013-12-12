namespace Controle.Ponto.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicioDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                        Senha = c.String(maxLength: 50),
                        Matricula = c.Int(nullable: false),
                        CsExcluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t=>t.Matricula, unique:true);
            
            CreateTable(
                "dbo.DiaPonto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUsuario = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                        CsExcluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.IdUsuario, cascadeDelete: true)
                .Index(t => t.IdUsuario);
            
            CreateTable(
                "dbo.Registro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hora = c.Time(nullable: false),
                        IdDiaPonto = c.Int(nullable: false),
                        CsExcluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DiaPonto", t => t.IdDiaPonto, cascadeDelete: true)
                .Index(t => t.IdDiaPonto);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Registro", new[] { "IdDiaPonto" });
            DropIndex("dbo.DiaPonto", new[] { "IdUsuario" });
            DropForeignKey("dbo.Registro", "IdDiaPonto", "dbo.DiaPonto");
            DropForeignKey("dbo.DiaPonto", "IdUsuario", "dbo.Usuario");
            DropTable("dbo.Registro");
            DropTable("dbo.DiaPonto");
            DropTable("dbo.Usuario");
        }
    }
}
