using AutoMapper;
using Car_Rental_Project.Data;
using Car_Rental_Project.Dto_s;
using Car_Rental_Project.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Car_Rental_Project.Controllers.Api
{
    public class CarsController : ApiController
    {

        private CarDbContext _context;
        public CarsController()
        {

            _context = new CarDbContext();
        }

        //  GET/Api/Cars
        [HttpGet]
        public IHttpActionResult GetAllCars()
        {
            Request.CreateResponse<IEnumerable<CarDto>>(HttpStatusCode.OK, _context.Cars.ToList().Select(Mapper.Map<Car, CarDto>));
            return Ok(_context.Cars.ToList().Select(Mapper.Map<Car, CarDto>)); 
        }

        //  GET/Api/Cars/1
        [HttpGet]
        public IHttpActionResult GetCarById(int id)
        {
            Car car = _context.Cars.SingleOrDefault(c => c.Id == id);
            if (car == null)
            {
                NotFound();
            }

            return Ok(Mapper.Map<Car, CarDto>(car));
        }
        [HttpPost]
        // api/cars/
        public IHttpActionResult CreateCar(CarDto carDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Car car = Mapper.Map<CarDto, Car>(carDto);
            _context.Cars.Add(car);
            _context.SaveChanges();
            carDto.Id = car.Id;
            // we return URI - unified resourse identifier
            return Created(new Uri(Request.RequestUri + "/" + car.Id), carDto);
        }

        //put api/cars/1
        [HttpPut]
        public void UpdateCustomer(int id, CarDto carDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            Car carIntoDb = _context.Cars.SingleOrDefault(c => c.Id == id);
            if (carIntoDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            Mapper.Map<CarDto, Car>(carDto, carIntoDb);
            _context.SaveChanges();

        }
        [HttpDelete]
        public void DeleteCar(int id)
        {
            Car carIntoDb = _context.Cars.SingleOrDefault(c => c.Id == id);
            if (carIntoDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            _context.Cars.Remove(carIntoDb);
            _context.SaveChanges();
        }
    }
}
