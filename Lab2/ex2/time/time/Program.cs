using System;

namespace time
{
     class Program
    {
        private static void Main(string[] args)
        {
            string timeNow;
            timeNow = Convert.ToString(DateTime.Now);
            Console.WriteLine(timeNow);
            CountNumbers(timeNow);
            DateTime dateNow = new DateTime();

            dateNow = DateTime.Now;
            string s = Convert.ToString(dateNow.ToLongDateString());
            Console.WriteLine(s);
            CountNumbers(s);
        }

        private static void CountNumbers(string timeNow)
        {
            char[] unit = new char[1];
            string buf;
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                buf = i.ToString();
                unit = buf.ToCharArray();
                for (int j = 0; j < timeNow.Length; j++)
                {
                    if (timeNow[j] == unit[0])
                    {
                        counter++;
                    }
                }

                Console.Write(i + " : " + counter + " times\n");
                counter = 0;
            }

            Console.WriteLine("\n");
        }
    }
}
