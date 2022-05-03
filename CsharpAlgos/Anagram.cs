using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgos
{
    internal class Anagram
    {
        public static void Main(string[] args)
        {
            AnagramTest("turner", "truern");
        }
        static void AnagramTest(string wordOne, string wordTwo)
        {
            bool isAnagram = false;
            wordOne = wordOne.ToLower();
            wordTwo = wordTwo.ToLower();

            char[] charOne = new char[wordOne.Length];
            char[] charTwo = new char[wordTwo.Length];

            for (int i = 0; i < wordTwo.Length; i++)
            {
                charTwo[i] = wordTwo[i];
            }
            for (int i = 0; i < wordOne.Length; i++)
            {
                charOne[i] = wordOne[i];
            }

            Array.Sort(charOne);
            Array.Sort(charTwo);

            if (wordOne.Length == wordTwo.Length)
            {
                for (int i = 0; i < wordOne.Length; i++)
                {
                    if (charOne[i].Equals(charTwo[i]))
                    {
                        isAnagram = true;
                    }
                    else
                    {
                        Console.WriteLine($"{wordOne} and {wordTwo} are NOT Anagrams");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Words are not the same length, not an Anagram");
            }
            if (isAnagram)
            {
                Console.WriteLine($"{wordOne} and {wordTwo} are anagrams");
            }
        }



        public static class AnagramHelper
        {
            public static bool IsAnagram(string inputA, string inputB)
            {
                inputA = "Banana";
                inputB = "Anaaba";
                if (inputA.Length != inputB.Length)
                {
                    return false;
                }
                var feqeuncyCountDict = new Dictionary<char, int>();
                for (int i = 0; i < inputA.Length; i++)
                {
                    var inputAKey = inputA[i];
                    var inputBKey = inputB[i];
                    if (!feqeuncyCountDict.ContainsKey(inputAKey))
                    {
                        feqeuncyCountDict.Add(inputAKey, 0);
                    }
                    if (!feqeuncyCountDict.ContainsKey(inputBKey))
                    {
                        feqeuncyCountDict.Add(inputBKey, 0);
                    }
                    feqeuncyCountDict[inputAKey] = feqeuncyCountDict[inputAKey] + 1;
                    feqeuncyCountDict[inputBKey] = feqeuncyCountDict[inputBKey] + 1;
                }
                foreach (var freq in feqeuncyCountDict)
                {
                    if (freq.Value % 2 != 0)
                    {
                        return false;
                    }
                }
                return true;

            }
        }
    }
}

        
    

    

