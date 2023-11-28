namespace Vendas.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Endereços",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CEP = c.String(nullable: false, maxLength: 9),
                        State = c.String(),
                        City = c.String(nullable: false, maxLength: 100),
                        District = c.String(nullable: false, maxLength: 100),
                        Street = c.String(nullable: false, maxLength: 100),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(maxLength: 100),
                        Cpf = c.String(maxLength: 11),
                        Tel = c.String(maxLength: 20),
                        DateOfBirth = c.DateTime(),
                        AddressId = c.Int(),
                        Email = c.String(maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 50),
                        TypeUser = c.Int(),
                        UserName = c.String(),
                        Flag = c.String(nullable: false),
                        EditLogin = c.Int(),
                        BiometryDataBinary = c.Binary(),
                        BiometryDataText = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Endereços", t => t.AddressId)
                .ForeignKey("dbo.TipoUsuarios", t => t.TypeUser)
                .Index(t => t.AddressId)
                .Index(t => t.TypeUser);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        Value = c.Double(nullable: false),
                        DateSale = c.DateTime(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.ClientId)
                .ForeignKey("dbo.Usuarios", t => t.User_Id)
                .Index(t => t.ClientId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SaleId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtos", t => t.ProductId)
                .ForeignKey("dbo.Vendas", t => t.SaleId)
                .Index(t => t.SaleId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Value = c.Double(nullable: false),
                        Description = c.String(nullable: false, maxLength: 100),
                        Stock = c.Int(nullable: false),
                        Flag = c.String(nullable: false),
                        SellerId = c.Int(nullable: false),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pedido", t => t.Order_Id)
                .ForeignKey("dbo.Usuarios", t => t.SellerId)
                .Index(t => t.SellerId)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.TipoUsuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "TypeUser", "dbo.TipoUsuarios");
            DropForeignKey("dbo.Vendas", "User_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Pedido", "SaleId", "dbo.Vendas");
            DropForeignKey("dbo.Pedido", "ProductId", "dbo.Produtos");
            DropForeignKey("dbo.Produtos", "SellerId", "dbo.Usuarios");
            DropForeignKey("dbo.Produtos", "Order_Id", "dbo.Pedido");
            DropForeignKey("dbo.Vendas", "ClientId", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "AddressId", "dbo.Endereços");
            DropIndex("dbo.Produtos", new[] { "Order_Id" });
            DropIndex("dbo.Produtos", new[] { "SellerId" });
            DropIndex("dbo.Pedido", new[] { "ProductId" });
            DropIndex("dbo.Pedido", new[] { "SaleId" });
            DropIndex("dbo.Vendas", new[] { "User_Id" });
            DropIndex("dbo.Vendas", new[] { "ClientId" });
            DropIndex("dbo.Usuarios", new[] { "TypeUser" });
            DropIndex("dbo.Usuarios", new[] { "AddressId" });
            DropTable("dbo.TipoUsuarios");
            DropTable("dbo.Produtos");
            DropTable("dbo.Pedido");
            DropTable("dbo.Vendas");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Endereços");
        }
    }
}
