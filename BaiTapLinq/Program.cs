using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            // Add list cars
            cars.Add(new Car("Toyota Vios", "sedan", 200000, 1995, "Toyota"));
            cars.Add(new Car("Honda Civic", "sedan", 250000, 1988, "Honda"));
            cars.Add(new Car("Ford Mustang", "sports car", 500000, 2005, "Ford"));
            cars.Add(new Car("Chevrolet Camaro", "sports car", 450000, 2010, "Chevrolet"));
            cars.Add(new Car("BMW 3 Series", "sedan", 300000, 2008, "BMW"));
            cars.Add(new Car("Mercedes-Benz C-Class", "sedan", 240000, 2012, "Mercedes-Benz"));
            cars.Add(new Car("Audi A4", "sedan", 170000, 2015, "Audi"));
            cars.Add(new Car("Lamborghini Aventador", "super car", 100000, 1018, "Lamborghini"));
            cars.Add(new Car("Tesla Model S", "electric car", 700000, 1117, "Tesla"));
            cars.Add(new Car("Ferrari 488 GTB", "super car", 900000, 1019, "Ferrari"));

            List<Truck> trucks = new List<Truck>();
            // Add list trucks
            trucks.Add(new Truck("Toyota Tacoma", "pickup truck", 300000, 2020, "Toyota"));
            trucks.Add(new Truck("Ford F-150", "pickup truck", 35000, 2019, "Ford"));
            trucks.Add(new Truck("Chevrolet Silverado", "pickup truck", 250000, 1918, "Chevrolet"));
            trucks.Add(new Truck("Ram 1500", "pickup truck", 152000, 1900, "Ram"));
            trucks.Add(new Truck("GMC Sierra", "pickup truck", 380000, 2017, "GMC"));
            trucks.Add(new Truck("Nissan Titan", "pickup truck", 200000, 1990, "Nissan"));
            trucks.Add(new Truck("Honda Ridgeline", "pickup truck", 211000, 2015, "Honda"));
            trucks.Add(new Truck("Toyota Tundra", "pickup truck", 33000, 1981, "Toyota"));
            trucks.Add(new Truck("Ford Ranger", "pickup truck", 208000, 2013, "Ford"));
            trucks.Add(new Truck("Chevrolet Colorado", "pickup truck", 222000, 1888, "Chevrolet"));

            // displays cars priced between 100,000 and 200,000
            var priceCar = cars.Where(car => car.price >= 100000 && car.price <= 250000);

            // Vehicles with production year > 1990.
            var yearCar = cars.Where(car => car.yearOfManufacture > 1990);

            // Collect vehicles by manufacturer, calculate total value by group
            var sumGroupCar = cars.GroupBy(car => car.manufacture)
                .Select(group => new
                {
                    manufacture = group.Key,
                    totalPrice = group.Sum(car => car.price)
                });

            Console.WriteLine("Car");
            Console.WriteLine("Cars with price ranging from 100,000 to 200,000:");
            foreach (var car in priceCar)
            {
                Console.WriteLine($"Name: {car.name}, Price: {car.price}");
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Vehicles with production years before 1990:");
            foreach (var car in yearCar)
            {
                Console.WriteLine($"Name: {car.name}, Year Of Manufacture: {car.yearOfManufacture}");
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Total value of vehicles by manufacturer");
            foreach (var car in sumGroupCar)
            {
                Console.WriteLine($"{car.manufacture}: {car.totalPrice}");
            }


            //Truck
            Console.WriteLine("");
            Console.WriteLine("Truck");
            // Displays the list of Trucks in order of the latest year of manufacture
            var sortedTrucks = trucks.OrderByDescending(truck => truck.yearOfManufacture);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Name of the company that owns each truck:");
            foreach (var truck in sortedTrucks)
            {
                Console.WriteLine($"Truck: {truck.name}, Owner: {truck.yearOfManufacture}");
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Name of the company that owns each truck:");
            foreach (var truck in sortedTrucks)
            {
                Console.WriteLine($"Truck: {truck.name}, Owner: {truck.manufacture}");
            }

            Console.ReadKey();
        }
    }
}
