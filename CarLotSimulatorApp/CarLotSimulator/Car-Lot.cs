using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
       public class Car
    {

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public Car(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }

        public static int numberOfCars = 0;
        List<Car> Cars { get; set; } = new List<Car>();

        public Car()
        {
            Cars = new List<Car>();
        }
        public void AddCar(Car car)
        {
            Cars.Add(car);
            numberOfCars++;
            Console.WriteLine($"Number of cars in the lot: {numberOfCars}");
        }


                public void MakeEngineNoise(string engineNoise)
                {
                    Console.WriteLine(engineNoise);
                }

                public void MakeHonkNoise(string honkNoise)
                {
                    Console.WriteLine(honkNoise);
                }
            }

        }
