using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_or_Functions
{
    class Program
    {
        static void Main(string [] args)
        {

        }


        //return statement
        static int cubeof(int num1)
        {
            int result = num1 * num1 * num1;
            return result;
        }




        //creating a method which does not contain a return statement
        static void SayHey(string name , int age )
        {
            Console.WriteLine(" Hello  " + name +  " , your age is " + age );
        }
    }
}
