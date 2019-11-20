using System;
using System.Threading;

namespace Problem010
{
    /*
     * Daily Coding Problem: Problem #10 [Medium]
This problem was asked by Apple.

Implement a job scheduler which takes in a function f and an integer n, and calls f after n milliseconds.
     */
    public class Problem
    {
        public static Timer ScheduleTask(int delayMs, Action func)
        {
            return new Timer(x => func.Invoke(), null, delayMs, Timeout.Infinite);
        }
    }
}
