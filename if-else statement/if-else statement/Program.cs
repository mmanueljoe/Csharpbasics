using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1, v2;
            Console.WriteLine("Please Enter The First Number And Press Enter");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter The Second Number And Press Enter");
            v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1.Sum \n2.Product \n3.Quotient \n4.Difference \n5.Modulus");
            double outcome = Convert.ToDouble(Console.ReadLine());

            if (double.Equals(v1, v2)) ;
            {
                Console.WriteLine("Sum - " + (v1 + v2));
            }
            if (double.Equals(v1, v2)) ;
            {
                Console.WriteLine("Product -" + (v1 * v2));
            }
            if (double.Equals(v1, v2)) ;
            {
                Console.WriteLine("Quotient -" + (v1 / v2));
            }
            if (double.Equals(v1, v2)) ;
            {
                Console.WriteLine("Difference -" + (v1 - v2));
            }
            if (double.Equals(v1, v2)) ;
            {
                Console.WriteLine("Modulus -" + (v1 % v2));
            }




        }
    }
}
