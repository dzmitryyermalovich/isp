using System;

namespace MixSymbols
{
      class Program
    {
        private static void Main(string[] args)
        {
            string inputStr;
            inputStr = Convert.ToString(Console.ReadLine());

            char[] inputStrInChar = new char[100];
            inputStrInChar = inputStr.ToCharArray();

            Random rnd = new Random();
            int newIndex;
            char temporaryVariable;

            for (int i = inputStrInChar.Length - 1; i >= 1; i--)
            {
                if (inputStrInChar[i] != ' ')
                {
                    while (true)
                    {
                        newIndex = rnd.Next(i + 1);
                        if (inputStrInChar[newIndex] != ' ')
                        {
                            break;
                        }
                    }

                    temporaryVariable = inputStrInChar[i];
                    inputStrInChar[i] = inputStrInChar[newIndex];
                    inputStrInChar[newIndex] = temporaryVariable;
                }
            }

            for (int i = 0; i < inputStrInChar.Length; i++)
            {
                Console.Write(inputStrInChar[i]);
            }
        }
    }
}
