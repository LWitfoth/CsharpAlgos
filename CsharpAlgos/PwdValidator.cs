using System.Linq;

// See https://aka.ms/new-console-template for more information



static Boolean IsUppercase(string s)
{
    return s.All(char.IsUpper);
}

static Boolean IsLowercase(string s)
{
    return s.All(char.IsLower);
}

static Boolean isPasswordComplex(string s)
{
    return s.Any(char.IsDigit) && s.Any(char.IsLower) && s.Any(char.IsUpper);
}


//Console.WriteLine(IsLowercase("helloworldlower"));
//Console.WriteLine(IsLowercase("Lisaisgoodlower"));
//Console.WriteLine(IsLowercase("lisaisgoodlower"));

//Console.WriteLine(IsUppercase("HelloWorld!UPPER"));
//Console.WriteLine(IsUppercase("HELLOWORLDUPPER"));

Console.WriteLine(isPasswordComplex("Hell0"));
Console.WriteLine(isPasswordComplex("Hello"));
Console.WriteLine(isPasswordComplex("HELL0"));
Console.WriteLine(isPasswordComplex("HeLlo"));
Console.WriteLine(isPasswordComplex("hell0"));
