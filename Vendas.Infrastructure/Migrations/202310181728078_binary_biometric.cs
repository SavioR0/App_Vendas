namespace Vendas.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class binary_biometric : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "BiometryDataBinary", c => c.Binary(nullable: false));
            AddColumn("dbo.Usuarios", "BiometryDataText", c => c.String(nullable: false));
            DropColumn("dbo.Usuarios", "BiometricData");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "BiometricData", c => c.Binary(nullable: false));
            DropColumn("dbo.Usuarios", "BiometryDataText");
            DropColumn("dbo.Usuarios", "BiometryDataBinary");
        }
    }
}
