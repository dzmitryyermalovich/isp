using System;

namespace sixSystem
{
     class Program
    {
        private static void Main(string[] args)
        {
            string inputStr = Convert.ToString(Console.ReadLine());
            ProcessInputStr(inputStr);
        }

        private static void ProcessInputStr(string inputStr)
        {
            inputStr = inputStr.Insert(0, " ");
            inputStr = inputStr.Insert(inputStr.Length, " ");

            int beginOfStr = 0, endOfStr;
            int buf;

            string subString = string.Empty;

            for (int i = 1; i < inputStr.Length; i++)
            {
                double result;
                if (inputStr[i] == ' ')
                {
                    endOfStr = i;

                    for (int j = beginOfStr + 1; j < endOfStr; j++)
                    {
                        subString = subString + inputStr[j];
                    }

                    buf = CheakSystem(subString);

                    if (buf == 1)
                    {
                        result = Perevod(subString);
                        Console.WriteLine("Number in 16 system = " + subString + "  number in 10 system = " + result + "\n");
                    }

                    subString = string.Empty;
                    beginOfStr = endOfStr;
                }
            }
        }

        private static int CheakSystem(string subString)
        {
            char unit;
            for (int i = 0; i < subString.Length; i++)
            {
                unit = subString[i];

                if ((Convert.ToChar(unit) < 48 || Convert.ToChar(unit) > 57) && (Convert.ToChar(unit) < 65 || Convert.ToChar(unit) > 70))
                {
                    return 0;
                }
            }

            return 1;
        }

        private static double Perevod(string subString)
        {
            double result = 0;
            int nomer = 0, power = 0;
            string buf = string.Empty;
            for (int i = 0; i <= 9; i++)
            {
                buf = buf + i.ToString();
            }

            for (int i = 65; i < 71; i++)
            {
                buf = buf + Convert.ToChar(i);
            }

            for (int i = subString.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < buf.Length; j++)
                {
                    if (buf[j] == subString[i])
                    {
                        nomer = j;
                        break;
                    }
                }

                result = result + (Math.Pow(16, power) * nomer);
                power++;
            }

            return result;
        }
    }
}
