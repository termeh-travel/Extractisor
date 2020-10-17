using System;
using System.Collections.Generic;

namespace Extractisor
{
    public static class Extensions
    {
        public static int ToInt(this string input)
        {
            return int.Parse(input);
        }

        public static DateTime ToDateTime(this string input)
        {
            return DateTime.Parse(input);
        }

        public static string JoinAsString(this IEnumerable<string> inputs, string separator = " ")
        {
            return string.Join(separator, inputs);
        }
        
        public static string GetLast(this string source, int count)
        {
            if(count >= source.Length)
                return source;
            
            return source.Substring(source.Length - count);
        }
    }
}