using System;

namespace Randomizer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int userNumber1;
         
            Random random1 = new Random((int)DateTime.Now.Ticks);
            int random2 = random1.Next(1, 1001);

            Console.Write("Try to guess the number. You have 7 attempts.\nEnter your number (from 1 to 1000): ");
          

            for (int counter = 7; counter >= 0 ; counter--)
            {
                if (counter == 0)
                {
                    Console.WriteLine("You are lose. It was " + random2);
                    break;
                }
                else 
                {
                    userNumber1 = int.Parse(Console.ReadLine());

                    if (random2 == userNumber1)
                    {
                    Console.WriteLine("\nYou're win!!! It was really " + random2 + "!!!");
                    break;
                    }
                    else
                    {
                        if (random2 < userNumber1)
                        {
                        Console.WriteLine("Too high!\n");
                        }
                        else
                        {
                        Console.WriteLine("Too low!\n");
                        }
                    }
                    Console.WriteLine("\nYou have " + (counter - 1) + " attempt");
                }
            }
        }
    }
}

