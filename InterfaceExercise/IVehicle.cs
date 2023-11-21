using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public string Color { get; set; }
        public string Engine { get; set; }
        public string Model { get; set; }
        public int NumberOfSeats { get; set; }
        public bool UsesFuel { get; set; }

        

        public string FuelType(bool UsesFuel)
        {
           switch (UsesFuel) 
            {

            case true: return "this baby uses gas!";                        
            case false: return "this thing doesn't use gas";               

            }
        }

    }
}
