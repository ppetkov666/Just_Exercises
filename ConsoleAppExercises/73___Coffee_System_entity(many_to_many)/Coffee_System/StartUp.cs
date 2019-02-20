namespace Coffee_System
{
    using Coffee_System.Data;
    using Microsoft.EntityFrameworkCore;
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (CoffeeDbContext db = new CoffeeDbContext())
            {
                //
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                //db.Database.Migrate();
                //SeedData(db);
            }
        }

        private static void SeedData(CoffeeDbContext db)
        {
            // this method will automaticaly update every change on db 

            int totalUsers = 15;
            DateTime currrentDate = DateTime.Now;
            for (int i = 0; i < totalUsers; i++)
            {
                db.Users.Add(new User
                {
                    Name = $" Student - s{i}",
                    RegistrationDate = currrentDate.AddDays(i)
                });
            }
            db.SaveChanges();
            int totalDrinks = 10;
            for (int i = 0; i < totalDrinks; i++)
            {
                db.Drinks.Add(new Drink
                {
                    Name = $"drink type - {i}",
                    Price = 10 * i
                });
            }

            var random = new Random();
            //
            for (int i = 0; i < totalDrinks; i++)
            {

            }

        }
    }
}
