using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_DesignPattern;

namespace CA_Calculate
{
    class Program
    {
        static void Main(string[] args)
        {

            Expression exp1 = new Addition(new Entier(33), new Entier(33));
            double result1 = exp1.Evalue();
            Console.WriteLine(result1); // Output : 66

            Expression exp2 = new Addition(new Entier(33), new Addition(new Entier(33), new Entier(11)));
            double result2 = exp2.Evalue();
            Console.WriteLine(result2); // Output : 77

            Console.WriteLine("************************************");

            Expression exp4 = new Soustraction(new Entier(2), new Entier(3));
            double result4 = exp4.Evalue();
            Console.WriteLine(result4); // Output : -1

            Expression exp5 = new Division(new Entier(100), new Entier(4));
            double result5 = exp5.Evalue();
            Console.WriteLine(result5); // Output : 25

            Expression exp6 = new Multiplication(new Entier(10), new Entier(4));
            double result6 = exp6.Evalue();
            Console.WriteLine(result6); // Output : 40

            Console.WriteLine("************************************");


        }
    }
}
