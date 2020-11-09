using System;
using System.Collections.Generic;
using System.Text;

namespace Test_six
{
    class Log
    {
        double a, b, log;
        public double A { get; set; }
        public double B { get; set; }


        public void Input()
        {
            Console.WriteLine("Input a =");
            A = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Input b =");
            B = Convert.ToDouble(Console.ReadLine());
            this.a = A;
            this.b = B;
        }
    
        public void GetLog()
        {
            log = 1 / 2 * a * a - 10 * a - 1 / 2 * b * b - 10 * b;
            Console.WriteLine("a =" + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("log = "+ log);
        }
    }
}
