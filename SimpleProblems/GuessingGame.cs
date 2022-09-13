using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProblems
{
    public class GuessingGame
    {
        public static void GuessNumber()
        {
            Random generateRandom = new Random();
            int randomNumber = generateRandom.Next(0, 100);
            
            string playOn = "Y";
            int keepTrack = 0; // new Dictionary<int, int>();
            int count = 0;
            int countTotalGames = 0;

            
            while (playOn.ToUpper() == "Y")
            {
                while(count < 5)
                {
                    Console.WriteLine("Choose a random number from 0-100");
                    string number = Console.ReadLine();
                    Int32.TryParse(number, out int numberGuess);
                    if (numberGuess != randomNumber && numberGuess < randomNumber)
                    {

                        Console.WriteLine("Wrong, guess again. hint: too low");
                        if (numberGuess == keepTrack)
                        {
                            count += 0;
                        }
                        else
                        {
                            keepTrack = numberGuess;
                            count++;

                        }

                    }
                    if (numberGuess != randomNumber && numberGuess > randomNumber)
                    {

                        Console.WriteLine("Wrong, guess again. hint: too high");
                        if (numberGuess == keepTrack)
                        {
                            count += 0;
                        }
                        else
                        {
                            keepTrack = numberGuess;
                            count++;

                        }

                    }
                    if (numberGuess == randomNumber)
                    {
                        Console.WriteLine("That is correct!");
                        count++;
                        break;
                    }
                }
                countTotalGames += count;
                count = 0;

                Console.WriteLine($"do you want to keep playing, you have guessed {countTotalGames} times? Type y or n for yes or no: ");
                var toPlayOn = Console.ReadLine();
                if(toPlayOn.ToUpper() == "N")
                {
                    break;
                }
                if (toPlayOn.ToUpper() == "Y")
                {
                    playOn = toPlayOn;
                    count = 0;
                }
                if (toPlayOn.ToUpper() != "N" && toPlayOn.ToUpper() != "Y")
                {
                    Console.WriteLine("You need to type a y or n");
                }
                
                
            }
            
            Console.WriteLine(count);
            
        }

    }
}
