using System;

class Program
{
    static void Main()
    {
        string originalString = "“ Hello programmer welcome to the world of programming”";
        Console.WriteLine("Before: " + originalString);



        string replacedString = originalString.Replace("programmer", "coder");
        string replacedString1 = replacedString.Replace("programming", "coding");

        Console.WriteLine("After: " + replacedString1);
        Console.WriteLine("Created By Rajan Kumar Verma");
        Console.WriteLine("MCA-2 A, Roll.no:69");
        Console.ReadKey();
    }
}