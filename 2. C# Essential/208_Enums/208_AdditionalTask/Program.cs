using System;

namespace _208_AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday date");

            DateTime myBirthday = Convert.ToDateTime(Console.ReadLine());

            DateTime now = DateTime.Now;

            DateTime thisYearBirthday = new DateTime(now.Year, myBirthday.Month, myBirthday.Day);

            TimeSpan waiting;

            if (thisYearBirthday < now)
            {
                DateTime nextYearBirthday = new DateTime(thisYearBirthday.Year + 1, 
                                                         thisYearBirthday.Month, thisYearBirthday.Day);
                waiting = nextYearBirthday - now;
            }
            else
            {
                waiting = thisYearBirthday - now;
            }

            Console.WriteLine("{0} days left to your birthday", waiting.Days);

            //Delay
            Console.ReadKey();
        }
    }
}
