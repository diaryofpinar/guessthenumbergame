using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to guess number game! Please type your name:");
            string name = Console.ReadLine();
            string name1, name2;
            name1 = name.Substring(0, 1).ToUpper();
            name2 = name.Substring(1, name.Length-1).ToLower();

            name = name1 + name2;

            
            
            int number = new Random().Next(0, 100);
            int guess=0;
            Console.WriteLine("Hi" + " " + name + "!" + " " + "Guess the number:");
            int lives = 7;
            
            do
            {
                if (lives < 1) 
                {
                    Console.WriteLine("You lost!!");
                    break;
                }
                guess = int.Parse(Console.ReadLine());
                if (guess>number)
                {
                    Console.WriteLine("Down!");
                }

                else if (guess<number)
                {
                    Console.WriteLine("up!");
                }

                lives--;
            } while (guess!= number);
            if (guess == number) 
            {
                Console.WriteLine("Well Done" + " " + name + "!");

            }


            Console.ReadKey();
        }
    }
}
