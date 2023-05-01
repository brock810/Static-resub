using System;
using CarLotSimulator;
using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;

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

            var vehicle1 = new Car();
            vehicle1.Make = "Mustang";
            vehicle1.Model = "GT";
            vehicle1.Year = 2008;
            vehicle1.EngineNoise = "BAMMM";
            vehicle1.HonkNoise = "MEEEEEEMEEEEEEEEP";
            vehicle1.IsDriveAble = "Yes";

            var vehicle2 = new Car();
            vehicle2.Make = "RAM";
            vehicle2.Model = "four cab";
            vehicle2.Year = 1943;
            vehicle2.EngineNoise = "FlAMBOOSHKA";
            vehicle2.HonkNoise = "RORORORORRO";
            vehicle2.IsDriveAble = "False";

            var vehicle3 = new Car();
            vehicle3.Make = "Subaru";
            vehicle3.Model = "Impreza";
            vehicle3.Year = 2014;
            vehicle3.EngineNoise = "MEEWWWW";
            vehicle3.HonkNoise = "AHHHESHKA";
            vehicle3.IsDriveAble = "Yes";

            vehicle1.MakeEngineNoise(vehicle1.EngineNoise);
            vehicle1.MakeHonkNoise(vehicle1.HonkNoise);

            vehicle2.MakeEngineNoise(vehicle2.EngineNoise);
            vehicle2.MakeHonkNoise(vehicle2.HonkNoise);

            vehicle3.MakeEngineNoise(vehicle3.EngineNoise);
            vehicle3.MakeHonkNoise(vehicle3.HonkNoise);


            var carLot = new CarLot();
            carLot.Cars = new List<Car>();


            new Car("Mustang", "GT", 2008)
            {
                EngineNoise = "BAMMM",
                HonkNoise = "MEEEEEEMEEEEEEEEP",
                IsDriveAble = "Yes",
            };

            
            carLot.Cars.Add(vehicle1);

            
            new Car("RAM", "four cab", 1943)
            {
                EngineNoise = "FlAMBOOSHKA",
                HonkNoise = "RORORORORRO",
                IsDriveAble = "False"
            };

            
            carLot.Cars.Add(vehicle2);

          


            new Car("Subaru", "Impreza", 2014)
            {

            };
            vehicle3.EngineNoise = "MEEWWWW";
            vehicle3.HonkNoise = "AHHHESHKA";
            vehicle3.IsDriveAble = "Yes";

            
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
    }

    class CarLot
    {
        public List<Car> Cars { get; set; }
    }
}
