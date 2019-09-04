using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesCarTruckLibrary {
    public class Vehicle {

        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
        public decimal Price { get; set; }

        public string Print() {
            return $"{Vin} {Make} {Model} {Trim} {Price}";
        } 

        public Vehicle (string vin, string make, string model, string trim, decimal price) {
            Vin = vin;
            Make = make;
            Model = model;
            Trim = trim;
            Price = price;
        }
    }
}
