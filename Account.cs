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
        private int _branch;
        private int _id;
        private double _balance;
        public int Branch 
        {
            get
            {
                return _branch;
            }
            set 
            {
                if (value <= 0)
                {
                    return;
                }
                _branch = value;
            }
        }
        public int Id 
        {
            get
            {
                return _id;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _id = value;
            } 
        }
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
                _balance = value;
            }
        }
        public Account(Client owner, int branch, int id, double balance)
        {
            Owner = owner;
            Branch = branch;
            Id = id;
            Balance = balance;
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
