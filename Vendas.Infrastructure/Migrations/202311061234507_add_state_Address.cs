namespace Vendas.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_state_Address : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Endereços", "State", c => c.String());
            AddColumn("dbo.Endereços", "District", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Endereços", "Neighborhood");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Endereços", "Neighborhood", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Endereços", "District");
            DropColumn("dbo.Endereços", "State");
        }
    }
}
