using System;

namespace TeamCSFile
{
    internal class Program
    {
        static void Main()
        {
            //Liam types here|          Latest programming lab (I added some intentional errors so that no one can cheat
            Console.WriteLine("What would you like the starting character to be?"); //Start character input
            char startChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("What would you like the finishing character to be?"); //End character input
            char endChar = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            for (char i = startChar; i <= endChar; i++) //Sets the rows up
            {
                for (char j = startChar; j+1 <= i; j++) //Increments the chars
                {
                    Console.Write($"{startChar++}"); //Prints them as they go
                }
                Console.WriteLine(); //Separates the lines
            }
            Console.ReadLine();
            //Mohammad types here















            //Michael















            //Jod types here















        }
    }
}
