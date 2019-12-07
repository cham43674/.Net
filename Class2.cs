using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    interface shape
    {
        void calculate(float f1, float f2);
    }
    class circle : shape
    {
        public void calculate(float x, float y)
        {
            Console.WriteLine("circle area:{0}",3.14*x*x);
        } 
    }
    class rectangle : shape
    {
        public void calculate(float x, float y)
        {
            Console.WriteLine("circle area:{0}", x * y);
        }
    }
    class Class2 
    {
        static void Main(string[] args)
        {
            circle c1 = new circle();
            rectangle r1 = new rectangle();
            shape s1;
            s1 = c1;
            s1.calculate(10, 0);
            s1 = r1;
            s1.calculate(10, 10);
            Console.ReadKey();

        }

    }
}
