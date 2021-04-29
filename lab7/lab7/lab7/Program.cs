using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber a = new RationalNumber(8, 3);
            RationalNumber b = new RationalNumber(5, 4);
            RationalNumber c = new RationalNumber(1, 2);
            RationalNumber d = new RationalNumber(5, 4);
            RationalNumber[] rationalNumbers = new RationalNumber[] { a, b, c, d };

            Array.Sort(rationalNumbers);
            foreach (RationalNumber i in rationalNumbers)
            {
                RationalNumber.getType(i, "in decimal");
            }

            Console.WriteLine();

            Console.WriteLine(a > b);
            Console.WriteLine(d < c);
            Console.WriteLine(b == d);
            Console.WriteLine(b.Equals(d));
            Console.WriteLine(b.Equals(a));
            Console.WriteLine();

            RationalNumber rationalNumber = new RationalNumber();
            rationalNumber = a + b;
            RationalNumber.getType(rationalNumber, "with fractions");
            Console.WriteLine();
            rationalNumber = a - b;
            RationalNumber.getType(rationalNumber, "with fractions");
            Console.WriteLine();
            rationalNumber = a * b;
            RationalNumber.getType(rationalNumber, "with fractions");
            Console.WriteLine();
            rationalNumber = a / b;
            RationalNumber.getType(rationalNumber, "with fractions");
            Console.WriteLine();
            a++;
            RationalNumber.getType(a, "with fractions");
            Console.WriteLine();
            a--;
            RationalNumber.getType(a, "with fractions");
            Console.WriteLine();
            rationalNumber = a + 10;
            RationalNumber.getType(rationalNumber, "with fractions");
            Console.WriteLine();

            int buf1;
            double buf2;
            buf1 = a;
            Console.WriteLine(buf1);
            buf2 = (double)a;
            Console.WriteLine(buf2 + "\n");

            Console.WriteLine(a.ToString("in decimal"));
            Console.WriteLine(a.ToString("with fractions"));
            Console.WriteLine();

            string inputStr = Console.ReadLine();
            string[] rationalNumbers1 = inputStr.Split(' ');
            List<RationalNumber> listNumbers = new List<RationalNumber>();
            RationalNumber.ProcessStr(rationalNumbers1, listNumbers);
            foreach (RationalNumber i in listNumbers)
            {
                Console.WriteLine(i.ToString("in decimal"));
            }
        }
    }
}
