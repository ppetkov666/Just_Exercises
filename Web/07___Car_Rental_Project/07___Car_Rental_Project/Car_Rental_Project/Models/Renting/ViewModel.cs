namespace Car_Rental_Project.Models.Renting
{
    using System.Collections.Generic;
    
    public class ViewModel
    {
        public List<UserRentingModel> Cars { get; set; }

        public readonly string UserRoleAdmin = "CanDeleteRentedTableRecords";

    }
}