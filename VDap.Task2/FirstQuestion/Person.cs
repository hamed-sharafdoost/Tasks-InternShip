using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task2.FirstQuestion
{
    public class Person
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public void DisplayName()
        {
            Console.WriteLine($"The name of {Position} is : {Name}");
            return;
        }
        public void WritePosition()
        {
            Console.WriteLine($"The Position of {Name} is : {Position}");
            return;
        }
    }
}
