using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task3.GenericCollections
{
    public class SortedList_Students
    {
        SortedList<string,double> students;
        public SortedList_Students()
        {
            students = new SortedList<string,double>();
        }
        public void Add(string name,double grade)
        {
            students.Add(name, grade);
        }
        public void ShowTop3()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(students.Keys[i] + "got : " + students.Values[i]);
            }
        }
    }
}
