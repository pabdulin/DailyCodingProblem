using DemoLib;
using System;

namespace Problem001
{
    /*
     * Daily Coding Problem: Problem #1 [Easy]
     * 
Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
Bonus: Can you do this in one pass?
     */

    class Program
    {
        static void Main(string[] args)
        {
            DemoRun(new[] { 10, 15, 3, 7 }, 17);
            DemoRun(new[] { 1, 2 }, 3);
            DemoRun(new[] { 10, 15, 3, 7, 22, 456, 1, 2, 128 }, 130);
            DemoRun(new[] { 10, 15, 3, 7, 22, 456, 1, 2, 128 }, 25);

            DemoRun(new[] { 10, 15, 3, 7 }, 16);
            DemoRun(new[] { 1, 2 }, 17);
            DemoRun(new[] { 1 }, 17);
            DemoRun(new int[] { }, 17);
        }

        private static void DemoRun(int[] list, int k)
        {
            Console.WriteLine($"Given list={list.PrintArray()} and k={k}{Environment.NewLine}Result={SolveProblem(list, k)}");
            Console.WriteLine("----------");
        }

        private static bool SolveProblem(int[] list, int k)
        {
            if (list.Length < 2)
            {
                return false;
            }

            for (int i = 0; i < list.Length - 1; i += 1)
            {
                for (int j = i + 1; j < list.Length; j += 1)
                {
                    if (list[i] + list[j] == k)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
