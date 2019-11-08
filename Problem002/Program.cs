using DemoLib;
using System;

namespace Problem002
{
    /*
     * Daily Coding Problem: Problem #2 [Hard]
Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.
For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be [2, 3, 6].
Follow-up: what if you can't use division?
     */
    class Program
    {
        static void Main(string[] args)
        {
            DemoRun(new int[] { 1, 2, 3, 4, 5 }, SolveProblemNoDivision);
            DemoRun(new int[] { 3, 2, 1 }, SolveProblemNoDivision);
            DemoRun(new int[] { -3, -2, -1 }, SolveProblemNoDivision);
            DemoRun(new int[] { 3, 2, 1, 0 }, SolveProblemNoDivision);
            DemoRun(new int[] { 3, 2 }, SolveProblemNoDivision);
            DemoRun(new int[] { 3 }, SolveProblemNoDivision);
            DemoRun(new int[] { }, SolveProblemNoDivision);
        }

        private static void DemoRun(int[] array, Func<int[], int[]> solver)
        {
            Console.WriteLine($"Given array={array.PrintArray()}{Environment.NewLine}Result={solver(array).PrintArray()}");
            Console.WriteLine("----------");
        }

        private static int[] SolveProblemNoDivision(int[] list)
        {
            var result = new int[list.Length];
            if (list.Length >= 2)
            {
                for (int i = 0; i < list.Length; i += 1)
                {
                    var product = 1;
                    for (int j = 0; j < list.Length; j += 1)
                    {
                        if (j == i)
                        {
                            continue;
                        }

                        product *= list[j];

                    }
                    result[i] = product;
                }
            }
            return result;
        }
    }
}
