using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //loops
            int mark, max, min, sum = 0;
            max = 0;
            min = 100;
            double avg;
            for (int a = 1; a < 8; a++)
            {
                Console.Write("\n Enter Your Mark - " + a + ": ");
                mark = Convert.ToInt16(Console.ReadLine());
                //cummulative Sum
                sum = sum + mark; //sum +=mark
                //Highest Mark
                if (mark > max) 
                {
                    max = mark;
                }
                //Lowest Mark
                if (min < mark) 
                {
                    min = mark;
                }
            }
            avg = sum / 7;
            //display answers
            Console.WriteLine("\nTotalScore - " + sum + "\nHeighestScore - " + max + "\nLowestScore - " + min + "\nAverageScore - " + avg + "\n");














            double v1, v2;
            Console.Write("Enter The First Number And Press Enter:");
             v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The Second Number And Press Enter:");
            v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\t\t1.Sum \n\t\t2.Product \n\t\t3.Quotient \n\t\t4.Difference \n\t\t5.Modulus \n\t\t\rPick An Option and Press Enter");
            double result = Convert.ToDouble(Console.ReadLine());
            if (result == 1)
                Console.WriteLine("The Sum Of num1 and num2 is " + (v1 + v2));
            else if (result == 2)
                Console.WriteLine("The Product of num1 and num2 is " + (v1 * v2));
            else if (result == 3)
                Console.WriteLine("The Quotient of num1 and num2 is " + (v1 / v2));
            else if (result == 4)
                Console.WriteLine("The Difference Of num1 and num2 is " + (v1 - v2));
            else if (result == 5)
                Console.WriteLine(" The Modulus of num1 and num2 is  " + (v1 % v2));
            Console.WriteLine("\t\t\tPress Enter");

        }
    }
}
