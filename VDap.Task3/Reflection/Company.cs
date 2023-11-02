using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task3.Reflection
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
        public void GetName()
        {
            Console.WriteLine("The name of company is :"+Name);
        }
        public string GetAddress()
        {
            return Address;
        }
    }
}
