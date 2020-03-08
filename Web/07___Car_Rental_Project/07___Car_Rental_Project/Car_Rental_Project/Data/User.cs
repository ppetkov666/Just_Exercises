namespace Car_Rental_Project.Data
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    

    public class User : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string DrivingLicense { get; set; }
        public User()
        {
            this.Cars = new HashSet<Car>();
            this.Rentings = new HashSet<Renting>();
        }
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<Renting> Rentings { get; set; }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }

    
}