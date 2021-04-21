using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBank.Exceptions
{
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException()
        {
                
        }
        public InsufficientBalanceException(string message) : base(message)
        {

        }
    }
}
