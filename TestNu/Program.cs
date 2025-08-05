// See https://aka.ms/new-console-template for more information
using TestNu.Models;

Console.WriteLine("Hello, World!");

var transactions = new List<Transaction1>
{
    new("Starbucks", 5, DateTime.Now),
    new("McDonald's", 10, DateTime.Now),
};

foreach (var transaction in transactions)
{
    Console.WriteLine(transaction);
}

var account = new Account(true, 500);

account.AddTransactions(transactions);

Console.WriteLine(account);
