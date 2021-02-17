using System;
using System.Collections.Generic;
namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            string Primer;

            Primer=Convert.ToString(Console.ReadLine());

            List<string> Sign = new List<string>();
            List<string> index_of_signs_in_char = new List<string>();
            List<string> digits = new List<string>();
            Form_Arrays_from_signs(Primer,Sign, index_of_signs_in_char);
            Form_Arrays_from_digits(Primer, digits, index_of_signs_in_char, Sign);
            /*
            foreach (string i in digits)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n\n");
            */
            Multiplication(Primer,digits,index_of_signs_in_char,Sign);
            /*
            foreach (string i in digits)
            {
                Console.Write(i + " ");
            }
            */
            //Console.WriteLine("\n\n");
            divide(Primer, digits, index_of_signs_in_char, Sign);
            /*
            foreach (string i in digits)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n\n");
            foreach (string i in Sign)
            {
                Console.Write(i + " ");
            }
            */
            //Console.WriteLine("\n\n");
            sum(Primer, digits, index_of_signs_in_char, Sign);

        }

        static void Multiplication(string Primer, List<string> digits, List<string> index_of_signs_in_char, List<string> Sign)
        {
           
            int rez_of_multiplication_of_two_numbers;
            

            int j=0;
            int k = 0;
            while (j< Sign.Count)
            {

                if (Sign[j] == "*")
                {

                    rez_of_multiplication_of_two_numbers = int.Parse(digits[j]) * int.Parse(digits[j - 1]);
                    digits[j - 1] = rez_of_multiplication_of_two_numbers.ToString();
                    digits.RemoveAt(j);
                    Sign.RemoveAt(j);
                    index_of_signs_in_char.RemoveAt(j);
                    j = 0;
                    continue;
                }
                j++;
            }
        }

        static void Form_Arrays_from_signs(string Primer, List<string> Sign, List<string> index_of_signs_in_char)
        {
            char first_element = Primer[0];
            if (first_element!='-')
            {
                Sign.Add("+");
                index_of_signs_in_char.Add("0");
            }
            for (int i = 0; i < Primer.Length; i++)
            {
                char unit = Primer[i];
                string index;
                switch (unit)
                {
                    case '+':
                        Sign.Add("+");
                        index = i.ToString();
                        index_of_signs_in_char.Add(index);
                        break;
                    case '-':
                        Sign.Add("-");
                        index = i.ToString();
                        index_of_signs_in_char.Add(index);
                        break;
                    case '*':
                        Sign.Add("*");
                        index = i.ToString();
                        index_of_signs_in_char.Add(index);
                        break;
                    case '/':
                        Sign.Add("/");
                        index = i.ToString();
                        index_of_signs_in_char.Add(index);
                        break;


                }


            }
           int number_of_elements = Primer.Length;
            string inf;
             inf = number_of_elements.ToString();
            index_of_signs_in_char.Add(inf);
            Sign.Add("+");
            /*
            foreach(string i in Sign)
            {
                Console.WriteLine(i);
            }
            */
        }

        static void Form_Arrays_from_digits(string Primer, List<string> digits, List<string> index_of_signs_in_char, List<string> Sign)
        {
            int number_of_index_of_signs = index_of_signs_in_char.Count;

            int[] index_of_signs_in_int=new int[number_of_index_of_signs];

            int unit;

            for (int i=0;i< number_of_index_of_signs; i++)
            {
                unit = int.Parse(index_of_signs_in_char[i]);
                index_of_signs_in_int[i] = unit;
            }
            int begin;
            int end;
            string number="";
            int k=0;

            for (int i = 1; i < number_of_index_of_signs; i++)
            {
                // raz = index_of_signs_in_int[i] - index_of_signs_in_int[i - 1]-1;

                if (Sign[0] == "+" && index_of_signs_in_char[0] == "0"&& k==0)
                {
                    begin = index_of_signs_in_int[i - 1];
                    k++;

                }
                else
                {
                    begin = index_of_signs_in_int[i - 1] + 1;
                }

                end = index_of_signs_in_int[i];
                //begin = index_of_signs_in_int[i - 1] + 1;
                for (int j = begin; j < end; j++)
                {
                    number += Primer[j];
                }
                digits.Add(number);
                number = "";
            }

        }

        static void divide(string Primer, List<string> digits, List<string> index_of_signs_in_char, List<string> Sign)
        {
            int rez_of_divide_of_two_numbers;


            int j = 0;
            int k = 0;
            while (j < Sign.Count)
            {

                if (Sign[j] == "/")
                {

                    rez_of_divide_of_two_numbers =int.Parse(digits[j - 1])/int.Parse(digits[j]);
                    digits[j - 1] = rez_of_divide_of_two_numbers.ToString();
                    digits.RemoveAt(j);
                    Sign.RemoveAt(j);
                    index_of_signs_in_char.RemoveAt(j);
                    j = 0;
                    continue;
                }
                j++;
            }
        }

        static void sum(string Primer, List<string> digits, List<string> index_of_signs_in_char, List<string> Sign)
        {

            int number_of_index_of_signs = index_of_signs_in_char.Count;

            number_of_index_of_signs -= 1;

            index_of_signs_in_char.RemoveAt(number_of_index_of_signs);

            int num_of_signes = Sign.Count;

            num_of_signes -= 1;

           Sign.RemoveAt(num_of_signes);
            int unit=0;
           for(int i=0;i< Sign.Count; i++)

            {
                if (Sign[i] == "-")
                {
                   unit=int.Parse(digits[i]);
                    unit *= -1;
                    digits[i] = unit.ToString();
                }
            }
            int summa = 0;
          foreach(string i in digits)
            {
                unit = int.Parse(i);
                summa = summa + unit;
            }
            Console.WriteLine(summa);
        }
    }
}
