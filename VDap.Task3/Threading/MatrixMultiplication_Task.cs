using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task3.Threading
{
    public class MatrixMultiplication_Task
    {
        Coordinate coordinate;
        public int[,] matrix1;
        public int[,] matrix2;
        public int[,] result;
        public MatrixMultiplication_Task(int[,] matrix1, int[,] matrix2)
        {
            this.matrix1 = matrix1;
            this.matrix2 = matrix2;
            coordinate = new Coordinate();
            result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        }
        public void MultiplyMatrices()
        {
            Task[] tasks = new Task[matrix1.GetLength(0) * matrix2.GetLength(1)];

            for (int i = 0; i < matrix1.GetLength(0) * matrix2.GetLength(1);)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    coordinate.row = i;
                    coordinate.column = j;
                    tasks[i] = new Task((param) =>
                    {
                        int row = ((Coordinate)param).row;
                        int column = ((Coordinate)param).column;
                        for (int z = 0; z < matrix2.GetLength(0); z++)
                        {
                            result[row / matrix2.GetLength(1), column] += matrix1[row / matrix2.GetLength(1), z] * matrix2[z, column];
                        }
                    },coordinate);
                    tasks[i].Start();
                    tasks[i].Wait();
                    i++;
                }
            }
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
