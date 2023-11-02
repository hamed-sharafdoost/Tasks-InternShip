using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VDap.Task3.AsynchronousProgramming
{
    public static class Sample
    {
        private static int randomNumber;
        public static async Task SlowFunctionAsync()
        {
            randomNumber = new Random().Next();
            await Task.Delay(10000);
            Console.WriteLine("Slow function finished.");
        }
        public static void FastFunction()
        {
            Console.WriteLine($"Random number is {randomNumber}");
        }
    }
}
