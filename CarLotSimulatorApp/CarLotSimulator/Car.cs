using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        private string v1;
        private string v2;
        private int v3;

        public Car()
        {
        }

        public Car(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public string IsDriveAble { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(HonkNoise);
        }
    }
}

