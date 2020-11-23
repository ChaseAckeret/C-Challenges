using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    class Greeter
    {
        public void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}! How are you?");
        }

        public void Farewell(string name)
        {
            Console.WriteLine($"Goodbye, {name}! I hope you enjoy the rest of your day!");
        }

        public void TimeConditional(TimeSpan time)
        {
            TimeSpan morning = new TimeSpan(07, 0, 0);
            TimeSpan afternoon = new TimeSpan(12, 0, 0);
            TimeSpan evening = new TimeSpan(17, 0, 0);
            TimeSpan night = new TimeSpan(20, 0, 0);

            if (morning <= time && time <= afternoon)
            {
                Console.WriteLine("Good Morning!");
            }
            else if (afternoon <= time && time <= evening)
            {
                Console.WriteLine("Good Afternoon!");
            }
            else if( evening <= time && time <= night)
            {
                Console.WriteLine("Good Evening!");
            }
            else
            {
                Console.WriteLine("Good Night!");
            }
        } 
    }   
}
