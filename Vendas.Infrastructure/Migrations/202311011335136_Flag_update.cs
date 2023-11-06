namespace Vendas.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Flag_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Flag", c => c.String(nullable: false));
            AddColumn("dbo.Vendas", "Flag", c => c.String(nullable: false));
            AddColumn("dbo.Produtos", "Flag", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtos", "Flag");
            DropColumn("dbo.Vendas", "Flag");
            DropColumn("dbo.Usuarios", "Flag");
        }
    }
}
