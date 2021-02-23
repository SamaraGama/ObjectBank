using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();

            account1.owner = "Samara";
            account1.branch = 1234;
            account1.account = 12341;
            account1.balance = 50.0;

            Console.WriteLine($"Account owner: {account1.owner}. Branch: {account1.branch}. Account id: {account1.account}. Balance: ${account1.balance}.");
            Console.ReadLine();

        }
    }
}
