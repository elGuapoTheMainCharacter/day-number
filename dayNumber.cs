using System;

namespace DayNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a date (MM/dd/yyyy): ");
                    string date = Console.ReadLine();

                    if (DateTime.TryParseExact(date, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dt))
                    {
                        int day = dt.Day;
                        int month = dt.Month;
                        int year = dt.Year;
                        int counter = 0;
                        int currentDay = day;
                        int[] daysInAMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                        if (IsLeap(year) == true)
                        {
                            Console.WriteLine(year + " is a leap year");
                            daysInAMonth[1] = 29;
                        }
                        if (month == 1)
                        {
                            currentDay = day;
                        }
                        else if (month > 1)
                        {
                            for (int x = 0; x < month - 1; x++)
                            {
                                counter += daysInAMonth[x];
                            }
                            //Console.WriteLine("countrr:"+counter+" currrnt day "+currentDay );
                            currentDay += counter;
                            //isLeap();
                        }
                        Console.WriteLine("we " + currentDay + " days into " + year);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        static bool IsLeap(int year)
        {
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                //Console.WriteLine("yes");
                return true;
            }
            else
            {
                //Console.WriteLine("no");
                return false;
            }
        }
    }
}
