using System;
using System.Collections.Generic;

namespace DemoLib
{
    public static class ArrayExt
    {
        public static string PrintArray(this Array array)
        {
            var data = new List<object>();
            foreach (var item in array)
            {
                data.Add(item);
            }
            return string.Format("[{0}]", string.Join(", ", data));
        }
    }
}
