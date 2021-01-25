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

            Expression exp1 = new Addition(new Nombre(33), new Nombre(33));
            double result1 = exp1.Evalue();
            Console.WriteLine(result1); // Output : 66
            string result1format = exp1.Format();
            Console.WriteLine(result1format);

            Expression exp2 = new Addition(new Nombre(33), new Addition(new Nombre(33), new Nombre(11)));
            double result2 = exp2.Evalue();
            Console.WriteLine(result2); // Output : 77
            string result2format = exp2.Format();
            Console.WriteLine(result2format);

            Console.WriteLine("************************************");

            Expression exp3 = new Addition(new Nombre(33), new Nombre(33));
            double result3 = exp3.Evalue();
            Console.WriteLine(result3); // Output : 66
            string result = exp3.Format();
            Console.WriteLine(result);


            Console.WriteLine("************************************");

            /*Expression exp4 = new Soustraction(new Nombre(2), new Nombre(3));
            double result4 = exp4.Evalue();
            Console.WriteLine(result4); // Output : -1

            Expression exp5 = new Division(new Nombre(100), new Nombre(4));
            double result5 = exp5.Evalue();
            Console.WriteLine(result5); // Output : 25

            Expression exp6 = new Multiplication(new Nombre(10), new Nombre(4));
            double result6 = exp6.Evalue();
            Console.WriteLine(result6); // Output : 40*/

            Console.WriteLine("************************************");


        }
    }
}
