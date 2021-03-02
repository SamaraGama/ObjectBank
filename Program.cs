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
            Client samaraClient = new Client("Samara Gama", 123100, "Software Developer");
            Account samaraAccount = new Account(samaraClient, 123, 123100, 1000.0);

            Console.WriteLine($"Account owner: {samaraAccount.Owner.Name}. Branch: {samaraAccount.Branch}. Account id: {samaraAccount.Id}. Balance: ${samaraAccount.Balance}.");
            Console.ReadLine();

        }
    }
}
