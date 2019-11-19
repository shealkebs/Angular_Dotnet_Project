namespace ClientDetailsWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientAddresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        ClientLocation = c.String(),
                        ClientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.ClientInformations", t => t.ClientID, cascadeDelete: true)
                .Index(t => t.ClientID);
            
            CreateTable(
                "dbo.ClientInformations",
                c => new
                    {
                        ClientID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClientID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientAddresses", "ClientID", "dbo.ClientInformations");
            DropIndex("dbo.ClientAddresses", new[] { "ClientID" });
            DropTable("dbo.ClientInformations");
            DropTable("dbo.ClientAddresses");
        }
    }
}
