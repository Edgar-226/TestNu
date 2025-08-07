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

    [Fact]
    public void ValidateTransactionTest()
    {
        var account = new Account(true, 1000);
        var transaction = new Transaction1("Café", 15, DateTime.Now);

        var result = account.ValidateTransaction(transaction);

        Assert.Empty(result.Violations);
        Assert.Contains(transaction, result.Account.History);

    }

    [Fact]
    public void ValidateTransactionViolation()
    {
        var account = new Account(false, 1000);
        var transaction = new Transaction1("Café", 15, DateTime.Now);

        var result = account.ValidateTransaction(transaction);

        Assert.Empty(account.History);
        Assert.Contains("account-not-active", result.Violations);

    }


    [Fact]
    public void ValidateTransactionAmountAboveLimit90Percent()
    {
        var account = new Account(true, 100);
        var transaction = new Transaction1("Café", 91, DateTime.Now);

        var result = account.ValidateTransaction(transaction);

        Assert.Empty(account.History);
        Assert.Contains("first-transaction-above-threshold", result.Violations);


    }


    [Fact]
    public void ValidateTransactionInsufficentLimit()
    {
        var account = new Account(true, 100);
        var transaction = new Transaction1("Café", 101, DateTime.Now);

        var result = account.ValidateTransaction(transaction);

        Assert.Empty(account.History);
        Assert.Contains("insufficient-limit", result.Violations);


    }

    [Fact]
    public void ValidateViolations()
    {
        var account = new Account(false, 100);
        var transaction = new Transaction1("Café", 104, DateTime.Now);

        var result = account.ValidateTransaction(transaction);

        Assert.Empty(account.History);
        Assert.Contains("account-not-active", result.Violations);
        Assert.Contains("first-transaction-above-threshold", result.Violations);
        Assert.Contains("insufficient-limit", result.Violations);

    }
}
