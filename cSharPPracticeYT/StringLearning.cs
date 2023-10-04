using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace cSharPPracticeYT;

public static class StringLearning
{
    public static void Main()
    {
        #region String Concatenation
        int NumberOne = 10;
        int NumberTwo = 20;
        string StringValue = "Hello "; StringValue += "String";
        Console.WriteLine(StringValue);

        StringValue = $"This Value Return {StringValue}";
        Console.WriteLine(StringValue);

        StringValue = NumberOne +" Is Lass Then Number "+ NumberTwo;
        Console.WriteLine(StringValue);

        StringValue = NumberOne.ToString().Replace(NumberOne.ToString(), "70");
        Console.WriteLine(StringValue);
        #endregion

        Console.WriteLine("\n");

        #region String Compare
        string Greeting = "Hi";
        var obj = new { Name = "hi", Age = "hi" };

        bool CompareString = (Greeting == "Hi");
        Console.WriteLine(CompareString);
        var StringCompare = Greeting.CompareTo(obj.Name);
        Console.WriteLine(StringCompare);
        #endregion

        Console.WriteLine("\n");

        #region String Members
        string StringA = "String";
        string StringB = StringA.Replace("i", "o"); // Strong
        Console.WriteLine(StringB);
        StringB = StringA.Insert(0, "My "); // My String
        Console.WriteLine(StringB);
        StringB = StringA.Remove(0, 3); // ing
        Console.WriteLine(StringB);
        StringB = StringA.Substring(0, 3); // Str //StringA[..3]; 
        Console.WriteLine(StringB);
        StringB = StringA.ToUpper(); // STRING
        Console.WriteLine(StringB);
        int LengthValue = StringA.Length; // 6
        Console.WriteLine(LengthValue);
        #endregion

        Console.WriteLine("\n");

        #region Escape Characters
        /* \n=NewLine
           \f=Form feed
           \t=Horizantal Tab
           \a=Alter Sound
           \v=Vartical Tab
           \'=Single quote
           \"=Double quote
           \b=Back-Space
           \\=Backslash
           @=verbatim string literals
        */
        Console.WriteLine("Escape\nCharacters");
        Console.WriteLine("Escape\fCharacters");
        Console.WriteLine("Escape\tCharacters");
        Console.WriteLine("Escape\aCharacters");
        Console.WriteLine("Escape\vCharacters");
        Console.WriteLine("Escape\'Characters");
        Console.WriteLine("I am a \"Senior .NET Developer\".");
        Console.WriteLine("Escape\bCharacters");
        Console.WriteLine("C:\\Codebuns\\file.cs");
        Console.WriteLine("Escape\0Characters");
        string strA = @"Hello\nPirzada";
        Console.WriteLine(strA);
        #endregion
    }
}
