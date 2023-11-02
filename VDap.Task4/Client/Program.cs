using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string message = string.Empty;
                AnonymousPipeClientStream clientPipe = new AnonymousPipeClientStream(PipeDirection.In,args[0]);
                try
                {
                    StreamReader reader = new StreamReader(clientPipe);
                    do
                    {
                        Console.WriteLine("This is client program");
                        message = reader.ReadLine();
                        Console.WriteLine(message);
                    }
                    while (!message.StartsWith("Hi"));
                    while((message = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(message);
                    }
                }
                catch (Exception ex)
                { Debug.WriteLine(ex.Message); }
                Console.ReadKey();
            }
        }
    }
}
