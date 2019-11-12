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
            var minInData = int.MaxValue;
            var maxInData = int.MinValue;
            var foundAboveZero = false;
            for (int i = 0; i < data.Length; i += 1)
            {
                var value = data[i];
                if (value > 0)
                {
                    minInData = Math.Min(minInData, value);
                    maxInData = Math.Max(maxInData, value);
                    foundAboveZero = true;
                }
            }

            if (!foundAboveZero)
            {
                return 1;
            }

            var theoreticMaxMissing = Math.Min(maxInData, data.Length);
            var tempSequenceSize = theoreticMaxMissing - minInData + 1;
            var tempSequence = new bool[tempSequenceSize];
            var sequenceOffset = minInData;

            // fill sequence temp array
            for (int i = 0; i < data.Length; i += 1)
            {
                var value = data[i];
                if (value > 0)
                {
                    var idx = value - sequenceOffset;
                    if (idx >= tempSequenceSize)
                    {
                        continue;
                    }
                    tempSequence[idx] = true;
                }
            }

            // count all sequental values that are present
            var result = sequenceOffset;
            foreach (var test in tempSequence)
            {
                if (test)
                {
                    result += 1;
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
