using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Carlot
    {
        public List<Car> Cars { get; set; }

        public Carlot()
        {
            Cars = new List<Car>();
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

    }
    }

}
}
