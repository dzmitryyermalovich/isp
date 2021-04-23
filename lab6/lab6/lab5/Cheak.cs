using System;

namespace lab5
{
    struct Cheak
    {
        public int CheckedNumber(string number)
        {
            try
            {
                int buf = Convert.ToInt32(number);
                if (buf < 0)
                {
                    Console.WriteLine("It is impossible age");
                    return 0;
                }
            }
            catch
            {
                Console.WriteLine("In your age letters");
                return 0;
            }

            return 1;
        }

        public int CheckedWord(string str)
        {
            foreach (char ch in str)
            {
                if (Convert.ToChar(ch) >= 48 && Convert.ToChar(ch) <= 57)
                {
                    Console.WriteLine("Your string has numbers");
                    return 0;
                }
            }

            return 1;
        }
    }
}
