using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Recursion
{
    class fib
    {
        public static Hashtable hash;
        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                int a;
                int b;
                if (hash.ContainsKey(n - 1))
                {
                    a = (int)hash[n - 1];
                }
                else
                {
                    a = Fib(n - 1);
                    hash.Add(n - 1, a);
                }
                if (hash.ContainsKey(n - 2))
                {
                    b = (int)hash[n - 2];
                }
                else
                {
                    b = Fib(n - 2);
                    hash.Add(n - 2, b);
                }
                return a + b;
            }
        }
    }
}
