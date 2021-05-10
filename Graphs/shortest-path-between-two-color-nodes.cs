using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Graphs
{
    class shortest_path_between_two_color_nodes
    {
        static int findShortest(int graphNodes, int[] graphFrom, int[] graphTo, long[] ids, int val)
        {
            if (ids.Where(x => x == val).Count() < 2)//If val do not have atleast in two nodes then there will be no path.
                return -1;
            var nodes = new Dictionary<int, HashSet<int>>();
            for (int i = 1; i <= graphNodes; i++)
            {
                nodes[i] = new HashSet<int>();
            }
            bool[] visited = new bool[graphNodes + 1];
            for (int i = 0; i < graphFrom.Length; i++)
            {
                nodes[graphFrom[i]].Add(graphTo[i]);
                nodes[graphTo[i]].Add(graphFrom[i]);
            }
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(graphFrom[val]);//Start with a node where val exist.
            visited[graphFrom[val]] = true;
            int shortestPath = 0;
            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                bool anyVisited = false;
                foreach (var child in nodes[node])
                {
                    if (!visited[child])
                    {
                        visited[child] = true;
                        anyVisited = true;
                        if (ids[child - 1] == val)
                        {
                            queue.Clear();
                            break;
                        }
                        queue.Enqueue(child);
                    }
                }
                if (anyVisited)//If all the child are already visited, do not increment.
                    shortestPath += 1;
            }
            return shortestPath;
        }
    }
}
