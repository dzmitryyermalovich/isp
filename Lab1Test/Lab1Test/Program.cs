using System;
using System.Collections.Generic;
namespace Lab1
{
    // Задача 2
    class Program
    {
        static void Main(string[] args)
        {
            double rezult_of_primer = 0;
            string Primer;
        metka:
            Primer = "";

            Primer = Convert.ToString(Console.ReadLine());

            List<string> Sign = new List<string>();

            List<string> index_of_signs_in_char = new List<string>();

            List<string> digits = new List<string>();

            

             Form_Arrays_from_signs(Primer, Sign, index_of_signs_in_char);


             bool result = check(Primer, index_of_signs_in_char);

             if (result == false)
            {
              Console.WriteLine("enter the value again you have a syntax error\n");
             goto metka;
            }

            Form_Arrays_from_digits(Primer, digits, index_of_signs_in_char, Sign);
            Multiplication(digits, index_of_signs_in_char, Sign);
            divide(digits, index_of_signs_in_char, Sign);
            rezult_of_primer = sum(digits, index_of_signs_in_char, Sign);
            
            
        }

        static void Multiplication(List<string> digits, List<string> index_of_signs_in_char, List<string> Sign)
        {

            float rez_of_multiplication_of_two_numbers;


            int j = 0;
            int k = 0;
            while (j < Sign.Count)
            {

                if (Sign[j] == "*")
                {

                    rez_of_multiplication_of_two_numbers = float.Parse(digits[j]) * float.Parse(digits[j - 1]);
                    digits[j - 1] = rez_of_multiplication_of_two_numbers.ToString();
                    digits.RemoveAt(j);
                    Sign.RemoveAt(j);
                    index_of_signs_in_char.RemoveAt(j);
                    j = 0;
                    continue;
                }
                j++;
            }
            /*
            Console.WriteLine("\n");
            foreach (string peremena in digits)
            {
                Console.WriteLine(peremena);
            }
            */
        }

        static void Form_Arrays_from_signs(string Primer, List<string> Sign, List<string> index_of_signs_in_char)
        {
            char first_element = Primer[0];
            if (first_element != '-')
            {
                Sign.Add("+");
                index_of_signs_in_char.Add("0");
            }
            int i = 0;
          //  for (int i = 0; i < Primer.Length; i++)
                while(i< Primer.Length)
            {
                char unit = Primer[i];
                string index;

                if ((Primer[i] == '*' && Primer[i + 1] == '-') || (Primer[i] == '/' && Primer[i + 1] == '-'))
                {
                    if(Primer[i] == '*')
                    {
                        Sign.Add("*");
                    }
                    else
                    {
                        Sign.Add("/");
                    }
                    index = i.ToString();
                    index_of_signs_in_char.Add(index);
                    i += 1;
                }
                else
                {
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
                i++;
            }
            int number_of_elements = Primer.Length;
            string inf;
            inf = number_of_elements.ToString();
            index_of_signs_in_char.Add(inf);
            Sign.Add("+");
            /*
            foreach(string j in Sign)
            {
                Console.Write(j," ");
            }
            */
        }

        static void Form_Arrays_from_digits(string Primer, List<string> digits, List<string> index_of_signs_in_char, List<string> Sign)
        {
            int number_of_index_of_signs = index_of_signs_in_char.Count;

            int[] index_of_signs_in_int = new int[number_of_index_of_signs];

            int unit;

            for (int i = 0; i < number_of_index_of_signs; i++)
            {
                unit = int.Parse(index_of_signs_in_char[i]);
                index_of_signs_in_int[i] = unit;
            }
            int begin;
            int end;
            string number = "";
            int k = 0;

            for (int i = 1; i < number_of_index_of_signs; i++)
            {
                // raz = index_of_signs_in_int[i] - index_of_signs_in_int[i - 1]-1;

                if (Sign[0] == "+" && index_of_signs_in_char[0] == "0" && k == 0)
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
            /*
            Console.WriteLine("\n");
            foreach (string j in digits)
            {
                Console.WriteLine(j);
            }
            */
        }

        static void divide(List<string> digits, List<string> index_of_signs_in_char, List<string> Sign)
        {
            float rez_of_divide_of_two_numbers;
            int j = 0;
            int k = 0;
            while (j < Sign.Count)
            {

                if (Sign[j] == "/")
                {
                    if (float.Parse(digits[j]) == 0)
                    {
                        Console.WriteLine("You can divide on 0");
                        Environment.Exit(0);
                    }
                    rez_of_divide_of_two_numbers = float.Parse(digits[j - 1]) / float.Parse(digits[j]);
                    digits[j - 1] = rez_of_divide_of_two_numbers.ToString();
                    digits.RemoveAt(j);
                    Sign.RemoveAt(j);
                    index_of_signs_in_char.RemoveAt(j);
                    j = 0;
                    continue;
                }
                j++;
            }
            /*
            Console.WriteLine("\n");
            foreach (string peremena in digits)
            {
                Console.WriteLine(peremena);
            }
            */
        }

        static double sum(List<string> digits, List<string> index_of_signs_in_char, List<string> Sign)
        {

            int number_of_index_of_signs = index_of_signs_in_char.Count;

            number_of_index_of_signs -= 1;

            index_of_signs_in_char.RemoveAt(number_of_index_of_signs);

            int num_of_signes = Sign.Count;

            num_of_signes -= 1;

            Sign.RemoveAt(num_of_signes);
            float unit = 0;
            for (int i = 0; i < Sign.Count; i++)

            {
                if (Sign[i] == "-")
                {
                    unit = float.Parse(digits[i]);
                    unit *= -1;
                    digits[i] = unit.ToString();
                }
            }
            float summa = 0;
            foreach (string i in digits)
            {
                unit = float.Parse(i);
                summa = summa + unit;
            }
            Console.WriteLine(summa);
            return summa;
        }

        static bool check(string Primer,List<string> index_of_signs_in_char)
        {
            for(int i = 0; i < Primer.Length; i++)
            {
                int element = Convert.ToChar(Primer[i]);

                if (element<42 || element>57 || element == 44)
                {
                    return false;
                }
                
            }
            int difference_between_neighboring;
            for (int i=1;i<index_of_signs_in_char.Count; i++)
            {
                difference_between_neighboring=int.Parse(index_of_signs_in_char[i]) - int.Parse(index_of_signs_in_char[i - 1]);
                if (difference_between_neighboring == 1 && index_of_signs_in_char[i-1]!="0")
                {
                    return false;
                }
            }

            for (int i = 1; i < Primer.Length; i++)
            {
                 if(Primer[i]== Primer[i-1] && Primer[i] == '.')
                {
                    return false;
                }
            }

            return true;
        }

        
    }
}
