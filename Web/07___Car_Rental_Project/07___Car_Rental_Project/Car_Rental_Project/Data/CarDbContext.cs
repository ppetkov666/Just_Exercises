
namespace Car_Rental_Project.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    // this is our gateway to the DataBase  
    public class CarDbContext : IdentityDbContext<User>
    {
        public CarDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public virtual IDbSet<Car> Cars { get; set; }

        public virtual IDbSet<Renting> Rentings { get; set; }

        public static CarDbContext Create()
        {
            return new CarDbContext();
        }
    }
}