using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Guesser
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the random guesser game.");
            Console.WriteLine("The computer will choose an integer between 1 and 100, inclusive.");
            Console.WriteLine("It will then give you 3 clues to find the number.");
            Console.WriteLine("You win if you guess the correct number within 3 guesses.");
            Console.WriteLine("Otherwise the computer wins.");
            Console.WriteLine(" ");
            Console.WriteLine("Your 3 clues are:");

            Console.ReadLine();

            Random r = new Random();
            int number = r.Next(1,101);
            Console.WriteLine(number);

            Console.ReadLine();
        }
    }
}
