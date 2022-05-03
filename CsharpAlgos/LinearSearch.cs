using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;


namespace CsharpAlgos
{
    internal class LinearSearch
    {
        //input data set to search
        static int? LinearSearch1(int[] input, int n)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };

            foreach (int current in input)
            {
                if (current == n)
                {
                    return n;
                }
            }
            return null;

            Console.WriteLine(LinearSearch1(arr, 4));
            Console.WriteLine(LinearSearch1(arr, 14));
        }

        static Boolean LinearSearch2(int[] input, int n)
        {
            //I want to make this a global variable, no need to reuse, needs refactoring
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, }; foreach (int current in input)
            {
                if (current == n)
                {
                    return true;
                }
            }
            return false;

            Console.WriteLine(LinearSearch2(arr, 4));
            Console.WriteLine(LinearSearch2(arr, 14));
        }

        internal static void FindOne(int item, int[] arr)
        {
            //using the Array Class built in functions using Lambda expression
            //find one item
            item = Array.Find(arr, element => element == 3);
            Console.WriteLine(item);
            //find element that meets this condition
            int[] items2 = Array.FindAll(arr, element => element >= 5);
            Array.ForEach(items2, Console.WriteLine);
        }
    }
}
