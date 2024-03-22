using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLinq.BaiTapLinQ2
{
    class MainLinq2
    {
        static void Main(string[] args)
        {
            List<Department> departments = Department.GetDepartments();
            List<Employee> employees = Employee.GetEmployees();
            List<Position> positions = Position.GetPositions();

            Console.Write("Enter search keywords: ");
            var keyword = Console.ReadLine().ToString().ToLower();

            Console.Write("\nAge From: ");
            var ageFrom = Int32.Parse(Console.ReadLine());

            Console.Write("\nAge: ");
            var age = Int32.Parse(Console.ReadLine());

            Console.Write("\nPosition: ");
            var position = Console.ReadLine().ToString().ToLower();

            Console.Write("\nDipartment: ");
            var department = Console.ReadLine().ToString().ToLower();

            var resultPosition = positions.Where(i => i.Title.ToLower().Equals(position)).ToList();

            var resultDepartment = departments.Where(i => i.Name.ToLower().Equals(department)).ToList();

            var results = from emp in employees
                          from pt in resultPosition
                          from dp in resultDepartment
                          where (emp.Name.ToLower().Contains(keyword) || pt.Title.ToLower().Contains(keyword) || dp.Name.ToLower().Contains(keyword))
                                && ageFrom <= ((DateTime.Now - emp.Birthday).Days) / 365
                                && age >= ((DateTime.Now - emp.Birthday).Days) / 365
                                && emp.PositionId == pt.Id
                                && emp.DepartmentId == dp.Id
                          select new
                          {
                              name = emp.Name,
                              Age = (DateTime.Now - emp.Birthday).Days / 365,
                              Position = pt.Title,
                              Department = dp.Name
                          };


            if (results.Count() == 0)
            {
                Console.WriteLine("\n-------------------------------");
                Console.Write("No data found");
            }
            else
            {
                Console.WriteLine("\n-------------------------------");
                Console.WriteLine("Search results");
                foreach (var result in results)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3} ", result.name, result.Age, result.Position, result.Department);
                }
            }

            Console.ReadKey();
        }
    }
}
