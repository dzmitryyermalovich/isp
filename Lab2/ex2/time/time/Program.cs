using System;

namespace time
{
    class Program
    {
        static void Main(string[] args)
        {

            string timeNow;
            timeNow = Convert.ToString(DateTime.Now);
            Console.WriteLine(timeNow);
            countNumbers(timeNow);
        }

        static void countNumbers(string timeNow)
        {
            char []unit=new char[1];
            string item;
            int counter = 0;
            for(int i = 0; i < 10; i++)
            {
                item = i.ToString();
                unit = item.ToCharArray();
                for (int j = 0; j < timeNow.Length; j++)
                {

                    if(timeNow[j]==unit[0]) 
                    {
                        counter++;
                    }
                   
                }
                Console.Write(i + " : " + counter + " times\n");
                counter = 0;
            }

        }

    }
}
