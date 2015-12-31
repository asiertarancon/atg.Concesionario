namespace atg.Concesionario.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialScript : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Budgets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        State = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Customer_Id = c.Int(),
                        Vehicle_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.Vehicle_Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surnames = c.String(),
                        Telephone = c.String(),
                        Vip = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Model = c.String(),
                        Horsepower = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Budgets", "Vehicle_Id", "dbo.Vehicles");
            DropForeignKey("dbo.Budgets", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Budgets", new[] { "Vehicle_Id" });
            DropIndex("dbo.Budgets", new[] { "Customer_Id" });
            DropTable("dbo.Vehicles");
            DropTable("dbo.Customers");
            DropTable("dbo.Budgets");
        }
    }
}
