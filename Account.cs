using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBank
{
    class Account
    {
        public Client owner { get; set; }
        public int  branch { get; set; }
        public int account { get; set; }
        public double balance { get; set; }

        //public Account(string owner, int branch, int account, double balance)
        //{

        //}

        public bool Withdraw(double amount) 
        {
            if (amount > balance)
            {
                return false;
            }
            balance -= amount;
            return true;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public bool Transfer(double amount, Account recipient)
        {
            if(amount > balance)
            {
                return false;
            }
            balance -= amount;
            recipient.Deposit(amount);
            return true;
        }

    }
}
