using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class6
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 10 };
            int b = 5;
            try
            {
                int x = a[2] - (b - a[0]);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Div By Zero");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Array error");
            }
            finally {
                Console.WriteLine("Finally Block");
            }
            int y = a[1] / a[0];
            Console.WriteLine(y);
            Console.ReadKey();
        }

    }
}
