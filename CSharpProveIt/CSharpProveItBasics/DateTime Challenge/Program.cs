namespace DateTime_Challenge;

internal class Program
{
    static void Main(string[] args)
    {
        var format = GetDateFormat();

        Console.WriteLine();

        DateTime date;
        GetDate:
        var dateString = GetDate();
        try
        {
             date = ProcessDate(dateString, format);
        }
        catch
        {
            Console.WriteLine("\nPlease enter a valid date!");
            goto GetDate;
        }
        var daysAgo = DateTime.Now - date;
        Console.WriteLine("Days ago: " + daysAgo.TotalDays);

        Console.WriteLine("Enter time: ");
        var timeString = Console.ReadLine();
        var time = ProcessTime(timeString);
        
        Console.WriteLine("Hours ago: " + time.Hours);
        Console.WriteLine("Minutes ago: " + time.Minutes);
    }
    
    private static string GetDate()
    {
        Console.WriteLine("Please enter a date in the past: ");
        var response = Console.ReadLine();
        return response;
    }
    
    private static TimeSpan ProcessTime(string timeString)
    {
        var timeSplit = timeString.Split(":");
        int hours = int.Parse(timeSplit[0]);
        int minutes = int.Parse(timeSplit[1]);

        var time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, 0);
        var difference = DateTime.Now - time;
        return difference;
    }
    
    private static DateTime ProcessDate(string dateString, DateType format)
    {
        var dateSplit = dateString.Split('/');
        int day;
        int month;
        int year;
        
        if (format == DateType.DayFirst)
        {
            day = int.Parse(dateSplit[0]);
            month = int.Parse(dateSplit[1]);
            year = int.Parse(dateSplit[2]);
        }
        else
        {
            day = int.Parse(dateSplit[1]);
            month = int.Parse(dateSplit[0]);
            year = int.Parse(dateSplit[2]);
        }

        var outDate = new DateTime(year, month, day);
        return outDate;
    }

    private static DateType GetDateFormat()
    {
        Console.WriteLine("What dateformat do you prefer?");
        Console.WriteLine("1) mm/dd/yyyy");
        Console.WriteLine("2) dd/mm/yyy");

        DateType output = DateType.DayFirst;
        var response = Console.ReadLine();
        int responseInt;
        if (!int.TryParse(response, out responseInt) || responseInt > 2 || responseInt < 1)
        {
            Console.WriteLine("Please make a valid choice!\n");
            return GetDateFormat();
        }

        switch (responseInt)
        {
            case 1:
                output = DateType.MonthFirst;
                break;
            case 2:
                output = DateType.DayFirst;
                break;
        }

        return output;
    }
}
