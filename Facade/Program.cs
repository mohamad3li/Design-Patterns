using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            BankService bankService = new BankService();
            bankService.CreateNewAccount(1,"saving",100);
            bankService.CreateNewAccount(2,"investment", 100);
            bankService.CreateNewAccount(3,"chequing", 100);
            bankService.TransferMoney(1, 2, 50);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Account {i+1} amount:{bankService.GetAccountAmount(i+1)}");
            }
            Console.ReadKey();
            
        }
    }
}
