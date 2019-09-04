using System;
using System.Collections.Generic;
using VehiclesCarTruckLibrary;

namespace VehiclesCarTruck {

    class Program {

        void Run() {

            var vehicles = new List<Vehicle>();
            //public Car (string vin, string make, string model, string trim, decimal price, bool convertible, bool hatchback, bool hybrid)
            //var cr1 = new Car("Vin: 12345", "Toyota", "Carolla", "", 1200, true, true, false);
            //var cr2 = new Car("Vin: 22345", "Honda", "Accord", "", 1800, true, false, false);
            //var cr3 = new Car("Vin: 32345", "Jaguar", "F-Pace", "", 4200, false, false, true);
            //Console.WriteLine(cr3.Print());
            vehicles.Add(new Car("12345", "Toyota", "Carolla", "Trim", 1200, true, true, false));
            vehicles.Add(new Car("22345", "Honda", "Accord", "Trim", 1800, true, false, false));
            vehicles.Add(new Car("32345", "Jaguar", "F-Pace", "Trim", 4200, false, false,true));
            vehicles.Add(new Truck("42345", "Chevrolet", "Taho", "Trim", 1200, true, true, ""));
            vehicles.Add(new Truck("52345", "Nissan", "Pathfinder", "Trim", 2200, true, false, ""));
            vehicles.Add(new Truck("62345", "Ford", "F-150", "Trim", 3200, true, false, ""));

            foreach (var vehicle in vehicles) {
                Console.WriteLine(vehicle.Print());
            }

            //public Truck (string vin, string make, string model, string trim, decimal price, bool cap, bool diesel, string bedside) 
            //var trk1 = new Truck("Vin: 42345", "Chevrolet", "Taho", "", 1200, false, true, "Bedside");
            //var trk2 = new Truck("Vin: 52345", "Nissan", "Pathfinder", "", 2200, true, true, "No Besdside");
            //var trk3 = new Truck("Vin: 62345", "Ford", "F-150", "", 3200, true, false, "Bedside");
            //Console.WriteLine(trk2.Print());

            //var vehicles = new List<Vehicles>() { cr1, cr2, cr3, trk1, trk2, trk3 };
            //foreach (var vehic in vehicles) {
            //    Console.WriteLine(vehic.Print());
            //}
        }
        static void Main(string[] args) {
            
        }
    }
}
