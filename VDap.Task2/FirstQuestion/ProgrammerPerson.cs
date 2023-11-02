using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task2.FirstQuestion
{
    public class ProgrammerPerson : Person
    {
        public string NameOfManager { get; set; }
        public ProgrammerPerson(string Name)
        {
            this.Name = Name;
            this.Position = "Position";
        }
        public void DisplayManagerName()
        {
            Console.WriteLine($"The name of manager is :{NameOfManager}");
            return;
        }
        ~ProgrammerPerson()
        {
            Console.WriteLine($"The name of programmer is : {Name} and his/her position is : {Position}");
        }
    }
}
