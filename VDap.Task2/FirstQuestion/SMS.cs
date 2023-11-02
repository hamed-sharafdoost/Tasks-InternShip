using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task2.FirstQuestion
{
    public class SMS : INotification
    {
        public void Inform()
        {
            Console.WriteLine("The SMS is used in this company");
            return;
        }
    }
}
