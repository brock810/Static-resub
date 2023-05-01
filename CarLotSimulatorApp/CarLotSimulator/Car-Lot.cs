using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    class Car_Lot
    {

        public static int numberOfCars = 0;
        List<Car> Cars { get; set; } = new List<Car>();

        public Car_Lot()
        {
            Cars = new List<Car>();
        }
        public void AddCar(Car car)
        {
            Cars.Add(car);
            numberOfCars++;
            Console.WriteLine($"Number of cars in the lot: {numberOfCars}");
        }
    }
}

    

