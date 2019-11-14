using System;
using System.Collections.Generic;

namespace Problem007.Lib
{
    /*
     * Daily Coding Problem: Problem #7 [Medium]
This problem was asked by Facebook.

Given the mapping a = 1, b = 2, ... z = 26, and an encoded message, count the number of ways it can be decoded.

For example, the message '111' would give 3, since it could be decoded as 'aaa', 'ka', and 'ak'.

You can assume that the messages are decodable. For example, '001' is not allowed.
     */

    public class Problem
    {
        public static int CountPossibleWaysToDecode(string message)
        {
            if (message == string.Empty)
            {
                return 0;
            }
            var result = CountRec(message);
            return result;
        }

        private static int CountRec(string message, int count = 0)
        {
            if (message.Length == 0)
            {
                return count + 1;
            }
            else
            {
                var candidate1Reminder = message.Substring(1);
                count = CountRec(candidate1Reminder, count);
                if (message.Length > 1)
                {
                    var candidate2 = message.Substring(0, 2);
                    var c2 = int.Parse(candidate2);
                    if (c2 <= 26)
                    {
                        var candidate2Reminder = message.Substring(2);
                        count = CountRec(candidate2Reminder, count);
                    }
                }
            }

            return count;
        }
    }
}
