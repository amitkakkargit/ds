using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    //https://www.hackerrank.com/challenges/components-in-graph/problem
    /*
     * Complete the 'componentsInGraph' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts 2D_INTEGER_ARRAY gb as parameter.
     */
    public static Dictionary<int, HashSet<int>> nodes;
    public static Queue<int> traverse = new Queue<int>();
    public static Dictionary<int, bool> visited = new Dictionary<int, bool>();
    public static List<int> componentsInGraph(List<List<int>> gb)
    {
        nodes = new Dictionary<int, HashSet<int>>();
        foreach (var node in gb)
        {
            var first = node[0];
            var second = node[1];
            if (!nodes.ContainsKey(first))
            {
                var hashSet = new HashSet<int>();
                hashSet.Add(second);
                nodes[first] = hashSet;
            }
            else
            {
                var hashSet = nodes[first];
                hashSet.Add(second);
                nodes[first] = hashSet;
            }
            if (!nodes.ContainsKey(second))
            {
                var hashSet = new HashSet<int>();
                hashSet.Add(first);
                nodes[second] = hashSet;
            }
            else
            {
                var hashSet = nodes[second];
                hashSet.Add(first);
                nodes[second] = hashSet;
            }
        }
        int minConnected = int.MaxValue;
        int maxConnected = int.MinValue;

        foreach (var set in nodes)
        {
            var count = NodeCount(set.Key);
            if (count > maxConnected)
            {
                maxConnected = count;
            }
            if (count < minConnected)
            {
                minConnected = count;
            }
        }
        var nums = new List<int>();
        nums.Add(minConnected);
        nums.Add(maxConnected);
        return nums;
    }
    public static int NodeCount(int key)
    {
        traverse.Enqueue(key);
        var count = 1;
        while (traverse.Count > 0)
        {
            bool allVisited = true;
            var currentNodes = nodes[traverse.Dequeue()];
            foreach (var node in currentNodes)
            {
                if (!visited.ContainsKey(node))
                {
                    allVisited = false;
                    traverse.Enqueue(node);
                    visited.Add(node, true);
                }
            }
            if (!allVisited)
                count = count + 1;
        }
        return count == 1 ? 2 : count;
    }
}

class Solution
{
    public static bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
    {
        if (k > nums.Length)
            return false;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j && Math.Abs(nums[i] - nums[j]) <= t && Math.Abs(i - j) <= k)
                {
                    return true;
                }
            }
        }
        return false;
    }
    public static void Main(string[] args)
    {
        var check = ContainsNearbyAlmostDuplicate(new int[] { -2147483648, 2147483647 },1,1);
    }
}
