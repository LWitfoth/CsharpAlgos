using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgos
{
    public class FindMax
    {
        int findMax(int a, int b, int c)
        {
            int maxVal = a;
            if (b > maxVal)
            {
                maxVal = b;
            }

            else if (c > maxVal)
            {
                maxVal = c;
            }

            return maxVal;
    }

        private void Main(string[] args)
        {

            Console.WriteLine(findMax(8, 2, 100));
            Console.WriteLine(findMax(310, 98, 768));
            //  When put as -6, c is max, but right now 6 is max on this test, WHY? 
            Console.WriteLine(findMax(3, 6, 500));
        }
    }
}

