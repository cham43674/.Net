using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
        public class Class1
        {
            static void sum(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            static void sum(float a, float b)
            {
                Console.WriteLine(a + b);
            }
            static void sum(int a)
            {
                Console.WriteLine(a + a);
            }
            static void Main(string[] args)
            {
                sum(2, 3);
                sum(5.7f, 8.2f);
                sum(5);
                Console.ReadKey();
            }
        }
    }
