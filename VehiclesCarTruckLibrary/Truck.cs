using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesCarTruckLibrary {
    public class Truck : Vehicle {

        public bool Cap { get; set; } = true;
        public bool Diesel { get; set; } = true;
        public string Bedside { get; set; }


        // return $"{this.GetType().Name}:: Name: {EmployeeName}, Job: {JobTitle}, Salary: {Salary.ToString("C")}";
        public new string Print() {
            var cap = Cap ? "Cap" : "";
            var diesel = Diesel ? "Diesel" : "";
            return base.Print() + $"{cap} {diesel} {Bedside}";
        }

        public Truck (string vin, string make, string model, string trim, decimal price, bool cap, bool diesel, string bedside) 
            : base(vin, make, model, trim, price) {
            Cap = cap;
            Diesel = diesel;
            Bedside = bedside;

        }
    }
}
