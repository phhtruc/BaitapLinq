using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLinq
{
    internal class Vehicle
    {
        public string name { get; set; }
        public string rangeOfVehicle { get; set; }
        public double price { get; set; }
        public int yearOfManufacture { get; set; }
        public string manufacture { get; set; }
        public Vehicle()
        {

        }
        public Vehicle(string name, string rangeOfVehicle, double price, int yearOfManufacture, string manufacture)
        {
            this.name = name;
            this.rangeOfVehicle = rangeOfVehicle;
            this.price = price;
            this.yearOfManufacture = yearOfManufacture;
            this.manufacture = manufacture;
        }
    }
}
