using ObjectBank.Exceptions;
using System;

namespace ObjectBank
{
    internal class Account
    {
        public static int AccountsTotal { get; private set; }
        public static double OperationsTax { get; private set; }
        public Client Owner { get; set; }
        private double _balance;

        public int Branch { get; }

        public int Id { get; }

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
            if (branch <= 0)
            {
                throw new ArgumentException("Branch Id must be higher than zero (0).", nameof(branch));
            }
            if (id <= 0)
            {
                throw new ArgumentException("Account Id must be higher than zero (0).", nameof(id));
            }

            Owner = owner;
            Branch = branch;
            Id = id;
            Balance = balance;
            AccountsTotal++;
            OperationsTax = 30 / AccountsTotal;
        }

        public void Withdraw(double amount)
        {
            if (amount > _balance)
            {
                throw new InsufficientBalanceException($"{Owner.Name} is unable to withdraw {amount} due to insufficient balance.");
            }
            _balance -= amount + OperationsTax;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Transfer(double amount, Account recipient)
        {
            if (amount > _balance)
            {
                throw new InsufficientBalanceException($"{Owner.Name} is unable to transfer {amount} due to insufficient balance.");
            }
            _balance -= amount + OperationsTax;
            recipient.Deposit(amount);
        }
    }
}