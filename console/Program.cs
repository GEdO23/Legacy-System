using console;

var clientSystem = new ClientSystem();
var transactionSystem = new TransactionSystem();
var report = new Report();

clientSystem.AddClient(id: 1, name: "Joao", email: "joao@email.com");
clientSystem.AddClient(id: 2, name: "Maria", email: "maria@email.com");

transactionSystem.AddTransaction(id: 1, price: 100.50m, description: "Product Purchase");
transactionSystem.AddTransaction(id: 2, price: 200.00m, description: "Service Purchase");
transactionSystem.AddTransaction(id: 3, price: 300.75m, description: "Software Purchase");

clientSystem.DisplayAllClients();
transactionSystem.DisplayAllTransactions();

clientSystem.RemoveClient(1);
clientSystem.DisplayAllClients();

clientSystem.UpdateClientName(id: 2, newName: "Maria Silva");

report.GenerateClientReport(clientSystem.ClientList);