using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgos
{
    internal class RotateArray
    {
        // See https://aka.ms/new-console-template for more information


        // create algo that rotates the contents to the left by one space
        //input 123456  output 234561

        static void RotateArrayLeft(int[] input)
        {
            int temp = input[0];

            for (int i = 0; i < input.Length - 1; i++)
            {
                input[i] = input[i + 1];
            }
            input[input.Length - 1] = temp;
        }

        // create algo that rotates the contents to the right by one space
        //input 123456  output 612345

        static void RotateArrayRight(int[] input)
        {
            int temp = input[input.Length - 1];

            for (int i = input.Length - 1; i > 0; i--)
            {
                input[i] = input[i - 1];
            }
            input[0] = temp;
        }

        private static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            RotateArrayLeft(arr);
            RotateArrayRight(arr);
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}
