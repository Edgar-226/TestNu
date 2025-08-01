using System;
using TestNu.Models;
using Xunit;

public class Transaction1Tests
{
    [Fact]
    public void Constructor_Transaction1()
    {
        // Arrange
        var merchant = "Café";
        var amount = 15;
        var time = new DateTime(2025, 7, 31);

        // Act
        var transaction = new Transaction1(merchant, amount, time);

        // Assert
        Assert.Equal(merchant, transaction.Merchant);
        Assert.Equal(15, transaction.Amount);
        Assert.Equal(time, transaction.Time);
    }
}