using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter greeter = new Greeter();

            Console.WriteLine("What is you name?");

            string input = Console.ReadLine();
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            greeter.Hello(input);
            greeter.TimeConditional(currentTime);
            greeter.Farewell(input);
            Console.ReadKey();
        }
    }
}
