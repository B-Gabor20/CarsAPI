using CarsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarsAPI.Controllers
{
    [Route("Cars")]
    [ApiController]
    public class CarController : ControllerBase
    {
        [HttpGet]
        public ActionResult<CarDTO> Get()
        {
            using (var context=new CarContext())
            {
                return Ok(context.Cars.ToList());
            }
        }
        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            using var context = new CarContext();
            {
                var result = context.Cars.Where(x => x.Id == id);
                return Ok(result.ToList());
            }
        }


        [HttpPost]
        public ActionResult<CarDTO> Post(CreateCarDTO car)
        {
            using (var context = new CarContext())
            {
                var request = new Car
                {
                    Id=Guid.NewGuid(),
                    Name=car.Name,
                    Description=car.Desc,
                    Created=DateTime.Now
                }; 
                context.Cars.Add(request);
                context.SaveChanges();

                return Ok(request.AsDTO());
            }
        }
        


    }
}
