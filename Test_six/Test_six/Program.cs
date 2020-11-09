using System;
using System.Dynamic;
using System.IO;

namespace Test_six
{
    class Program
    {
        static void Main(string[] args)
        {

#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"log_output.txt");
            var new_in = new StreamReader(@"log_input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif
            Log log = new Log();
            log.Input();
            log.GetLog();
#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#else
            Console.ReadKey();
#endif

        }
    }
}
