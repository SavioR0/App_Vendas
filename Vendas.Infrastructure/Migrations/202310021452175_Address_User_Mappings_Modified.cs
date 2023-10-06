namespace Vendas.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Address_User_Mappings_Modified : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Endereços", "CEP", c => c.String(nullable: false, maxLength: 9));
            AlterColumn("dbo.Endereços", "City", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Endereços", "Neighborhood", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Endereços", "Street", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Endereços", "Street", c => c.String());
            AlterColumn("dbo.Endereços", "Neighborhood", c => c.String());
            AlterColumn("dbo.Endereços", "City", c => c.String());
            AlterColumn("dbo.Endereços", "CEP", c => c.String());
        }
    }
}
