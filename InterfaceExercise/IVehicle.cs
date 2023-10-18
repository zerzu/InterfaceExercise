using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public string Color { get; set; }
        public string Engine { get; set; }
        public string Model { get; set;}
        public int NumberOfSeats { get; set;}

    }
}
