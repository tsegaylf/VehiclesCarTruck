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


        //  Salary: {Salary.ToString("C")}";
        public virtual string Print() { 
            return $"Vin: {Vin,-8} {Make} {Model} {Trim} {Price.ToString("C")}";
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
