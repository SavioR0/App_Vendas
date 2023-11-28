namespace Vendas.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_fieldOptiona : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Pedido", new[] { "SaleId" });
            AlterColumn("dbo.Pedido", "SaleId", c => c.Int());
            CreateIndex("dbo.Pedido", "SaleId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Pedido", new[] { "SaleId" });
            AlterColumn("dbo.Pedido", "SaleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Pedido", "SaleId");
        }
    }
}
