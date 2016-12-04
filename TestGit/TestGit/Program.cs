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

        public void Divide(double a, double b)
        {
            if (b != 0)
                Console.WriteLine("Devide result= " + (a / b));
            else throw new DivideByZeroException();
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Sum(7, 8);
            
        }
    }
}
