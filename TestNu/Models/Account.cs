using System;

namespace TestNu.Models;

public class Account(bool active = false, int availableLimit = 0)
{
    public bool Active { get; set; } = active;
    public int AvailableLimit { get; set; } = availableLimit;
    public List<Transaction1> History { get; set; } = [];

    public void AddTransaction(Transaction1 transaction)
    {
        History.Add(transaction);
    }

    public void AddTransactions(List<Transaction1> transactions)
    {
        History.AddRange(transactions);
    }

    public override string ToString()
    {
        return $"Account Active: {Active}, Available Limit: {AvailableLimit}, Transactions Count: {History.Count}";
    }



    public outputAuthorization ValidateTransaction(Transaction1 transactio)
    {


        var violations = new List<string>();

        //Validate is active account
        if (!Active)
        {
            violations.Add("account-not-active");
        }

        //Validate transaction values percent  
        var availableLimit90Percent = AvailableLimit * .9;
        if (transactio.Amount > availableLimit90Percent)
        {
            violations.Add("first-transaction-above-threshold");
        }


        //Validate Insufficient limit 
        if (transactio.Amount > AvailableLimit )
        {
            violations.Add("insufficient-limit");
        }

        /// Process the transacctions 

        if (violations.Count == 0)
        {         
            AddTransaction(transactio);
        }

        return new outputAuthorization
        {
            Account = this,
            Violations = violations
        };

    }

}


public class outputAuthorization
{
    public Account Account { get; set; }
    public List<string> Violations { get; set; }

}