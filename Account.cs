using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBank
{
    class Account
    {
        public Client Owner { get; set; }
        public int Branch { get; set; }
        public int Id { get; set; }
        private double _balance;

        //public Account(string owner, int branch, int account, double balance)
        //{

        //}
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
            }
        }

        public bool Withdraw(double amount) 
        {
            if (amount > _balance)
            {
                return false;
            }
            _balance -= amount;
            return true;
        }
        public void Deposit(double amount)
        {
            _balance += amount;
        }
        public bool Transfer(double amount, Account recipient)
        {
            if(amount > _balance)
            {
                return false;
            }
            _balance -= amount;
            recipient.Deposit(amount);
            return true;
        }

    }
}
