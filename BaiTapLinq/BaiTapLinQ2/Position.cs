using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLinq.BaiTapLinQ2
{
    class Position
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Position()
        {

        }

        public Position(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public static List<Position> GetPositions()
        {
            return new List<Position>()
            {
                new Position{Id = 1, Title = "Developer"},
                new Position{Id = 2, Title = "Tester"},
                new Position{Id = 3, Title = "QA"}
            };
        }
    }
}
