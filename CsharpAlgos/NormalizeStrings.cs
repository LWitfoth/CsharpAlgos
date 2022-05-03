using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgos
{
    public class NormalizeStrings
    {
        //search for letters in upper and lower case forms
        //limit input to a certain type
        static string NormalizeString(String input)
        {
            return input.ToLower().Trim().Replace(",", "");
        }
    

    //Parse and Search Strings
    public static string ParseContents(string s)
    {
        Console.WriteLine("option 1");
        foreach (char c in s)
        {
            Console.WriteLine(c);
        }
        //a little more data here, we get the vaule and its location
        Console.WriteLine("option 2");
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            Console.WriteLine(c);
        }
        return s;
    }

//searches through strings by index, we need its location 
//Does character exist at the even indexes in the string
public static Boolean IsAtEvenIndex(string input, char item)
    {
        for (int i = 0; i < input.Length / 2 + 1; i = i + 2)
        {
            if (input[i] == item)
            {
                return true;
            }
        }
        return false;
    }

    public static void Main(string[] args)
        {
            Console.WriteLine(ParseContents("Hello World"));
        Console.WriteLine(NormalizeString(" Hello There, HIRING MANAGER "));
    //least efficient but easiest
    Console.WriteLine("Contains is not efficient".ToLower().Contains("ff"));
    String input = "hello";
    Console.WriteLine(IsAtEvenIndex(input, 'l'));
    Console.WriteLine(IsAtEvenIndex(input, 'L'));
    Console.WriteLine(IsAtEvenIndex(input, 'o'));
    Console.WriteLine(IsAtEvenIndex(input, 't'));
    Console.WriteLine(IsAtEvenIndex(input, 'E'));
        }

    }
}
