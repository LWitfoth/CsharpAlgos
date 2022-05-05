using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgos
{
    internal class ReverseString
    {

        static String Reverse(String input)
        {
            //1st Consider the base case consider base cases, null
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            //2nd reverse the string
            StringBuilder reversed = new StringBuilder(input.Length);
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }
            return reversed.ToString();
        }

        static String Reverse2(String? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new String(chars);
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Option1");
            Console.WriteLine(Reverse("Hello, World!"));
            Console.WriteLine(Reverse(""));
            Console.WriteLine(Reverse("hello"));
            Console.WriteLine(Reverse("hire me"));
            Console.WriteLine(Reverse("kayak"));
            Console.WriteLine(Reverse(null));


            Console.WriteLine(Reverse2("THis si reversed by another mehtod. 2 noitpo"));
            Console.WriteLine(Reverse2("Hello, World!"));
            Console.WriteLine(Reverse2(""));
            Console.WriteLine(Reverse2("hello"));
            Console.WriteLine(Reverse2("hire me"));
            Console.WriteLine(Reverse2("kayak"));
            Console.WriteLine(Reverse(null));

        }
    }
}