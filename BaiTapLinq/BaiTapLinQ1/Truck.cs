using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLinq
{
    internal class Truck : Vehicle
    {
        public Truck()
        {

        }

        public Truck(string name, string rangeOfVehicle, double price, int yearOfManufacture, string manufacture) : base(name, rangeOfVehicle, price, yearOfManufacture, manufacture)
        {

        }
    }
}
