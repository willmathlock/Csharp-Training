using System.Collections.Generic;
using System;
using System.Text;
using MySuperBank;

public class BankAccount
{
    // Properties
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance
    {
        get

        {
            decimal balance = 0;
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
            }

            return balance;
        }

    }
    private static int accountNumberSeed = 1234567890;
    private List<Transaction> allTransactions = new List<Transaction>();
    // Constructor
    public BankAccount(string name, decimal initialBalance)
    {
        this.Owner = name;
        this.Number = accountNumberSeed.ToString();
        MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

        accountNumberSeed++;      
    }

    // Functions
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if(amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
        var deposit = new Transaction(amount, date, note);
        allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
        }else if(Balance - amount < 0){
            throw new ArgumentOutOfRangeException(nameof(amount), "Not enough balance");
        }
        else
        {
            var withdrawal = new Transaction(amount, date, note);
            allTransactions.Add(withdrawal);
        }

    }

    public void listTransaction()
    {
        foreach(var item in allTransactions)
        {
            Console.WriteLine("Amount: " + item.Amount + "\nDate: " + item.Date + "\nNote: " + item.Notes);
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
        }
    }

}