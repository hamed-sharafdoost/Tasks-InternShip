using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task2.FirstQuestion
{
    public class Email : INotification
    {
        public void Inform()
        {
            Console.WriteLine("hi");
            Console.WriteLine("The Email is used in this company");
            return;
        }
    }
}
