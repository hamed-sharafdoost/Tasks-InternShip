using System;

namespace VDap.Task1.FirstQuestion
{
    public class CompareVariables
    {
        public static void Compare()
        {
            //Check equality of two value types
            int number1 = 5;
            int number2 = 5;
            Console.WriteLine($"Equality of number1 and number2 :{number1 == number2}");

            //Check equality of two Reference types
            IntegerNumber number3 = new IntegerNumber(6);
            IntegerNumber number4 = new IntegerNumber(6);
            Console.WriteLine($"Equality of number3 and number4 :{number3.Equals(number4)}");

            //Check equality when number6 is assigned by number5
            IntegerNumber number5 = new IntegerNumber(10);
            IntegerNumber number6 = number5;
            Console.WriteLine($"Equality of number5 and number6 : {number5.Equals(number6)}");
        }
        public unsafe static void Pointers()
        {
            int value = 200;
            int* pointer1 = &value;
            int** pointer2 = &pointer1;
            Console.WriteLine($"value of pointer1 : {*pointer1}");
            Console.WriteLine($"value of pointer2 :{**pointer2}");
            //Check addresses of pointers
            Console.WriteLine($"Address of variable which pointer1 is pointing to :{(int)pointer1}");
            Console.WriteLine($"Address of pointer which pointer2 is pointing to :{(int)*pointer2}");
        }
    }
    public class IntegerNumber
    {
        public int Number { get; set; }
        public IntegerNumber(int Number)
        {
            this.Number = Number;
        }
    }
}
