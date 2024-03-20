using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLinq
{
    internal class Car : Vehicle
    {
        public Car()
        {

        }

        public Car(string name, string rangeOfVehicle, double price, int yearOfManufacture, string manufacture) : base( name,  rangeOfVehicle,  price,  yearOfManufacture, manufacture)
        {

        }
    }
}
