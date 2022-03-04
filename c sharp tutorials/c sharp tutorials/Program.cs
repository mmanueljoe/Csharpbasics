using System;

namespace c_sharp_tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int number;
            number = 1;
            Console.WriteLine(number);
            int a;
            a = 5;
            Console.WriteLine(" A Variable = "  +  a);
            const double c = 3.142;
            Console.WriteLine(" A Pi constant = " + c);
            //adding more meaning to the variable "c".
            Console.WriteLine(+sizeof(short));
            Console.WriteLine(+sizeof(long));
            Console.WriteLine(+sizeof(decimal));
            short largeno;
            largeno = 32433;
            Console.WriteLine(largeno);
            bool x;
            x = true;
            Console.WriteLine(x);
            byte f;
            f = 250;
            Console.WriteLine(f);
            byte Number;
            Number = 90;
            Console.WriteLine(Number);
            int score = 45;
            
            float price;
            price = 56.75f;
            char k;
            k = 'a';
            string firstName = "Joe";
            bool typingfast = false;
            Console.WriteLine(score);
            Console.WriteLine(price);
            Console.WriteLine(typingfast);
            Console.WriteLine(k);
            Console.WriteLine(firstName);

            Console.WriteLine("replacing data types with var\n\t\t.");
            //writing a title

            var lastname = "letsu";
            var coding = true;
            var count = 0;
            var pi = 3.142f;
            var deci = 1.2334989m;
            var doub = 1.2224;
            Console.WriteLine(lastname);
            Console.WriteLine(coding);
            Console.WriteLine(count);
            Console.WriteLine(pi);
            Console.WriteLine(deci);
            Console.WriteLine(doub);
            var speed = 23837376263737382;
            Console.WriteLine(speed);
            var cha = 'h';
            Console.WriteLine(cha);
            
            //size of data types 
            Console.WriteLine("{0} {1}",byte.MinValue,byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("{0} {1}",char.MinValue,char.MaxValue);
            Console.WriteLine("{0} {1}",double.MinValue,double.MaxValue);
            Console.WriteLine("{0} {1}",short.MinValue,short.MaxValue);
            Console.WriteLine("{0} {1}",long.MinValue,long.MaxValue);
            Console.WriteLine("{0} {1}",int.MinValue,int.MaxValue);
            byte b = 233;
            int i = b;
            Console.WriteLine(b);
            Console.WriteLine(i);
            int h = 1000;
            byte y = (byte) h;
            Console.WriteLine(y);
            //comment
            //increment and decrement
            int e = 1;
            int j = ++e;
            Console.WriteLine(j);

            int g = 4;
            int n = g++;
            Console.WriteLine(n);
            Console.WriteLine(g);
            //comment
            //use of various operators in c sharp
            var w = 10;
            var o = 3;
            var t = 2;
            Console.WriteLine(w + o);
            Console.WriteLine((float)w / (float)o);
            Console.WriteLine(w / o);
            Console.WriteLine(w + o * t);
            Console.WriteLine(o + t * w);
            Console.WriteLine((w -o) * t);
            Console.WriteLine((o-w) * t);
            Console.WriteLine(w>t);
            Console.WriteLine((w > t) && t > o);
            Console.WriteLine((w > t) || t > o);
            Console.WriteLine((w<t) || t > o);
            Console.WriteLine(w == o);
            Console.WriteLine(o == t);
            Console.WriteLine(w != t);
            Console.WriteLine(!(w != t));

            //calculations


            



           
           
            

            
           



            


            


                
             



           

         




             
        }
    }
}
