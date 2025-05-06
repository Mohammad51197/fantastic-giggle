using System;

namespace TeamCSFile
{
    internal class Program
    {
        static void Main()
        {
            //Liam types here
            Console.WriteLine("Hello, World!");















            //Mohammad types here
           
            Console.WriteLine("Hello my name is Mohammad");
            
            {
                Console.WriteLine("Welcome to the Heads or Tails Game!");

                Console.Write("Enter your guess (h for Heads, t for Tails): ");
                char guess = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                Random random = new Random();
                int computer = random.Next(2);

                char coin = (computer == 0) ? 'h' : 't';
                string coinResult = (coin == 'h') ? "Heads" : "Tails";


                Console.WriteLine($"Computer tossed a {coinResult}");


                if (coin == guess)
                {
                    Console.WriteLine("You won!");
                }
                else
                {
                    Console.WriteLine("You lost.");
                }


                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
















    //Michael















    //Jod types here















}
    

