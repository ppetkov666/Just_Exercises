namespace Coffee_System.Data
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class CoffeeDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Drink> Drinks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=DESKTOP-FCG26GG\\SQLEXPRESS;Database=CoffeeDbCodeFirst;Integrated Security=True;");
            base.OnConfiguring(builder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);

            builder.Entity<UserDrink>()
                   .HasKey(ud => new { ud.UserId, ud.DrinkId });

            builder.Entity<User>()
                   .HasMany(u => u.Drinks)
                   .WithOne(d => d.User)
                   .HasForeignKey(u => u.UserId);

            builder.Entity<Drink>()
                   .HasMany(u => u.Users)
                   .WithOne(d => d.Drink)
                   .HasForeignKey(u => u.DrinkId);
        }
    }
}
