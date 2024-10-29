using System;
using System.Collections.Generic;
using System.IO;

using console;

ClientSystem clientSystem = new();
clientSystem.AddClient(1, "Joao", "joao@email.com");
clientSystem.AddClient(2, "Maria", "maria@email.com");

TransactionSystem transactionSystem = new();
transactionSystem.AddTransaction(1, 100.50m, "Product Purchase");
transactionSystem.AddTransaction(2, 200.00m, "Service Purchase");
transactionSystem.AddTransaction(3, 300.75m, "Software Purchase");

clientSystem.DisplayAllClients();
transactionSystem.DisplayAllTransactions();

clientSystem.RemoveClient(1);
clientSystem.DisplayAllClients();

clientSystem.UpdateClientName(2, "Maria Silva");

string companyName = "Company Test";
string transactionDescription = "Purchase of Supplies";

Console.WriteLine("Company Name: " + companyName + " Description: " + transactionDescription);

Report report = new();
report.GenerateClientReport(clientSystem.ClientList);

int totalSum = 0;
for (int i = 0; i < 10; i++)
{
    totalSum += i;
}

Console.WriteLine("Total Sum: " + totalSum);