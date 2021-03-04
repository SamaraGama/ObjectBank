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
            Client janeClient = new Client("Jane Doe", 123100, "Software Developer");
            Account janeAccount = new Account(janeClient, 123, 123100, 1000.0);

            Client johnClient = new Client("John Doe", 123200, "Data Analyst");
            Account johnAccount = new Account(johnClient, 123, 123200, 2500.0);

            Console.WriteLine($"Account owner: {janeAccount.Owner.Name}. Branch: {janeAccount.Branch}. Account id: {janeAccount.Id}. Balance: ${janeAccount.Balance}.");
            Console.WriteLine($"Account owner: {johnAccount.Owner.Name}. Branch: {johnAccount.Branch}. Account id: {johnAccount.Id}. Balance: ${johnAccount.Balance}.");
            Console.WriteLine($"There are currently {Account.AccountsTotal} accounts.");
            Console.ReadLine();

        }
    }
}
