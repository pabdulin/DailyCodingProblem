using System;

namespace Problem004.Lib
{
    /*
     * Daily Coding Problem: Problem #4 [Hard]

Given an array of integers, find the first missing positive integer in linear time and constant space. In other words, find the lowest positive integer that does not exist in the array. The array can contain duplicates and negative numbers as well.
For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.
You can modify the input array in-place.
     */
    public static class Problem
    {
        public static int FindMissing(int[] data)
        {
            var min = int.MaxValue;
            var max = int.MinValue;
            var found = false;
            for (int i = 0; i < data.Length; i += 1)
            {
                var value = data[i];
                if (value > 0)
                {
                    min = Math.Min(min, value);
                    max = Math.Max(max, value);
                    found = true;
                }
            }

            if(!found)
            {
                return 1;
            }

            var max2 = Math.Max(max, data.Length);
            var tempSize = max2 - min + 1;
            var temp = new bool[tempSize];
            var offset = min;

            for (int i = 0; i < data.Length; i += 1)
            {
                var value = data[i];
                if (value > 0)
                {
                    temp[value - offset] = true;
                }
            }

            var result = offset;
            foreach(var test in temp)
            {
                if(test)
                {
                    result++;
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}
