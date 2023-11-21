using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany !!DONE!!

            //Create 3 classes called Car , Truck , & SUV   !!DONE!!

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..       !!DONE!!
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }            !!DONE!!
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.  !!DONE!!
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;      !!DONE!!

            Car taurus = new Car();
            
            taurus.Color = "Red";
            taurus.Engine = "V6";
            taurus.Model = "Taurus";
            taurus.NumberOfSeats = 5;
            taurus.Logo = "None";
            taurus.Name = "Ford";
            taurus.IsConvertible = false;
            taurus.TrunkSize = 10;
            taurus.UsesFuel = true;

            Truck s10 = new Truck();

            s10.Color = "Orange";
            s10.Engine = "V6";
            s10.Model = "S10";
            s10.NumberOfSeats = 2;
            s10.Logo = "None";
            s10.Name = "Ford";
            s10.IsFWD = true;
            s10.BedSize = "Short";
            s10.UsesFuel = true;

            SUV durango = new SUV();

            durango.Color = "Blue";
            durango.Engine = "V8";
            durango.Model = "Durango";
            durango.NumberOfSeats = 8;
            durango.Logo = "None";
            durango.Name = "Dodge";
            durango.HasThirdRow = true;
            durango.IsCrossover = true;
            durango.UsesFuel = false;

            //Creatively display and organize their values  !!DONE!!

            var parkingLot = new List<IVehicle>() { taurus, s10, durango };

            foreach (var vehicle in parkingLot)                
                {
                    if (vehicle is Car)
                    {
                        Console.WriteLine($"This Car is a {vehicle.Color} {vehicle.Engine} {vehicle.Model} {vehicle.FuelType(vehicle.UsesFuel)}");                        
                    }
                    else if (vehicle is Truck)
                    {
                        Console.WriteLine($"This Truck is a {vehicle.Color} {vehicle.Engine} {vehicle.Model} {vehicle.FuelType(vehicle.UsesFuel)}");
                }
                    else if (vehicle is SUV)
                    {

                    Console.WriteLine($"This SUV is a {vehicle.Color} {vehicle.Engine} {vehicle.Model} {vehicle.FuelType(vehicle.UsesFuel)}");

                }

                    
                }

        }
    }
}
