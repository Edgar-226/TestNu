using System;
using TestNu.Models;
using Xunit;

public class AccountTest
{
    [Fact]
    public void Constructor_Account()
    {
        // Arrange
        var isActive = true;
        int avaiableLimit = 1000;
        var history = new List<Transaction1>
        {
            new("Café", 15, new DateTime(2025, 7, 31)),
            new("Bookstore", 30, new DateTime(2025, 8, 1)),
        };
        // Act
        var account = new Account(isActive, avaiableLimit);
        account.AddTransactions(history);
        // Assert
        Assert.Equal(isActive, account.Active);
        Assert.Equal(avaiableLimit, account.AvailableLimit);
        Assert.Equal(2, account.History.Count);
        Assert.Equal(
            $"Account Active: {isActive}, Available Limit: {avaiableLimit}, Transactions Count: {history.Count}",
            account.ToString()
        );
    }
}
