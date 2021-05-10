using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting
{
    public class merge_sort
    {
        public List<int> Sort(List<int> unsortedArray)
        {
            var unsortedArrayLength = unsortedArray.Count;
            if (unsortedArrayLength <= 1)
                return unsortedArray;
            int mid = unsortedArrayLength / 2;
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            for (int i = 0; i < mid; i++)
            {
                left.Add(unsortedArray[i]);
            }
            for (int i = mid; i < unsortedArrayLength; i++)
            {
                right.Add(unsortedArray[i]);
            }
            left = Sort(left);
            right = Sort(right);
            return MergeAndSort(left, right);
        }
        public List<int> MergeAndSort(List<int> left, List<int> right)
        {
            List<int> mergedAndSortedArray = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() > right.First())
                    {
                        mergedAndSortedArray.Add(right.First());
                        right.Remove(right.First());
                    }
                    else if (left.First() <= right.First())
                    {
                        mergedAndSortedArray.Add(left.First());
                        left.Remove(left.First());
                    }
                }
                else if (left.Count > 0)
                {
                    mergedAndSortedArray.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    mergedAndSortedArray.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return mergedAndSortedArray;
        }
    }
}
