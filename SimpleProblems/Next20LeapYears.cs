using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProblems
{
    public class Next20LeapYears
    {
        public static void PrintLeapYears()
        {
            int thisYear = DateTime.Now.Year;
            int countYears = 0;
            while (countYears<20)
            {
                thisYear++;
                if (thisYear % 10 == 0)
                {
                    if (thisYear % 40 == 0)
                    {
                        Console.WriteLine(thisYear);
                        countYears++;
                    }
                }
                else if (thisYear % 4 == 0)
                {
                    Console.WriteLine(thisYear);
                    countYears++;
                }

            }
        }
    }
}
