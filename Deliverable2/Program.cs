using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the coin flipping program!");

            Console.WriteLine("What's your guess? Heads or Tails?");
            string headsOrTailsGuess = Console.ReadLine().ToLower();

            Console.WriteLine("How many times do you want to flip the coin?");
            double numberOfFlips = int.Parse(Console.ReadLine());
            
            int i;
            double correctCount = 0;
            for (i = 0; i < numberOfFlips; i++)
            {
                Random random = new Random();
                int randomInt = random.Next(0, 2);
                
                if (randomInt == 0)
                {
                    
                    Console.WriteLine("heads");
                    if (headsOrTailsGuess == "heads")
                    {
                        correctCount++;

                    }
                }
                else if (randomInt == 1)
                {
                   
                    Console.WriteLine("Tails");
                    if (headsOrTailsGuess == "tails")
                    {
                        correctCount++;
                    }
                }
                else
                {
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("Your guess, " + headsOrTailsGuess + " came up " +
                correctCount + " time(s)");
            string percentage = ((correctCount / numberOfFlips).ToString("0%"));
            Console.WriteLine("That's " + percentage + "%.");
            

        }
    }
}
