using System;
using CarLotSimulator;
using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
using static CarLotSimulator.Car;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can  3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            // the at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
          
            var carLot = new Car_Lot();
            carLot.Cars = new List<Car>();

            var vehicle1 = new Car
            {
                Make = "Mustang",
                Model = "GT",
                Year = 2008,
                EngineNoise = "BAMMM",
                HonkNoise = "MEEEEEEMEEEEEEEEP",
                IsDriveable = true
            };

            
            carLot.Cars.Add(vehicle1);

            var vehicle2 = new Car
            {
                Make = "RAM",
                Model = "four cab",
                Year = 1943,
                EngineNoise = "FlAMBOOSHKA",
                HonkNoise = "RORORORORRO",
                IsDriveable = false
            };

            
            carLot.Cars.Add(vehicle2);

            var vehicle3 = new Car
            {
                Make = "Subaru",
                Model = "Impreza",
                Year = 2014,
                EngineNoise = "MEEWWWW",
                HonkNoise = "AHHHESHKA",
                IsDriveable = true
            };

            
            carLot.Cars.Add(vehicle3);

            foreach (var car in carLot.Cars)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }

            vehicle1.MakeEngineNoise(vehicle1.EngineNoise);
            vehicle1.MakeHonkNoise(vehicle1.HonkNoise);

            vehicle2.MakeEngineNoise(vehicle2.EngineNoise);
            vehicle2.MakeHonkNoise(vehicle2.HonkNoise);

            vehicle3.MakeEngineNoise(vehicle3.EngineNoise);
            vehicle3.MakeHonkNoise(vehicle3.HonkNoise);

            Console.ReadLine();
        }
        class Car_Lot
        {
            public List<Car> Cars { get; set; }
        }
    }
}
    