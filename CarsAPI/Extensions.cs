using CarsAPI.Models;
using System.Runtime.CompilerServices;

namespace CarsAPI
{
    public static class Extensions
    {
        public static CarDTO AsDTO(this Car car)
        {
            return new CarDTO(car.Id, car.Name, car.Description, car.Created);
        }
    }
}
