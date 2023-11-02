using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task2.FirstQuestion
{
    public class EmployeePerson : Person
    {
        public string NameOfManager { get; set; }
        public EmployeePerson(string Name)
        {
            this.Name = Name;
            this.Position = "Employee";
        }
        public void DisplayManagerName()
        {
            Console.WriteLine($"The name of manager is :{NameOfManager}");
            return;
        }
        ~EmployeePerson()
        {
            Console.WriteLine($"The name of employee is : {Name} and his/her position is : {Position}");
        }
    }
}
