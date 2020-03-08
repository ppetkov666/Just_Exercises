namespace Car_Rental_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRentingRecord : DbMigration
    {
        public override void Up()
        {
            // this is direct way to comunicate with DB as pure SQL statements and after we just execute Update-Database in Package Manager
            Sql("iNSERT INTO Rentings (Days, TotalPrice, UserId, CarId, RentedOn) VALUES (6, 1200, '109c332f-d639-4f83-90d2-a488d23a0e82', 8, '10/01/2019 14:43:44')");
        }
        
        public override void Down()
        {

        }
    }
}
