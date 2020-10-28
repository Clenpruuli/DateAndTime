using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine($"Today: {today}");
            int yearToday = today.Year;
            Console.WriteLine($"Current year from today {yearToday}");
            var weekDayToday = today.DayOfWeek;
            Console.WriteLine($"Its {weekDayToday}!");
            Console.WriteLine("-----------------");

            DateTime todayDetails = DateTime.Now;
            Console.WriteLine($"Today in details: {todayDetails}");
            DateTime utc = DateTime.UtcNow;
            Console.WriteLine($"UTC Time {utc}");




        }
    }
}
