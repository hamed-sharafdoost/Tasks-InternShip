using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task1.NinthQuestion
{
    public static class ArrayTest
    {
        public static int[,] TwoDimension = { { 1, 2, 3 }, { 4, 5, 6 }, { 6, 7, 8 } };
        public static int[][] Jagged = { new int[]{ 1, 2, 3, 4, 5 },
                                  new int[]{ 6, 7, 8, 9 }, 
                                  new int[]{ 10, 11 }, 
                                  new int[]{ 12 }};

        public static void DisplayArrays()
        {
            //MultiDimensional Array
            Console.WriteLine("MultiDimensional Array :");
            for(int i = 0; i < TwoDimension.GetLength(0); i++)
            {
                for(int j = 0; j < TwoDimension.GetLength(1); j++)
                {
                    Console.Write(TwoDimension[i, j]+"  ");
                }
                Console.WriteLine();
            }
            //Jagged array
            Console.WriteLine("Jagged Array :");
            for(int i = 0; i < Jagged.GetLength(0); i++)
            {
                for(int j = 0; j < Jagged[i].Length;j++)
                {
                    Console.Write(Jagged[i][j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
