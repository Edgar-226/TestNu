using System;

namespace TestNu.Models;

public class Account(bool active, int availableLimit)
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
}
