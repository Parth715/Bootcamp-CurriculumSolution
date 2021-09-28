using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Curriculum
{
    class Topic
    {
        private static int NextId { get; set; } = 5;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Difficulty { get; set; }

        public void Print()
        {
            Console.WriteLine($"Id: {Id} | Name: {Name} | Category: {Category} | Difficulty: {Difficulty}");
        }
        public Topic()
        {
            this.Id = NextId++;
        }
    }
}
