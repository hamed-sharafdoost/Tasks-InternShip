using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task1.TenthQuestion
{
    public class EnumType
    {
        [Flags]
        public enum DirectionFlag { North=0,East=1,South=2,West=4}
        public enum Direction{North,East,South,West }
        public static void DisplayDirections()
        {
            Console.WriteLine(((int)Direction.North) + " is assigned to north");
            Console.WriteLine(((int)Direction.East) + " is assigned to east");
            Console.WriteLine(((int)Direction.South) + " is assigned to south");
            Console.WriteLine(((int)Direction.West) + " is assigned to west");
        }
        public static void DisplayDirectionFlag()
        {
            DirectionFlag northeast = DirectionFlag.North | DirectionFlag.East;
            Console.WriteLine("Result of OR operator :" + ((int)northeast));
        }
    }
}
