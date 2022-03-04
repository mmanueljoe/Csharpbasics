using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pseucode_assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            double v;
            Console.WriteLine("Enter a Number");
            v = Convert.ToDouble(Console.ReadLine());
          
            
            
            for(double num = 0;num <= v; num++)
            {
                num++;
                if(num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
