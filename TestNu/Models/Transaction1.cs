using System;

namespace TestNu.Models;

public class Transaction1(string merchant, int amount, DateTime time)
{
    public string Merchant { get; set; } = merchant;
    public int Amount { get; set; } = amount;
    public DateTime Time { get; set; } = time;

    public override string ToString()
    {
        return $"{Merchant} {Amount} {Time}";
    }
}
