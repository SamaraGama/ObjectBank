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

            //account1.owner = "Samara";
            account1.Branch = 1234;
            account1.Id = 12341;
            account1.Balance = 50.0;

            Console.WriteLine($"Account owner: {account1.Owner}. Branch: {account1.Branch}. Account id: {account1.Id}. Balance: ${account1.Balance}.");
            Console.ReadLine();

        }
    }
}
