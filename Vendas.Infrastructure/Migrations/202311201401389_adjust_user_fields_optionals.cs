namespace Vendas.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adjust_user_fields_optionals : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Usuarios", new[] { "AddressId" });
            AlterColumn("dbo.Usuarios", "AddressId", c => c.Int());
            AlterColumn("dbo.Usuarios", "EditLogin", c => c.Int());
            CreateIndex("dbo.Usuarios", "AddressId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Usuarios", new[] { "AddressId" });
            AlterColumn("dbo.Usuarios", "EditLogin", c => c.Int(nullable: false));
            AlterColumn("dbo.Usuarios", "AddressId", c => c.Int(nullable: false));
            CreateIndex("dbo.Usuarios", "AddressId");
        }
    }
}
