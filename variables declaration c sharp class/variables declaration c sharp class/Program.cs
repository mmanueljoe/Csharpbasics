using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables_declaration_c_sharp_class
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedRate = 10;
            Console.WriteLine(speedRate);

            int a = 2, b = 3, c;
            Console.WriteLine("Size of int -" + sizeof(int));
            c = a / b;
            Console.WriteLine(a + " / " + b + " = " + c);
            c = a % b;
            Console.WriteLine(a + " % " + b + " = " + c);
            c = a + b;
            Console.WriteLine(a + " + " + b + " = " + c);
            c = a + b * a - b % a;
            Console.WriteLine(a + " + " + b + " * " + a + " - " + b + " % " + a + " = " + c);



        }
        


    }
   
   
}
