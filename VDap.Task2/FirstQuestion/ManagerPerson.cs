using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task2.FirstQuestion
{
    public class ManagerPerson : Person
    {
        private int NumberOfEmployees { get; set; }
        public ManagerPerson(string Name)
        {
            this.Name = Name;
            Position = "Manager";
        }
        public void DisplayNumberOfEmployees()
        {
            Console.WriteLine($"The manager has {NumberOfEmployees} employees");
            return;
        }
        ~ManagerPerson()
        {
            Console.WriteLine($"The name of manager is : {Name} and his/her position is : {Position}");
        }
    }
}
