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
            Owner = owner;
            Branch = branch;
            Id = id;
            Balance = balance;
            AccountsTotal++;
            OperationsTax = 30 / AccountsTotal;
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
            if (amount > _balance)
            {
                return false;
            }
            _balance -= amount;
            recipient.Deposit(amount);
            return true;
        }
    }
}