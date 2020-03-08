

namespace Car_Rental_Project.Controllers
{
    using Antlr.Runtime.Misc;
    using Car_Rental_Project.Data;
    using Car_Rental_Project.Models.Cars;
    using Car_Rental_Project.Models.Renting;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Runtime.CompilerServices;
    using System.Web.Mvc;

    public class CarsController : Controller
    {
        // passing the data to the view as ViewData or ViewBag is not recommended
        // Car car = new Car();
        //ViewData["Car"] = car; 

        // when we pass the Car object to the view we basically do as it is shown below but using the View method there is no need of this extra code  
        // ViewResult viewResult = new ViewResult();
        //viewResult.ViewData.Model;

        private CarDbContext _context;
        public CarsController()
        {
            this._context = new CarDbContext();
        }

        public ActionResult All(int page = 1, string user = null, string search = null)
        {
            int pageZise = 5;
            IQueryable<Car> carsQuerie = _context.Cars.AsQueryable();

            if (search != null)
            {
                carsQuerie = carsQuerie.Where(c => c.Make.ToLower().Contains(search.ToLower()) ||
                                                   c.Model.ToLower().Contains(search.ToLower()));
            }

            if (user != null)
            {
                carsQuerie = carsQuerie.Where(c => c.Owner.Email == user);
            }

            List<ListCarModels> cars = carsQuerie
                .OrderByDescending(c => c.Id)
                .Skip((page - 1) * pageZise)
                .Take(pageZise)
                .Select(c => new ListCarModels
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    Year = c.Year,
                    ImageUrl = c.ImageUrl,
                    DailyPrice = c.PricePerDay,
                    IsRented = c.IsRented
                }).ToList();
            ViewBag.CurrentPage = page;
            return View(cars);
        }

        // if we want custom route we can use Route Attribute 
        //[Route("cars/created/{year}/{month:regex(\\d{2}):range(1,12)}/{day}")]
        
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [Authorize]
        [HttpPost]
        public ActionResult Create(CreateCarModel carmodel)
        {
            // this is mandatory step to validate the input

            // this is another option to add validationError message into ModelState
            //if (!ModelState.IsValid)
            //{
            //    if (ModelState.Keys.Contains("Year"))
            //    {
            //        //ModelState.Remove("Year");
            //        ModelState.AddModelError("Name", $"Enter a value between 1990 and {DateTime.Now.Year}!");
            //    }
            //}

            if (carmodel != null && this.ModelState.IsValid)
            {
                // it give us the Id of the currect logged user
                string ownerId = User.Identity.GetUserId();
                Car car = new Car();
                car.Make = carmodel.Make;
                car.Color = carmodel.Color;
                car.Model = carmodel.Model;
                car.Year = carmodel.Year;
                car.Engine = carmodel.Engine;
                car.EngineType = carmodel.EngineType;
                car.Power = carmodel.Power;
                car.PricePerDay = carmodel.PricePerDay;
                car.ImageUrl = carmodel.ImageUrl;
                car.OwnerId = ownerId;
                
                _context.Cars.Add(car);
                // the SaveChanges() method basically it is wrapped in transaction so it is "all or nothing"
                // either will be saved to DB  or Not and transaction will be rollback
                _context.SaveChanges();
                // car.Id is set automatically because of entity framework(this is primary key with identity option in DB)
                return RedirectToAction("Details", new { id = car.Id });
            }
            return View();
        }
        public ActionResult Details(int id)
        {
            CarModelDetails car = _context
               .Cars
               .Where(c => c.Id == id)
               .Select(c => new CarModelDetails
               {
                   Id = c.Id,
                   Make = c.Make,
                   Model = c.Model,
                   Year = c.Year,
                   Power = c.Power,
                   Engine = c.Engine,
                   EngineType = c.EngineType,
                   Color = c.Color,
                   PricePerDay = c.PricePerDay,
                   ImageUrl = c.ImageUrl,
                   ContactInfo = c.Owner.Email,
                   IsRented = c.IsRented,
                   TotalRents = c.Rentings.Count()
               })
               .FirstOrDefault();
            if (car == null)
            {
                HttpNotFound();
            }

            return View(car);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Rent(RentCarModel rentCarModel)
        {
            if (rentCarModel.Days < 1 || rentCarModel.Days > 15)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dynamic car = _context
                .Cars
                .Where(c => c.Id == rentCarModel.CarId)
                .Select(c => new
                {
                    c.IsRented,
                    FullName = c.Make + " " + c.Model + " (" + c.Year + ")",
                    c.ImageUrl,
                    c.PricePerDay
                })
                .FirstOrDefault();
            if (car == null || car.IsRented)
            {
                HttpNotFound();
            }
            rentCarModel.CarName = car.FullName;
            rentCarModel.CarImageUrl = car.ImageUrl;
            rentCarModel.PricePerDay = car.PricePerDay;
            rentCarModel.TotalPrice = car.PricePerDay * rentCarModel.Days;

            return View(rentCarModel);
        }
        [Authorize]
        [HttpPost]
        public ActionResult Rent(int carId, int days)
        {
            var car = _context
                .Cars
                .Where(c => c.Id == carId)
                .FirstOrDefault();
            string userId = this.User.Identity.GetUserId();
            if (car == null || car.IsRented || car.OwnerId == userId)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Renting renting = new Renting
            {
                CarId = carId,
                Days = days,
                RentedOn = DateTime.Now,
                UserId = userId,
                TotalPrice = days * car.PricePerDay
            };

            car.IsRented = true;
            _context.Rentings.Add(renting);
            _context.SaveChanges();
            return RedirectToAction("Details", new { id = car.Id });
        }

        [Authorize]
        [HttpGet]
        public ActionResult Delete(int id)
        {
            using (_context)
            {
                Car car = _context.Cars.Where(a => a.Id == id).FirstOrDefault();

                if (car == null || car.Owner.Email != this.User.Identity.Name)
                {
                    HttpNotFound();
                }
                return View(car);
            }
        }

        [Authorize]
        [ActionName(name: "Delete")]
        [HttpPost]
        public ActionResult ConfirmDelete(int id)
        {
            using (_context)
            {
                var car = _context.Cars.Where(a => a.Id == id).FirstOrDefault();

                if (car == null || car.Owner.Email != this.User.Identity.Name)
                {
                    HttpNotFound();
                }
                _context.Cars.Remove(car);
                _context.SaveChanges();
                return RedirectToAction("All");
            }
        }

        [Authorize]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (_context)
            {
                Car car = _context.Cars.Find(id);

                if (car == null || car.Owner.Email != this.User.Identity.Name)
                {
                    HttpNotFound();
                }

                CarEditDetails ced = new CarEditDetails();

                ced.Id = car.Id;
                ced.Make = car.Make;
                ced.Model = car.Model;
                ced.Color = car.Color;
                ced.Year = car.Year;
                ced.Power = car.Power;
                ced.Engine = car.Engine;
                ced.EngineType = car.EngineType;
                ced.PricePerDay = car.PricePerDay;
                ced.ImageUrl = car.ImageUrl;
                ced.OwnerId = car.OwnerId;
                return View(ced);
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult Edit(CarEditDetails vehicleData)
        {
            if (vehicleData != null && this.ModelState.IsValid)
            {
                using (_context)
                {
                    Car car = _context.Cars.Find(vehicleData.Id);

                    if (car == null || car.Owner.Email != this.User.Identity.Name)
                    {
                        HttpNotFound();
                    }
                    car.Make = vehicleData.Make;
                    car.Model = vehicleData.Model;
                    car.Color = vehicleData.Color;
                    car.Year = vehicleData.Year;
                    car.Power = vehicleData.Power;
                    car.Engine = vehicleData.Engine;
                    car.EngineType = vehicleData.EngineType;
                    car.PricePerDay = vehicleData.PricePerDay;
                    car.ImageUrl = vehicleData.ImageUrl;

                    _context.SaveChanges();
                }
                return RedirectToAction("Details", new { id = vehicleData.Id });
            }
            return View(vehicleData);
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}