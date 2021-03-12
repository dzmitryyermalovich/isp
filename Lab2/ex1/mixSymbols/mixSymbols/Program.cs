using System;
using System.Text;
namespace MixSymbols
{
    class Program
    {
        private static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            char buf;
            Random rnd = new Random();
            int newIndex;

            for (int i = sb.Length - 1; i >= 1; i--)
            {
                if (sb[i] != ' ')
                {
                    while (true)
                    {
                        newIndex = rnd.Next(i + 1);
                        if (sb[newIndex] != ' ')
                        {
                            break;
                        }
                    }

                    buf = sb[i];
                    sb[i] = sb[newIndex];
                    sb[newIndex] = buf;
                }
            }

            Console.WriteLine(sb);
        }
    }
}
