namespace Vendas.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(),
                        Cpf = c.String(nullable: false, maxLength: 11),
                        Tel = c.String(nullable: false, maxLength: 20),
                        DateOfBirth = c.DateTime(nullable: false),
                        AddressId = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 50),
                        TypeUser = c.Int(nullable: false),
                        UserName = c.String(),
                        EditLogin = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Endereços", t => t.AddressId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Endereços",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CEP = c.String(),
                        City = c.String(),
                        Neighborhood = c.String(),
                        Street = c.String(),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sale",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        SellerId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.ClientId)
                .ForeignKey("dbo.Produtos", t => t.ProductId)
                .ForeignKey("dbo.Usuarios", t => t.SellerId)
                .ForeignKey("dbo.Usuarios", t => t.User_Id)
                .Index(t => t.ProductId)
                .Index(t => t.SellerId)
                .Index(t => t.ClientId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Value = c.Double(nullable: false),
                        Description = c.String(nullable: false, maxLength: 100),
                        Stock = c.Int(nullable: false),
                        SellerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.SellerId)
                .Index(t => t.SellerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sale", "User_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Sale", "SellerId", "dbo.Usuarios");
            DropForeignKey("dbo.Sale", "ProductId", "dbo.Produtos");
            DropForeignKey("dbo.Produtos", "SellerId", "dbo.Usuarios");
            DropForeignKey("dbo.Sale", "ClientId", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "AddressId", "dbo.Endereços");
            DropIndex("dbo.Produtos", new[] { "SellerId" });
            DropIndex("dbo.Sale", new[] { "User_Id" });
            DropIndex("dbo.Sale", new[] { "ClientId" });
            DropIndex("dbo.Sale", new[] { "SellerId" });
            DropIndex("dbo.Sale", new[] { "ProductId" });
            DropIndex("dbo.Usuarios", new[] { "AddressId" });
            DropTable("dbo.Produtos");
            DropTable("dbo.Sale");
            DropTable("dbo.Endereços");
            DropTable("dbo.Usuarios");
        }
    }
}
