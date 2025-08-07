// See https://aka.ms/new-console-template for more information
using TestNu.Models;

//Console.WriteLine("Hello, World!");

//var transactions = new List<Transaction1>
//{
//    new("Starbucks", 5, DateTime.Now),
//    new("McDonald's", 10, DateTime.Now),
//    new("Amazon",20,new DateTime(2023, 10,01)),

//};

//foreach (var transaction in transactions)
//{
//    Console.WriteLine(transaction);
//}

//var account = new Account();

//account.AddTransactions(transactions);

//Console.WriteLine(account);



var account = new Account(true,10);
var transaction = new Transaction1("Starbucks", 11, DateTime.Now);



var result = account.ValidateTransaction(transaction);

Console.WriteLine(result.Account);
