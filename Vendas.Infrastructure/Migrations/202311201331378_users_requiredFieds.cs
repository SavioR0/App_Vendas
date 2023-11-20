namespace Vendas.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class users_requiredFieds : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "LastName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Usuarios", "Cpf", c => c.String(maxLength: 11));
            AlterColumn("dbo.Usuarios", "Tel", c => c.String(maxLength: 20));
            AlterColumn("dbo.Usuarios", "Email", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Usuarios", "Tel", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Usuarios", "Cpf", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Usuarios", "LastName", c => c.String());
        }
    }
}
