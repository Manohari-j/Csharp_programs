using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstC_
{
    internal class Messages
    {
        public static void Hello() //use public static to be visible in the main class
        {
            Console.WriteLine("Hello");
        }
        public static void Dance()
        {
            Console.WriteLine("Dance with me!!");
        }
        public static void Bye()
        {
            Console.WriteLine("Thank you!");
        }

        //An object is an instance of a class
    }
}
