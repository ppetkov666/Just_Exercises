namespace Car_Rental_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDriverLicenseproperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DrivingLicense", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DrivingLicense");
        }
    }
}
