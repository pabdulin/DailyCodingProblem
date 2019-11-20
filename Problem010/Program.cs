using System;
using System.Threading;

namespace Problem010
{
    /*
     * Daily Coding Problem: Problem #10 [Medium]
This problem was asked by Apple.

Implement a job scheduler which takes in a function f and an integer n, and calls f after n milliseconds.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before ScheduleTask..");
            var timer = Problem.ScheduleTask(1000, () => { Console.WriteLine("From ScheduleTask!"); });
            Console.WriteLine("After ScheduleTask..");
            Thread.Sleep(2000);
            timer.Dispose();
        }
    }
}
