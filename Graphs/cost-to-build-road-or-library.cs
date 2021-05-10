using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Graphs
{
    class cost_to_build_road_or_library
    {
        static Dictionary<int, HashSet<int>> Adj = new Dictionary<int, HashSet<int>>();        
        static int comp;
        static bool[] visited;
        // Complete the roadsAndLibraries function below.
        static long roadsAndLibraries(int n, int c_lib, int c_road, int[][] cities)
        {

            if (c_road > c_lib)
                return 1L * c_lib * n;

            Adj.Clear();
            for (int i = 1; i <= n; i++)
                Adj[i] = new HashSet<int>();

            for (int i = 0; i < cities.Length; i++)
            {
                Adj[cities[i][0]].Add(cities[i][1]);
                Adj[cities[i][1]].Add(cities[i][0]);
            }
            comp = 0;            
            visited = new bool[n + 1];
            for (int i = 1; i <= n; i++)
            {
                if (!visited[i])
                {
                    DFS(i);
                    comp++;
                }
            }
            return (1L * c_road * (n - comp) + 1L * c_lib * comp);
        }

        static void DFS(int v)
        {
            visited[v] = true;
            //Component[v] = comp;
            foreach (var w in Adj[v])
                if (!visited[w])
                    DFS(w);
        }
    }
}
