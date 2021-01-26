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
            double result1 = exp1.Evalue();// Output : 66
            string result1format = exp1.Format();
            Console.WriteLine(result1format);

            Console.WriteLine("************************************");

            Expression exp2 = new Addition(new Nombre(33), new Addition(new Nombre(33), new Nombre(11)));
            double result2 = exp2.Evalue();// Output : 77
            string result2format = exp2.Format();
            Console.WriteLine(result2format);

            Console.WriteLine("************************************");

            Expression exp3 = new Addition(new Nombre(33), new Nombre(33));
            double result3 = exp3.Evalue();// Output : 66
            string result3format = exp3.Format();
            Console.WriteLine(result3format);


            Console.WriteLine("************************************");

            Expression exp4 = new Addition(new Nombre(3), new Nombre(2));
            double result4 = exp4.Evalue();// Output : 5
            string result4format = exp4.Format();
            Console.WriteLine(result4format);

            Console.WriteLine("************************************");

            Expression exp5 = new Addition( new Soustraction(new Nombre(3), new Nombre(6)) , new Nombre(7));
            double result5 = exp5.Evalue();// Output : 4
            string result5format = exp5.Format();
            Console.WriteLine(result5format);

            Console.WriteLine("************************************");


        }
    }
}
