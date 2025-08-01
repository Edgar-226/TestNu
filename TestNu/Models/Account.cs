using System;

namespace TestNu.Models;

public class Account
{
    public bool Active { get; set; }
    public int AvailableLimit { get; set; }
    public List<Transaction1> History { get; set; }

    public Account(bool active, int availableLimit)
    {
        Active = active;
        this.AvailableLimit = availableLimit;
        History = new List<Transaction1>();
    }

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
}