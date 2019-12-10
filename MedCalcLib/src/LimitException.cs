using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCalc
{
    public class LimitException : Exception
    {
        public LimitException()
        {
        }

        public LimitException(string message) : base(message)
        {
        }
    }
}
