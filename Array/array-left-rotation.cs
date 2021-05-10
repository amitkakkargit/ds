using System;
using System.IO;

namespace DataStructure
{
    class array_left_rotation
    {
        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int[] newArray = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                newArray[findActualIndex(i, a.Length, d)] = a[i];
            }
            return newArray;
        }

        static int findActualIndex(int currentIndex, int arrayLength, int shift)
        {
            shift = shift > arrayLength ? shift % arrayLength : shift;
            int actualIndex = currentIndex - shift;
            if (actualIndex > -1)
            {
                return actualIndex;
            }
            else
            {
                return arrayLength - (actualIndex * -1);
            }
        }
    }
}
