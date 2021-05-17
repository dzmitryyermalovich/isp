using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    class PersonException : Exception
    {
        public PersonException(string message)
            : base(message)
        {
        }
    }
}
