using System;
using System.Threading;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} dollars");


            account.MakeDeposit(1212, DateTime.Now, "Teste teste");
            Thread.Sleep(2000);
            account.MakeDeposit(12127, DateTime.Now, "Teste teste");
            Thread.Sleep(60);
            account.MakeDeposit(1217, DateTime.Now, "Teste teste");
            account.MakeDeposit(127, DateTime.Now, "Teste teste");
            Thread.Sleep(2000);
            account.MakeDeposit(127, DateTime.Now, "Teste teste");
            Thread.Sleep(60);
            account.MakeDeposit(1217, DateTime.Now, "Teste teste");
            account.MakeDeposit(127, DateTime.Now, "Teste teste");
            account.MakeDeposit(1217, DateTime.Now, "Teste teste");
            Thread.Sleep(2000);
            account.MakeDeposit(12117, DateTime.Now, "Teste teste");
            account.MakeDeposit(12117, DateTime.Now, "Teste teste");
            Thread.Sleep(2000);
            account.MakeDeposit(12117, DateTime.Now, "Teste teste");
            Thread.Sleep(60);
            account.MakeDeposit(12117, DateTime.Now, "Teste teste");
            account.MakeDeposit(12117, DateTime.Now, "Teste teste");
            Thread.Sleep(2000);
            account.MakeDeposit(12117, DateTime.Now, "Teste teste");
            account.MakeDeposit(127, DateTime.Now, "Teste teste");
            Thread.Sleep(2000);
            account.MakeDeposit(117, DateTime.Now, "Teste teste");
            account.MakeWithdrawal(1113, DateTime.Now, "Tirei tirei");
            Thread.Sleep(60);
            account.MakeWithdrawal(113, DateTime.Now, "Tirei tirei");
            Thread.Sleep(2000);
            account.MakeWithdrawal(113, DateTime.Now, "Tirei tirei");
            account.MakeWithdrawal(1113, DateTime.Now, "Tirei tirei");
            Thread.Sleep(2000);
            account.MakeWithdrawal(11, DateTime.Now, "Tirei tirei");
            account.MakeWithdrawal(1113, DateTime.Now, "Tirei tirei");
            Thread.Sleep(60);
            account.MakeWithdrawal(1113, DateTime.Now, "Tirei tirei");
            account.MakeWithdrawal(13, DateTime.Now, "Tirei tirei");
            account.MakeWithdrawal(913, DateTime.Now, "Tirei tirei");
            Thread.Sleep(60);
            account.MakeWithdrawal(1113, DateTime.Now, "Tirei tirei");

            account.listTransaction();
        }
    }
}
