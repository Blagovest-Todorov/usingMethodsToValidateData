using System;

namespace _04.MethodsForValidatingData
{
    class ValidatingDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What time is it");

            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine()); //We read the hour  form the console

            Console.Write("Minutes: ");
            int minutes = int.Parse(Console.ReadLine()); //we read the minutes from the console

            bool isValidTime = ValidateHours(hours) && ValidateMinutes(minutes); //We check if format hours and minutes is correct
            if (isValidTime)
            {
                Console.WriteLine("The time is {0}:{1} now." , hours, minutes);
            }
            else
            {
                Console.WriteLine("Incorrect time");
            }            
        }

        static bool ValidateMinutes(int minutes) //creating methods to check if minutes and hours are in correct format
        {
            bool result = (minutes >= 0) && (minutes <= 59);
            return result;
        }
        static bool ValidateHours(int hours)
        {
            bool result = (hours >= 0) && (hours <= 23);
            return result;
        }
    }
}
