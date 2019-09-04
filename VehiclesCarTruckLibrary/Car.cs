using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesCarTruckLibrary {
    public class Car : Vehicle {

        public bool Convertible { get; set; } = true;
        public bool Hatchback { get; set; } = true;
        public bool Hybrid { get; set; } = true;

        public new string Print() {
            return base.Print() + $"{Convertible} {Hatchback} {Hybrid}";
        }

        public Car (string vin, string make, string model, string trim, decimal price, bool convertible, bool hatchback, bool hybrid) 
            : base(vin, make, model, trim, price) {
            Convertible = convertible;
            Hatchback = hatchback;
            Hybrid = hybrid;

        }
    }
}
