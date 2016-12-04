using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    class Program
    {
        public void Sum(double a, double b)
        {
            Console.WriteLine("Sum= "+(a+b));
        }

        public void Minus(double a, double b)
        {
            Console.WriteLine("Result= "+(a-b));
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Sum(7, 8);
            p.Minus(23, 6);
        }
    }
}
