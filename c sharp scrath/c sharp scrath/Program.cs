using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_scrath
{
    class Program
    {
        static void Main(string[] args)
        {



            string secretw = "draft";
            string guess = "";
            int guessc = 0;
            int guessl = 3;
            bool outofguesses = false;
             while(guess != secretw && !outofguesses)
            {
                if (guessc < guessl)
                {
                    Console.WriteLine("Enter Guess");
                    guess = Console.ReadLine();
                    guessc++;
                }
                else 
                {
                    outofguesses = true;
                }
                if (outofguesses)
                {
                    Console.WriteLine("You Lose!");
                }
                else
                {
                    Console.WriteLine("You Won!");
                }
                
            }

            do
            {
                Console.WriteLine("Enter Guess");
                guess = Console.ReadLine();
            } while (guess != secretw);
            Console.WriteLine("You Won!");


            //while loops
            int index = 4;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);






            //creating arrays
            int[] ages = { 20, 21, 22, 23, 24, 25, 26, 27, 28 };
            Console.WriteLine(ages[1]);
            Console.WriteLine(ages[2]);
            ages[0] = 19;//changing an object in an array.
            Console.WriteLine(ages[0]);
            string[] dudes = { "kojo, joe, emma, letsu" };
            string[] friends = new string[6];



            //building a simple calculator 
            Console.Write("Enter a number and Press Enter:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number and Press Enter:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num * num1);
            Console.WriteLine("-----------------");














        }
    }
}
