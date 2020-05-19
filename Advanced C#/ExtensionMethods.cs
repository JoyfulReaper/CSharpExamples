// Extension Methods allow an existing type to be extended with new methods
// without modifiying the original implementaion of the type.
//


using System;

// Static method in a static class
public static class StringHelper
{
    public static bool IsCapitalized (this string s) // this modifer applied to fisrt parameter, the type to be extended
    {
        if(string.IsNullOrEmpty(s))
            return false;
        return char.IsUpper(s[0]);
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentense = Console.ReadLine();

        // Can be called as if it was an instance method
        Console.WriteLine("Your sentence {0} start with a capital letter.", sentense.IsCapitalized() ? "does" : "does not");
    }
}