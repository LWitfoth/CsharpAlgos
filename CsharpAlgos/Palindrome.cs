using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgos
{
    internal class Palindrome
    {
        private static void Main(string[] args)
        {
            ReserveString("Rotator");
        }

        private static void ReserveString(string word)
        {
            //step one Parameters input word
            //step two break the word into a char array
            word = word.ToLower();
            char[] chars = word.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                chars[i] = word[i];
            }
            char[] chars2 = new char[word.Length];

            //step three traverse the string to store new charArray
            for (int i = 0; i < word.Length; i++)
            {
                char c = chars[i];
                chars2[word.Length - 1 - i] = c;
            }

            //If char Index.Length-1 > 0, i++ )
            Console.WriteLine(chars2);

            // Compare original CharArr1 to reverse index CharArr2
            // return true or false
            bool isPalindrome = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (chars[i] == chars2[i])
                {
                    isPalindrome = true;
                }
                else
                {
                    Console.WriteLine($"{word} is not a palindrome");
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine($"{word} is a palindrome");
            }
        }
    }
}
  