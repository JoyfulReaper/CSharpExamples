/*
* Kyle Givler 4/14 2020
* An exspansion of the FeetToInches example on page 16 of C# 7 in a Nutshell
*/

using System;

class Test
{
	static void Main()	
	{
        int input = 1;
        bool valid = true;

        while (true)
        {
            
            Console.Write("Enter number of feet to convert to inches: (<= 0 to quit): ");

            try {
                input = Int32.Parse(Console.ReadLine());
                valid = true;
            } catch (FormatException) {
                Console.WriteLine("Must be a whole number :("); // Lets just be lazy and stick to ints
                valid = false;
            }

            if(input <= 0)
                return;
            if (valid)
                Console.WriteLine(input + " feet is " + FeetToInches(input) + " inches ");
        }
	}

	static int FeetToInches(int feet)	
	{
		int inches = feet * 12;
		return inches;
	}
}