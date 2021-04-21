using ObjectBank.Exceptions;
using System;

namespace ObjectBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine($"There are currently {Account.AccountsTotal} accounts.");
            Console.WriteLine($"The current Tax per operation is: {Account.OperationsTax}");
            Client janeClient = new Client("Jane Doe", 123100, "Software Developer");
            Account janeAccount = new Account(janeClient, 123, 123100, 1000.0);

            Client johnClient = new Client("John Doe", 123200, "Data Analyst");
            Account johnAccount = new Account(johnClient, 123, 123200, 2500.0);

            Console.WriteLine($"Account owner: {janeAccount.Owner.Name}. Branch: {janeAccount.Branch}. Account id: {janeAccount.Id}. Balance: ${janeAccount.Balance}.");
            Console.WriteLine($"Account owner: {johnAccount.Owner.Name}. Branch: {johnAccount.Branch}. Account id: {johnAccount.Id}. Balance: ${johnAccount.Balance}.");
            Console.WriteLine($"There are currently {Account.AccountsTotal} accounts.");
            Console.WriteLine($"The current Tax per operation is: {Account.OperationsTax}");
            try
            {
                Client crowleyClient = new Client("Mr. Crowley", 123666, "Charming and Alarming");
                Account crowleyAccount = new Account(crowleyClient, 123, 0, 666.0);
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {
                janeAccount.Transfer(2000, johnAccount);
            }
            catch (InsufficientBalanceException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        
        }
    }
}