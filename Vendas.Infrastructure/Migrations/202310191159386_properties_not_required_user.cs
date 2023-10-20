namespace Vendas.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class properties_not_required_user : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "BiometryDataBinary", c => c.Binary());
            AlterColumn("dbo.Usuarios", "BiometryDataText", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "BiometryDataText", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "BiometryDataBinary", c => c.Binary(nullable: false));
        }
    }
}
