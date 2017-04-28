namespace Events.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.String(name: "Customer ID", nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        EmailID = c.String(maxLength: 128),
                        EventName = c.String(name: "Event Name"),
                        Price = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Quantity = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.EventID)
                .ForeignKey("dbo.Customers", t => t.EmailID)
                .Index(t => t.EmailID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "EmailID", "dbo.Customers");
            DropIndex("dbo.Events", new[] { "EmailID" });
            DropTable("dbo.Events");
            DropTable("dbo.Customers");
        }
    }
}
