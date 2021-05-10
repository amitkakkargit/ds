using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.HashAndMaps
{
    class icecream_parlor
    {
        //https://www.hackerrank.com/challenges/icecream-parlor/problem
        static int[] icecreamParlor(int m, int[] arr)
        {
            Hashtable trackSum = new Hashtable();
            int[] flavors = new int[2];
            for (int i = 0; i < arr.Length; i++)
            {
                int find = m - arr[i];
                var flavor = trackSum[find];
                if (trackSum.Contains(find))
                {
                    flavors[0] = (int)trackSum[find] + 1;
                    flavors[1] = i + 1;
                    return flavors;
                }
                if (!trackSum.Contains(arr[i]))
                {
                    trackSum.Add(arr[i], i);
                }
            }
            return flavors;
        }
    }
}
