using System;

namespace TestNu.Models;

public class Transaction1
{
    public string Merchant { get; set; }
    public int Amount { get; set; }
    public DateTime Time { get; set; }

    public Transaction1(string merchant, int amount, DateTime time)
    {
        Merchant = merchant;
        Amount = amount;
        Time = time;
    }

    public override string ToString()
    {
        return $"{Merchant} {Amount} {Time}";
    }

}
