namespace Vendas.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adjust_user_fields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "DateOfBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
