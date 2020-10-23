using System;
using System.Collections.Generic;

namespace Arrays
{
    internal class Program
    {
        public static int Check(string text)
        {
            int num;
            Console.WriteLine($"{text}");
            string el = Console.ReadLine();
            bool gotcha = int.TryParse(el, out num);
            
            while (gotcha == false)
            {
                Console.WriteLine("Нужно ввести число!");
                el = Console.ReadLine();
                gotcha = int.TryParse(el, out num);
            } 

            return num;
        }
        public static int[] ReadArray(string number)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            var length = Check($"Введите количество элементов {number} массива");
            Console.ResetColor();
            
            int[] array = new int[length];
            
            for (int i = 0; i < length; ++i)
            {
                array[i] = Check($"Введите {i+1} элемент {number} массива");
            }

            return array;
        }

        public static void ArrayComparsion(int[] arr1, int[] arr2)
        {
            if (arr1.Length < arr2.Length)
            {
                Console.WriteLine("Первый массив меньше второго!");
            }
            else
            {
                int index2 = 0;
                for (int index1 = 0; index1 < arr1.Length; index1++)
                {
                    if ((arr2[index2] == arr1[index1]) 
                        && ((arr1.Length - index1) >= (arr2.Length - index2))
                        && ((arr2.Length - index2) > 0))
                    {
                        if (arr2.Length - index2 - 1 == 0)
                        {
                            Console.WriteLine("Первый массив содержит в себе второй массив");
                        }
                        index2++;
                        break;
                    }
                    else if (arr2[index2] != arr1[index1])
                    {
                        Console.WriteLine("Первый массив не содержит в себе второй массив");
                        break;
                    }
                }
            }
        }
        
        public static void Main(string[] args)
        {
            var arr1 = ReadArray("1");
            var arr2 = ReadArray("2");
            ArrayComparsion(arr1, arr2);
        }
    }
}