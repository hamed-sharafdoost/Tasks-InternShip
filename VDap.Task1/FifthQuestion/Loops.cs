using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task1.FifthQuestion
{
    public class Loops
    {
        public static void ForLoop()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Square of {i} is :{i * i}");
            }
        }
        public static void WhileLoop(int limit)
        {
            int i = 0;
            while(i < limit)
            {
                if(i == 0 || i == 1)
                {
                    Console.WriteLine($"The sqaure of {i} is identical to {i}");
                    i++;
                    continue;
                }
                Console.WriteLine($"Square of {i} is :{i * i}");
                if(i == 6)
                {
                    Console.WriteLine("This loop is stoped when i = 6");
                    break;
                }
                i++;
            }
        }
        public static void DoWhileLoop()
        {
            int i = 1;
            do
            {
                Console.WriteLine("first execution");
                i *= 10;
            }
            while (i < 10);
        }
    }
}
