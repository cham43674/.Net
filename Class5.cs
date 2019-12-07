using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public delegate void EventHandler();
    class Class5
    {
        public static event EventHandler display;
        static void Main()
        {
            Console.WriteLine("\n ------------------------- Program FOr Delegates And Events ----------------------------");
            display += new EventHandler(red);
            display += new EventHandler(blue);
            display += new EventHandler(green);
            display += new EventHandler(red);
            display.Invoke();
            Console.WriteLine("\n ------------------------------ End OF Program ------------------------------");
            Console.ReadKey(); 
        }
        static void red()
        {
            Console.WriteLine("Roses Are Red");
        }
        static void blue()
        {
            Console.WriteLine("Roses Are Blue");
        }
        static void green()
        {
            Console.WriteLine("Roses Are Green");
        }

    }
}
