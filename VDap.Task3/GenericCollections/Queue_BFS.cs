using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task3.GenericCollections
{
    public class Queue_BFS
    {
        int[,] adjancyMatrix = new int[,] { { 0, 1, 1, 1, 0 }, 
                                            { 1, 0, 0, 1, 0 }, 
                                            { 1, 0, 0, 0, 0 }, 
                                            { 1, 1, 0, 0, 1 }, 
                                            { 0, 0, 0, 1, 0 } };
        List<int> visited = new List<int>();
        Queue<int> nodes = new Queue<int>();
        public void DoSearch()
        {
            nodes.Enqueue(0);
            bool notFind = true;
            int goalNode = 4;
            while(notFind)
            {
                int currentNode=nodes.Dequeue();
                visited.Add(currentNode);
                for(int i = 0; i < adjancyMatrix.GetLength(1);i++)
                {
                    if(adjancyMatrix[currentNode,i] == 1 && !visited.Contains(i))
                    {
                        if (adjancyMatrix[currentNode, goalNode] == 1)
                        {
                            notFind = false;
                        }
                        else
                        {
                            nodes.Enqueue(i);
                        }
                    }
                }
            }
            Console.WriteLine("Visited nodes in BFS are :");
            visited.ForEach(a => Console.WriteLine(a));
        }
    }
}
