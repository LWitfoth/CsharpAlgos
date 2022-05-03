using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgos
{
    internal class ReverseWords
    {
        private static String ReverseWord(String? input2)
        {
            //base case
            if (string.IsNullOrEmpty(input2))
            {
                return input2;
            }
            //new string to store reversed words
            StringBuilder result = new StringBuilder();

            //What is the difference between little string and big String here when building array?
            String[] words = input2.Split("");
            for (int i = 0; i < words.Length; i++)
            {
                result.Append(ReverseWord(words[i]));
                if (i != words.Length - 1)
                {
                    result.Append(' ');
                }
                return result.ToString();
            }
            return input2;

            Console.WriteLine(ReverseWord("This is a test."));
            Console.WriteLine(ReverseWord(null));
            Console.WriteLine(ReverseWord(""));
            Console.WriteLine(ReverseWord("madam racecare"));
            Console.WriteLine(ReverseWord("hire me"));
        }
    }
}
