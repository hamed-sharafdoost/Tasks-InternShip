using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task1.EighthQuestion
{
    public class NullableType
    {
        public string Name = null;
        public string? Name2 = "Hamed";

        public void CheckNull(string name1,string name2)
        {
            string NewName = name1 ?? name2;
            Console.WriteLine(NewName + " is not null");
        }
    }
}
