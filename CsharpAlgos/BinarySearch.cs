using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgos
{
    public class BinarySearch
    {
        //assumes array is sorted in ascending order
        static Boolean binarySearch(int[] inputArray, int item)
        {
            //establish variables the edge indices of array
            int min = 0;
            int max = inputArray.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (inputArray[mid] == item)
                {
                    return true;
                }
                else if (item < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return false;
        }

public static void Main(string[] args)
        {
            int[] arr = { 0, 8, 23, 58, 60, 89, 132 };
            Console.WriteLine(binarySearch(arr, 45));

            //built in BinarySearch in Array Class
            Console.WriteLine(Array.BinarySearch(arr, 132));
        }

    }
}
