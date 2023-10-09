namespace Vendas.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table_sales : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Sale", newName: "Vendas");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Vendas", newName: "Sale");
        }
    }
}
