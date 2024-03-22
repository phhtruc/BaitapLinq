using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLinq.BaiTapLinQ2
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static List<Department> GetDepartments()
        {
            return new List<Department>()
            {
                new Department{Id = 1, Name = "IT"},
                new Department{Id = 2, Name = "Marketing"},
                new Department{Id = 3, Name = "Manager"}
            };
        }
            
    }
}
