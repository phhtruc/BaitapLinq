using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLinq.BaiTapLinQ2
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string name, DateTime birthday, decimal salary, int departmentId, int positionId)
        {
            Id = id;
            Name = name;
            Birthday = birthday;
            Salary = salary;
            DepartmentId = departmentId;
            PositionId = positionId;
        }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee{Id = 1, Name = "Nam", Birthday = new DateTime(1995, 8, 20), Salary = 60000, DepartmentId = 1, PositionId = 1 },
                new Employee{Id = 2, Name = "Linh", Birthday = new DateTime(1992, 4, 10), Salary = 55000, DepartmentId = 2, PositionId = 3 },
                new Employee{Id = 3, Name = "Minh", Birthday = new DateTime(1988, 10, 5), Salary = 70000, DepartmentId = 3, PositionId = 1 },
                new Employee{Id = 4, Name = "Hoa", Birthday = new DateTime(1987, 12, 15), Salary = 65000, DepartmentId = 3, PositionId = 2 },
                new Employee{Id = 5, Name = "Tuan", Birthday = new DateTime(1991, 3, 25), Salary = 62000, DepartmentId = 3, PositionId = 3 },
                new Employee{Id = 6, Name = "An", Birthday = new DateTime(1993, 7, 30), Salary = 58000, DepartmentId = 1, PositionId = 1 },
                new Employee{Id = 7, Name = "Quan", Birthday = new DateTime(1994, 9, 12), Salary = 59000, DepartmentId = 2, PositionId = 2 },
                new Employee{Id = 8, Name = "Trang", Birthday = new DateTime(1996, 5, 8), Salary = 63000, DepartmentId = 1, PositionId = 3 },
                new Employee{Id = 9, Name = "Hieu", Birthday = new DateTime(1990, 11, 18), Salary = 68000, DepartmentId = 3, PositionId = 1 },
                new Employee{Id = 10, Name = "Thao", Birthday = new DateTime(1989, 6, 22), Salary = 66000, DepartmentId = 1, PositionId = 2 }
            };
        }
    }
}
