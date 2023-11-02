using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task3.Events_Delegates
{
    public delegate bool Compare(Point point1,Point point2);
    public class Point
    {
        public double X;
        public double Y;
        public bool IsGreater(Compare compare,Point point2)
        {
            return compare(this, point2);
        }
    }
}
