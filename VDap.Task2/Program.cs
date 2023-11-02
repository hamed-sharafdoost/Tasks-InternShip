using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDap.Task2.FirstQuestion;
using VDap.Task2.SecondQuestion;
using VDap.Task2.ThirdQuestion;

namespace VDap.Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*First question*/
            ManagerPerson manager = new ManagerPerson("Negar");
            EmployeePerson employee = new EmployeePerson("Ahmad");
            ProgrammerPerson programmer = new ProgrammerPerson("Saman");
            manager.WritePosition();
            employee.WritePosition();
            programmer.WritePosition();

            /*second question */
            bool check = true;
            while (check)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Enter Number1 :");
                string num1 = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Enter Number2 :");
                string num2 = Console.ReadLine() ?? string.Empty;
                if (num1 != String.Empty && num2 != String.Empty)
                {
                    HugeInteger int1 = new HugeInteger(num1);
                    HugeInteger int2 = new HugeInteger(num2);
                    Console.WriteLine("Check Equality :" + int1.Equals(int2));
                    Console.WriteLine("Check if int1 is greater than int2 :" + int1.IsGreaterThan(int2));
                    Console.WriteLine("Check if int1 is smaller than int2 :" + int1.IsLessThan(int2));
                    Console.WriteLine("Number1 + Number2 : ");
                    foreach (var i in int1.Add(int2))
                        Console.Write(i);
                    Console.WriteLine();
                    Console.WriteLine("Number1 - Number2 :");
                    foreach (var i in int1.Subtract(int2))
                        Console.Write(i);
                }
                else
                    check = false;
                Console.WriteLine();
            }
        }
    }
}
