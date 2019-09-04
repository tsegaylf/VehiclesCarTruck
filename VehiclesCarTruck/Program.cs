using System;
using System.Collections.Generic;
using VehiclesCarTruckLibrary;

namespace VehiclesCarTruck {
    class Program {
        private void Run() 
            {
            var vehicles = new List<Vehicle>();
   
            vehicles.Add(new Car("12345", "Toyota", "Carolla", "Trim", 1200, true, true, false));
            vehicles.Add(new Car("22345", "Honda", "Accord", "Trim", 1800, true, false, false));
            vehicles.Add(new Car("32345", "Jaguar", "F-Pace", "Trim", 4200, false, false, true));
            vehicles.Add(new Truck("42345", "Chevrolet", "Taho", "Trim", 1200, true, true, ""));
            vehicles.Add(new Truck("52345", "Nissan", "Pathfinder", "Trim", 2200, true, false, ""));
            vehicles.Add(new Truck("62345", "Ford", "F-150", "Trim", 3200, true, false, ""));

            foreach (var vehicle in vehicles) {
                Console.WriteLine(vehicle.Print());
            }
        }

        static void Main(string[] args) {
            (new Program()).Run();
        }
    }
}
