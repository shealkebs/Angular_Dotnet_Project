namespace ClientDetailsWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCityColumnToAddressTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientAddresses", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClientAddresses", "City");
        }
    }
}
