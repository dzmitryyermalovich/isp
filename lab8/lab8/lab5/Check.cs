using System;

namespace lab5
{
    struct Check
    {
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
