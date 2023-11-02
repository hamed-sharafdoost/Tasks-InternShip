using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task1.SeventhQuestion
{
    public class Number
    {
        public int number1 = 5;
        public int number2 = 10;
        public int number3;
        public static void Increment(int num1,ref int num2,out int num3)
        {
            num1++;
            num2++;
            num3 = 50;
        }
        public static void DisplayNumbers(int num1,int num2,int num3)
        {
            Console.WriteLine($"number1 after calling Increment function :{num1}");
            Console.WriteLine($"number2 after calling Increment function :{num2}");
            Console.WriteLine($"number3 after calling Increment function :{num3}");
        }
    }
}
