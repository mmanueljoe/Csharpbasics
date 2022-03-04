using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_class
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            float a = 5f;
            float b = 4f;
            double c = Math.Pow(a, 2);
            double d = Math.Pow(b, 2);
            double sum = (c + d);
            Console.WriteLine(sum);
            double ssum = Math.Sqrt(sum);
            Console.WriteLine(ssum);
            double rsum = Math.Round(ssum);
            Console.WriteLine(rsum);
            Console.WriteLine(+sizeof (double));
            Console.WriteLine(+sizeof (decimal));
            decimal fr = (decimal)(ssum);
            Console.WriteLine(fr);
            decimal afr = Math.Round(fr, 3);
            Console.WriteLine(afr);
            Console.WriteLine(" height "  + a);
            Console.WriteLine(" base " + b  );

            //27th February class session//
            int Base, Height;
            Console.WriteLine("Enter the Height of the rectangle");
            Console.WriteLine("Enter the Base if the rectangle");
            Base = Convert.ToUInt16 (Console.ReadLine( ));
            Height = Convert.ToUInt16(Console.ReadLine());
            double Hypo = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Height, 2));
            Console.WriteLine("I\nA rectangle of Base - " + Base + " and Height -" + Height + "produces a Hypotenuse of " + Hypo.ToString("N3"));

            //conditional statements

            int num1, num2;
            Console.WriteLine("Enter num1");
            Console.WriteLine("Enter num2");
            num1 = Convert.ToInt16(Console.ReadLine());
            num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("1.Sum \n2.Product \n3.Quotient \n4.Difference \n5.Modulus");
            int answer = Convert.ToInt16(Console.ReadLine());
 
            switch (answer)
            {
                case 1:
                    Console.WriteLine("sum -" + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("product -" + (num1 * num2));
                    break;
                case 3:
                    Console.WriteLine("quotient - " + (num1 / num2));
                    break;
                case 4:
                    Console.WriteLine("difference -" + (num1 - num2));
                    break;
                case 5:
                    Console.WriteLine("remainder -" + (num1 % num2));
                    break;
            }
            Console.ReadLine();
            




                
                             

            
            



            


            

            
         
            


           
           
            
            }
    } 
}
