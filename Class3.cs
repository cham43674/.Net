using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class construct
    {
        int x;
        public construct(int a, int b)
        {
            Console.WriteLine(a + b);        
        }
        public construct(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        public construct()
        {
            x = 2;
            Console.WriteLine(x+x);
        }
    }
    class Class3
    {
        static void Main(string[] args)
        {
            construct c1 = new construct(3, 5);
            construct c2 = new construct(12.5f, 7.5f);
            construct c3 = new construct();
            Console.ReadKey();
        }

    }

}
