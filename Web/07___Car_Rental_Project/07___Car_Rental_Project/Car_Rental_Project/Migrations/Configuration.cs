namespace Car_Rental_Project.Migrations
{
    using Car_Rental_Project.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Car_Rental_Project.Data.CarDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
            ContextKey = "Car_Rental_Project.Data.CarDbContext";
        }

        protected override void Seed(CarDbContext context)
        {
            if (context.Cars.Any())
            {
                return;
            }
            User user = context.Users.FirstOrDefault();
            if (user == null)
            {
                return;
            }
            context.Cars.Add(new Car
            {
                Make = "Bmw",
                Color = "black",
                Model = "650i",
                Year = 2012,
                Engine = 5.0,
                EngineType = EngineType.Gasoline,
                Power = 5000,
                PricePerDay = 200,
                ImageUrl = "https://hips.hearstapps.com/amv-prod-cad-assets.s3.amazonaws.com/vdat/submodels/bmw_m8-gran-coupe_bmw-concept-m8-gran-coupe_2018-1532968589970.jpg",
                OwnerId = user.Id
            });

        }
    }
}
