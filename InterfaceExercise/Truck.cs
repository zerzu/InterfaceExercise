using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool IsFWD { get; set; }
        public string BedSize { get; set; }
        public string Color { get; set ; }
        public string Engine { get ; set; }
        public string Model { get; set; }
        public int NumberOfSeats { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public bool UsesFuel { get; set; }
    }
}
