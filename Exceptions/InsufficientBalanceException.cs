using System;
using ObjectBank;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBank.Exceptions
{
    class InsufficientBalanceException : Exception
    {
        public double Balance { get; }
        public double Value { get; set; }
        public InsufficientBalanceException()
        {
                
        }
        public InsufficientBalanceException(double balance, double value) : this($"Not able to operate {value} on an account with a {balance} balance.")
        {
            Balance = balance;
            Value = value;
        }
        public InsufficientBalanceException(string message) : base(message)
        {

        }
    }
}
