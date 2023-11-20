namespace Vendas.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adjust_user_typeUser_optionals : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Usuarios", new[] { "TypeUser" });
            AlterColumn("dbo.Usuarios", "TypeUser", c => c.Int());
            CreateIndex("dbo.Usuarios", "TypeUser");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Usuarios", new[] { "TypeUser" });
            AlterColumn("dbo.Usuarios", "TypeUser", c => c.Int(nullable: false));
            CreateIndex("dbo.Usuarios", "TypeUser");
        }
    }
}
