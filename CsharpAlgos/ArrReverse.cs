using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgos
{
    internal class ArrReverse
    {
        //Reverse arrays
        static int[] ReverseArray(int[] input)
        {
            int[] reversed = new int[input.Length];
            for (int i = 0; i < reversed.Length; i++)
            {
                //TAKES whats in the back of array and puts in the front
                reversed[i] = input[input.Length - i - 1];
            }
            return reversed;
}
 public static void Main(string[] args)
        {

            Console.WriteLine("Reversed Order");
            int[] arrNeedsReverse = { 1, 2, 4, 6, 23, 67 };
            Array.ForEach(ReverseArray(arrNeedsReverse), Console.WriteLine);
        }
    }
}
