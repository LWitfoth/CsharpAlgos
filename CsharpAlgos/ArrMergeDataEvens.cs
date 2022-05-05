using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgos
{
    public class ArrMergeDataEvens
    {
        public static int[] FindEvenNumbers(int[] arr1, int[] arr2)
        {
            ArrayList resultArr = new ArrayList();
            foreach (int num in arr1)
            {
                if (num % 2 == 0)
                {
                    resultArr.Add(num);
                }
            }

            foreach (int num in arr2)
            {
                if (num % 2 == 0)
                {
                    resultArr.Add(num);
                }
            }
            //cast from object array to int array
            return (int[])resultArr.ToArray(typeof(int));
        }

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("combines two arrays items if they are even numbers");
        //    int[] arr3 = { -8, 25, -34, 64, 2, 8 };
        //    int[] arr4 = { 0, -9, -39, 10, 70 };
        //    int[] evenArr = FindEvenNumbers(arr3, arr4);
        //    Array.ForEach(evenArr, Console.WriteLine);
        //}
    }
}

        