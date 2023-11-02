using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task3.GenericCollections
{
    public class HashSet_Students
    {
        HashSet<string> class1;
        HashSet<string> class2;
        public HashSet_Students(string[] lessons1,string[] lessons2)
        {
            class1 = new HashSet<string>(lessons1);
            class2 = new HashSet<string>(lessons2);
        }
        public void ShowCommonLessons()
        {
            foreach(var i in class1.Intersect(class2))
            {
                Console.WriteLine(i);
            }
        }
    }
}
