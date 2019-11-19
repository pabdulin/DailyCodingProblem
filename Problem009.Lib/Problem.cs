using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem009.Lib
{
    /*
     * This problem was asked by Airbnb.

Given a list of integers, write a function that returns the largest sum of non-adjacent numbers. Numbers can be 0 or negative.

For example, [2, 4, 6, 2, 5] should return 13, since we pick 2, 6, and 5. [5, 1, 1, 5] should return 10, since we pick 5 and 5.

Follow-up: Can you do this in O(N) time and constant space?
     */
    public class Problem
    {
        public static int LargestNonAdjacentNumbersSum(int[] list)
        {
            var offset2 = 2;
            var matrix = new int[list.Length, list.Length];
            for (int c = 0; c < list.Length; c += 1)
            {
                for (int r = 0; r < list.Length; r += 1)
                {
                    matrix[c, r] = list[c] + list[r];
                }
            }

            List<int> idxAllowed = new List<int>(Enumerable.Range(0, list.Length));

            var maxTotal = 0;

            if (idxAllowed.Count == 2)
            {
                return Math.Max(0, Math.Max(list[idxAllowed[0]], list[idxAllowed[1]]));
            }

            while (idxAllowed.Any())
            {
                if (idxAllowed.Count == 1)
                {
                    maxTotal += Math.Max(0, list[idxAllowed[0]]);
                    break;
                }

                var max = int.MinValue;
                var rMax = -1;
                var cMax = -1;
                for (int r = 0; r < list.Length; r += 1)
                {
                    if (!idxAllowed.Contains(r))
                    {
                        continue;
                    }

                    for (int c = r + offset2; c < list.Length; c += 1)
                    {
                        if (!idxAllowed.Contains(c))
                        {
                            rMax = r;
                            continue;
                        }

                        var item = matrix[c, r];
                        if (item > max)
                        {
                            max = item;
                            cMax = c;
                            rMax = r;
                        }
                    }
                }

                if (idxAllowed.Contains(cMax))
                {
                    maxTotal += Math.Max(0, list[cMax]);
                    idxAllowed.Remove(cMax - 1);
                    idxAllowed.Remove(cMax);
                    idxAllowed.Remove(cMax + 1);
                }

                if (idxAllowed.Contains(rMax))
                {
                    maxTotal += Math.Max(0, list[rMax]);
                    idxAllowed.Remove(rMax - 1);
                    idxAllowed.Remove(rMax);
                    idxAllowed.Remove(rMax + 1);
                }
            }

            return maxTotal;
        }
    }
}
