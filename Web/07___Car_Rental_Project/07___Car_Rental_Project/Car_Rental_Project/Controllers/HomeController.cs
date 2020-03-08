using Car_Rental_Project.Data;
using Car_Rental_Project.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Car_Rental_Project.Controllers
{
    //[AllowAnonymous]
    public class HomeController : Controller
    {
        private CarDbContext _context;
        public HomeController()
        {
            _context = new CarDbContext();
        }
        public ActionResult Index()
        {
            List<ListCarModels> cars = _context
                .Cars
                .Where(m=>m.IsRented == false)
                .OrderByDescending(m => m.Id)
                .Select(m => new ListCarModels
                {
                    Id = m.Id,
                    Make = m.Make,
                    Model = m.Model,
                    Year = m.Year,
                    ImageUrl = m.ImageUrl,
                    DailyPrice = m.PricePerDay
                }).ToList();

            return View(cars);
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

    }
}