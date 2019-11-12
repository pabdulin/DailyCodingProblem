using System;

namespace Problem005.Lib
{
    /*
     * Daily Coding Problem: Problem #5 [Medium]
cons(a, b) constructs a pair, and car(pair) and cdr(pair) returns the first and last element of that pair.
For example, car(cons(3, 4)) returns 3, and cdr(cons(3, 4)) returns 4.
Given this implementation of cons:
def cons(a, b):
    def pair(f):
        return f(a, b)
    return pair

Implement car and cdr.
     */

    public class Problem
    {
        public static Func<dynamic, int> cons(int a, int b)
        {
            Func<dynamic, int> pair = (f) => f(a, b);
            return pair;
        }

        public static int car(Func<dynamic, int> cons)
        {
            dynamic target = cons.Target;
            return (int)target.a;
        }

        public static int cdr(Func<dynamic, int> cons)
        {
            dynamic target = cons.Target;
            return (int)target.b;
        }
    }
}
