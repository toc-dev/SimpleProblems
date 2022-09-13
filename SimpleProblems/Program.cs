using System;

namespace SimpleProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Next20LeapYears.PrintLeapYears();
            Random randomNumber = new Random();
            //Console.WriteLine(randomNumber.Next());
            //GuessingGame.GuessNumber();

            string str = "The Quick Brown Fox";
            Console.WriteLine(PigLatin.PigLat(str));
        }
    }
}
