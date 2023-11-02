using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task3.GenericCollections
{
    public class Stack_DFS
    {
        int[,] adjancyMatrix = new int[,] { { 0, 1, 1, 1, 0 },
                                            { 1, 0, 0, 1, 0 },
                                            { 1, 0, 0, 0, 0 },
                                            { 1, 1, 0, 0, 1 },
                                            { 0, 0, 0, 1, 0 } };
        List<int> visited = new List<int>();
        Stack<int> nodes = new Stack<int>();
        public void DoSearch()
        {
            nodes.Push(0);
            bool notFind = true;
            int goalNode = 4;
            while(notFind)
            {
                int currentNode = nodes.Pop();
                visited.Add(currentNode);
                for(int i = 0; i < adjancyMatrix.GetLength(1); i++)
                {
                    if(adjancyMatrix[currentNode,i] == 1 && !visited.Contains(i))
                    {
                        if (adjancyMatrix[currentNode, goalNode] == 1)
                            notFind = false;
                        else
                            nodes.Push(i);
                    }
                }
            }
            Console.WriteLine("Visited nodes in DFS are :");
            visited.ForEach(x =>Console.WriteLine(x));
        }
    }
}
