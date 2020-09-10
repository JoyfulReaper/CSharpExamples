using System;
public class Percent
{
    public static void Main()
    {
        decimal change = 0;
        decimal baseAmount = 0;

        while (true)
        {
            Console.WriteLine("\nPercent Change");
            Console.WriteLine("1. Enter change and base amount");
            Console.WriteLine("2. Enter new amount and old amount");
            Console.WriteLine("3. Quit");
            var option = RequireValidDecimal("\nOption: ");

            if(option < 1 || option > 3)
            {
                continue;
            }
            
            if(option == 3)
            {
                Environment.Exit(0);
            }

            if(option == 1)
            {   
                change = RequireValidDecimal("Enter amount of change: ");
                baseAmount = RequireValidDecimal("Enter base amount: ");

                Console.WriteLine();
                var percentChange = PercentChange(change, baseAmount);
                Console.WriteLine($"{baseAmount + change} is an increase of {percentChange * 100:N2}% from {baseAmount}");
                Console.WriteLine($"{baseAmount - change} is an decrease of {percentChange * 100:N2}% from {baseAmount}");
            }

            if (option == 2)
            {
                var newAmount = RequireValidDecimal("Enter new amount: ");
                baseAmount = RequireValidDecimal("Enter old amount: ");
                change = Math.Abs(newAmount - baseAmount);

                var message = newAmount > baseAmount ? "increase" : "decrease";

                Console.WriteLine();
                var percentIncrease = PercentChange(change, baseAmount);
                Console.WriteLine($"{newAmount} is an {message} of {percentIncrease * 100:N2}% from {baseAmount}");
            }
        }
    }

    private static decimal RequireValidDecimal(string prompt)
    {
        bool valid = false;
        decimal result = 0;
        while(!valid)
        {
            Console.Write(prompt);
            valid = Decimal.TryParse(Console.ReadLine(), out result);
        }
        return result;
    }

    private static decimal PercentChange(decimal amountOfChange, decimal baseAmount)
    {
        return (amountOfChange / baseAmount) * 1.0m; 
    }
}