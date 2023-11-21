using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public string Color { get ; set ; }
        public string Engine { get ; set ; }
        public string Model { get; set; }
        public int NumberOfSeats { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }    
        public bool IsConvertible { get; set; }
        public int TrunkSize { get; set; }
        public bool UsesFuel { get; set; }
    }
}
