using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            DateTime startTime = Process.GetCurrentProcess().StartTime;
            string path = Process.GetCurrentProcess().MainModule.FileName;
            string clientPath = Path.Combine(path.Substring(0, path.IndexOf("Server")), @"Client\bin\Debug\Client.exe");
            Process clientProcess = new Process();
            clientProcess.StartInfo.FileName = clientPath;

            //Create a pipe for server
            AnonymousPipeServerStream serverPipe = new AnonymousPipeServerStream(PipeDirection.Out,HandleInheritability.Inheritable);
            clientProcess.StartInfo.Arguments = serverPipe.GetClientHandleAsString();
            try
            {
                clientProcess.StartInfo.UseShellExecute = false;
                clientProcess.Start();
                StreamWriter writer = new StreamWriter(serverPipe);
                writer.WriteLine("Hi from server");
                writer.Flush();
                do
                {
                    if ((DateTime.Now.Second - startTime.Second) % (5*counter) == 0)
                    {
                        counter++;
                        writer.WriteLine($"Server is alive {DateTime.Now.Second - startTime.Second}");
                        writer.Flush();
                    }
                }
                while((DateTime.Now.Second - startTime.Second) <= 30);
                clientProcess.Kill();
                clientProcess.Close();
                Console.WriteLine("Server : Client process is dead");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
