using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalMethods;

namespace Exercise04
{
    public class WorkDays
    {
        //I found this function here: http://stackoverflow.com/questions/2510383/how-can-i-calculate-what-date-good-friday-falls-on-given-a-year
        //I added a day to make it the Easer monday instead of sunday
        public static DateTime EasterMonday(int year)
        {
            int day = 0;
            int month = 0;

            int g = year % 19;
            int c = year / 100;
            int h = (c - (int)(c / 4) - (int)((8 * c + 13) / 25) + 19 * g + 15) % 30;
            int i = h - (int)(h / 28) * (1 - (int)(h / 28) * (int)(29 / (h + 1)) * (int)((21 - g) / 11));

            day = i - ((year + (int)(year / 4) + i + 2 - c + (int)(c / 4)) % 7) + 29;
            month = 3;

            if (day > 31)
            {
                month++;
                day -= 31;
            }

            return new DateTime(year, month, day);
        }

        public static int? CountWorkDays(DateTime startDate, DateTime endDate)
        {
            DateTime[] workingSaturdays = new DateTime[0];
            DateTime[] holidays = new DateTime[10]
            {
                new DateTime(1, 1, 1),
                new DateTime(1, 1, 6),
                new DateTime(1, 4, 25),
                new DateTime(1, 5, 1),
                new DateTime(1, 6, 2),
                new DateTime(1, 8, 15),
                new DateTime(1, 11, 1),
                new DateTime(1, 12, 8),
                new DateTime(1, 12, 25),
                new DateTime(1, 12, 26),
            };

            int workdaysCount = 0;
            if (startDate > endDate)
            {
                Console.WriteLine("The ending date is earlier than the final one");
                return null;
            }

            for (DateTime dateToCheck = startDate; dateToCheck <= endDate; dateToCheck = dateToCheck.AddDays(1))
            {
                if (dateToCheck.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (dateToCheck.DayOfWeek == DayOfWeek.Saturday)
                    {
                        foreach (DateTime workingSaturday in workingSaturdays)
                        {
                            if (dateToCheck.Day == workingSaturday.Day && dateToCheck.Month == workingSaturday.Month)
                            {
                                workdaysCount++;
                            }
                        }
                    }
                    else
                    {
                        bool isHoliday = false;
                        foreach (DateTime holiday in holidays)
                        {
                            if ((dateToCheck.Day == holiday.Day && dateToCheck.Month == holiday.Month))
                            {
                                isHoliday = true;
                            }
                        }
                        if ( dateToCheck == EasterMonday(dateToCheck.Year))
                        {
                            isHoliday = true;
                        }
                        if (!isHoliday)
                        {
                            workdaysCount++;
                        }
                    }
                }
            }
            return workdaysCount;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a date, this program will calculate the workdays from now to that date.");
            DateTime finalDate = new DateTime(UsefulMethods.InputInt("Year: "), UsefulMethods.InputInt("Month: "), UsefulMethods.InputInt("Day: "));
            Console.WriteLine("Number of workdays: " + CountWorkDays(DateTime.Now.Date, finalDate));
        }
    }
}
    