namespace Cel.Modelo.Persistencia.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class empresa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.empresas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome_fantasia = c.String(nullable: false, maxLength: 500, unicode: false),
                        razao_social = c.String(nullable: false, maxLength: 500, unicode: false),
                        email = c.String(nullable: false, maxLength: 500, unicode: false),
                        cnpj = c.String(nullable: false, maxLength: 14, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.usuarios", "IdEmpresa", c => c.Int(nullable: false));
            CreateIndex("dbo.usuarios", "IdEmpresa");
            AddForeignKey("dbo.usuarios", "IdEmpresa", "dbo.empresas", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.usuarios", "IdEmpresa", "dbo.empresas");
            DropIndex("dbo.usuarios", new[] { "IdEmpresa" });
            DropColumn("dbo.usuarios", "IdEmpresa");
            DropTable("dbo.empresas");
        }
    }
}
