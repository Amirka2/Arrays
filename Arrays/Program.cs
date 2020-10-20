using System;
using System.Collections.Generic;

namespace Arrays
{
    internal class Program
    {
        public static string ReadArrays(string number)
        {
            Console.WriteLine($"Введите {number} массив");
            string arr = Console.ReadLine();
            return arr;
        }

        public static string ArrayConverter(string arr)
        {
            var strArr = arr.Split('[', ']', ' ');
            arr = String.Concat(strArr);
            return arr;
        }
        
        public static void Main(string[] args)
        {
            var arr1 = ReadArrays("1");
            var arr2 = ReadArrays("2");

            arr1 = ArrayConverter(arr1);
            arr2 = ArrayConverter(arr2);

            Console.WriteLine(arr1.Contains(arr2));
        }
    }
}