namespace Lab1
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string inputPrimer;
            while (true)
            {
                inputPrimer = Convert.ToString(Console.ReadLine());
                List<string> signOfInputPrimer = new List<string>();
                List<string> indexOfSignsInChar = new List<string>();
                List<string> digitsOfInputPrimer = new List<string>();
                FormArraysFromSigns(inputPrimer, signOfInputPrimer, indexOfSignsInChar);
                bool result = CheckFunction(inputPrimer, indexOfSignsInChar);
                if (result == false)
                {
                    Console.WriteLine("enter the value again you have a syntax error\n");
                }
                else
                {
                    FormArraysFromDigits(inputPrimer, digitsOfInputPrimer, indexOfSignsInChar, signOfInputPrimer);
                    MultiplicationOperation(digitsOfInputPrimer, indexOfSignsInChar, signOfInputPrimer);
                    DivideOperation(digitsOfInputPrimer, indexOfSignsInChar, signOfInputPrimer);
                    double rezultOfPrimer = ResultOfPrimer(digitsOfInputPrimer, indexOfSignsInChar, signOfInputPrimer);
                    break;
                }
            }
        }

        private static void MultiplicationOperation(List<string> digitsOfInputPrimer, List<string> indexOfSignsInChar, List<string> signOfInputPrimer)
        {
            float rezOfMultiplicationOfTwoNumbers;
            int index = 0;

            while (index < signOfInputPrimer.Count)
            {
                if (signOfInputPrimer[index] == "*")
                {
                    rezOfMultiplicationOfTwoNumbers = float.Parse(digitsOfInputPrimer[index]) * float.Parse(digitsOfInputPrimer[index - 1]);
                    digitsOfInputPrimer[index - 1] = rezOfMultiplicationOfTwoNumbers.ToString();
                    digitsOfInputPrimer.RemoveAt(index);
                    signOfInputPrimer.RemoveAt(index);
                    indexOfSignsInChar.RemoveAt(index);
                    index = 0;
                    continue;
                }

                index++;
            }
        }

        private static void FormArraysFromSigns(string inputPrimer, List<string> signOfInputPrimer, List<string> indexOfSignsInChar)
        {
            char firstElement = inputPrimer[0];
            if (firstElement != '-')
            {
                signOfInputPrimer.Add("+");
                indexOfSignsInChar.Add("0");
            }

            int index = 0;
            while (index < inputPrimer.Length)
            {
                string unit;
                if ((inputPrimer[index] == '*' && inputPrimer[index + 1] == '-') || (inputPrimer[index] == '/' && inputPrimer[index + 1] == '-'))
                {
                    if (inputPrimer[index] == '*')
                    {
                        signOfInputPrimer.Add("*");
                    }
                    else
                    {
                        signOfInputPrimer.Add("/");
                    }

                    unit = index.ToString();
                    indexOfSignsInChar.Add(unit);
                    index += 1;
                }
                else
                {
                    switch (inputPrimer[index])
                    {
                        case '+':
                            signOfInputPrimer.Add("+");
                            unit = index.ToString();
                            indexOfSignsInChar.Add(unit);
                            break;
                        case '-':
                            signOfInputPrimer.Add("-");
                            unit = index.ToString();
                            indexOfSignsInChar.Add(unit);
                            break;
                        case '*':
                            signOfInputPrimer.Add("*");
                            unit = index.ToString();
                            indexOfSignsInChar.Add(unit);
                            break;
                        case '/':
                            signOfInputPrimer.Add("/");
                            unit = index.ToString();
                            indexOfSignsInChar.Add(unit);
                            break;
                    }
                }

                index++;
            }

            int numberOfElements = inputPrimer.Length;
            string buff;
            buff = numberOfElements.ToString();
            indexOfSignsInChar.Add(buff);
            signOfInputPrimer.Add("+");
        }

        private static void FormArraysFromDigits(string inputPrimer, List<string> digitsOfInputPrimer, List<string> indexOfSignsInChar, List<string> signOfInputPrimer)
        {
            int numberOfIndexOfSigns = indexOfSignsInChar.Count;

            int[] indexOfSignsInInt = new int[numberOfIndexOfSigns];

            int unit;

            for (int i = 0; i < numberOfIndexOfSigns; i++)
            {
                unit = int.Parse(indexOfSignsInChar[i]);
                indexOfSignsInInt[i] = unit;
            }

            int beginOfIndexSign;
            int endOfIndexSign;
            string numberInStr = string.Empty;
            int nomerOfIteration = 0;

            for (int i = 1; i < numberOfIndexOfSigns; i++)
            {
                if (signOfInputPrimer[0] == "+" && indexOfSignsInChar[0] == "0" && nomerOfIteration == 0)
                {
                    beginOfIndexSign = indexOfSignsInInt[i - 1];
                    nomerOfIteration++;
                }
                else
                {
                    beginOfIndexSign = indexOfSignsInInt[i - 1] + 1;
                }

                endOfIndexSign = indexOfSignsInInt[i];
                for (int j = beginOfIndexSign; j < endOfIndexSign; j++)
                {
                    numberInStr += inputPrimer[j];
                }

                digitsOfInputPrimer.Add(numberInStr);
                numberInStr = string.Empty;
            }
        }

        private static void DivideOperation(List<string> digitsOfInputPrimer, List<string> indexOfSignsInChar, List<string> signOfInputPrimer)
        {
            float rezOfDivideOfTwoNumbers;
            int index = 0;

            while (index < signOfInputPrimer.Count)
            {
                if (signOfInputPrimer[index] == "/")
                {
                    if (float.Parse(digitsOfInputPrimer[index]) == 0)
                    {
                        Console.WriteLine("You can divide on 0");
                        Environment.Exit(0);
                    }

                    rezOfDivideOfTwoNumbers = float.Parse(digitsOfInputPrimer[index - 1]) / float.Parse(digitsOfInputPrimer[index]);
                    digitsOfInputPrimer[index - 1] = rezOfDivideOfTwoNumbers.ToString();
                    digitsOfInputPrimer.RemoveAt(index);
                    signOfInputPrimer.RemoveAt(index);
                    indexOfSignsInChar.RemoveAt(index);
                    index = 0;
                    continue;
                }

                index++;
            }
        }

        private static double ResultOfPrimer(List<string> digitsOfInputPrimer, List<string> indexOfSignsInChar, List<string> signOfInputPrimer)
        {
            int numberOfIndexOfSigns = indexOfSignsInChar.Count;
            numberOfIndexOfSigns -= 1;
            indexOfSignsInChar.RemoveAt(numberOfIndexOfSigns);
            int numOfSignes = signOfInputPrimer.Count;
            numOfSignes -= 1;
            signOfInputPrimer.RemoveAt(numOfSignes);
            float unit;
            for (int i = 0; i < signOfInputPrimer.Count; i++)
            {
                if (signOfInputPrimer[i] == "-")
                {
                    unit = float.Parse(digitsOfInputPrimer[i]);
                    unit *= -1;
                    digitsOfInputPrimer[i] = unit.ToString();
                }
            }

            float summa = 0;
            foreach (string i in digitsOfInputPrimer)
            {
                unit = float.Parse(i);
                summa = summa + unit;
            }

            Console.WriteLine(summa);
            return summa;
        }

        private static bool CheckFunction(string inputPrimer, List<string> indexOfSignsInChar)
        {
            for (int i = 0; i < inputPrimer.Length; i++)
            {
                int element = Convert.ToChar(inputPrimer[i]);

                if (element < 42 || element > 57 || element == 44)
                {
                    return false;
                }
            }

            int differenceBetweenNeighboring;
            for (int i = 1; i < indexOfSignsInChar.Count; i++)
            {
                differenceBetweenNeighboring = int.Parse(indexOfSignsInChar[i]) - int.Parse(indexOfSignsInChar[i - 1]);
                if (differenceBetweenNeighboring == 1 && indexOfSignsInChar[i - 1] != "0")
                {
                    return false;
                }
            }

            for (int i = 1; i < inputPrimer.Length; i++)
            {
                if (inputPrimer[i] == inputPrimer[i - 1] && inputPrimer[i] == '.')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
