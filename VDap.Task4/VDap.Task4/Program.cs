using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task4
{
    public class Program
    {
        private Book[] books;

        static void Main(string[] args)
        {
            int maxBooks = 1000;
            Program programObj = new Program();
            programObj.books = new Book[maxBooks];
            for (int i = 0; i < maxBooks; i++)
            {
                programObj.books[i] = new Book();
            }
            Console.WriteLine("Maximum generation : " + GC.MaxGeneration);
            programObj.books = null;
            Console.WriteLine("Generation of programObj is :" + GC.GetGeneration(programObj));
            Console.WriteLine("Total allocated memory is :" + GC.GetTotalMemory(false));
            GC.Collect(0);
            Console.WriteLine("Generation of programObj is :"+GC.GetGeneration(programObj));
            Console.WriteLine("Total allocated memory after cleaning gen0 : " + GC.GetTotalMemory(false));
            for(int i =0; i <= GC.MaxGeneration; i++)
                GC.Collect(i);
            Console.WriteLine("Generation of programObj after cleaning all memory generation :" + GC.GetGeneration(programObj));
            Console.WriteLine("Total allocated memory is :" + GC.GetTotalMemory(false));
            Console.Read();
        }
    }
    class Book
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Content { get; private set; } = "This is a book. Every book has a name and an Id.";
    }
}
