namespace console;

#region Client Related Classes

class Client
{
    public int Id;
    public string Name;
    public string Email;

    public Client(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }

    public void SetName(string name)
    {
        const int minimumNumberOfCharacters = 0;

        if (name.Length > minimumNumberOfCharacters)
        {
            Name = name;
        }
    }
}

class ClientSystem
{
    public List<Client> ClientList = [];

    public void DisplayAllClients()
    {
        const string dividerCharacter = " | ";
        const string clientIdLabel = "ID: ";
        const string clientNameLabel = "Name: ";
        const string clientEmailLabel = "Email: ";

        foreach (var client in ClientList)
        {
            Console.WriteLine(
                clientIdLabel
                + client.Id
                + dividerCharacter
                + clientNameLabel
                + client.Name
                + dividerCharacter
                + clientEmailLabel
                + client.Email
            );
        }
    }

    public void AddClient(int id, string name, string email)
    {
        ClientList.Add(new Client(id, name, email));
    }

    public void UpdateClientName(int id, string newName)
    {
        Client foundClient = ClientList.Find(c => c.Id == id);
        if (foundClient != null)
        {
            foundClient.SetName(newName);
        }
    }

    public void RemoveClient(int id)
    {
        Client foundClient = ClientList.Find(c => c.Id == id);
        if (foundClient != null)
        {
            ClientList.Remove(foundClient);
        }
    }
}

#endregion

#region Transaction Related Classes

class Transaction
{
    public int Id;
    public decimal Price;
    public string Description;

    public Transaction(int id, decimal price, string description)
    {
        Id = id;
        Price = price;
        Description = description;
    }
}

class TransactionSystem
{
    public List<Transaction> TransactionsList = [];

    public void DisplayAllTransactions()
    {
        const string dividerCharacter = " | ";
        const string transactionIdLabel = "Id: ";
        const string transactionPriceLabel = "Price: ";
        const string transactionDescriptionLabel = "Description: ";

        foreach (var transaction in TransactionsList)
        {
            Console.WriteLine(
                transactionIdLabel
                + transaction.Id
                + dividerCharacter
                + transactionPriceLabel
                + transaction.Price
                + dividerCharacter
                + transactionDescriptionLabel
                + transaction.Description
            );
        }
    }

    public void AddTransaction(int id, decimal price, string description)
    {
        Transaction transaction = new(id, price, description);
        TransactionsList.Add(transaction);
    }
}

#endregion

#region Report Related Classes

class Report
{
    public void GenerateClientReport(List<Client> clientList)
    {
        const string dividerCharacter = " | ";
        const string clientNameLabel = "Client: ";
        const string clientEmailLabel = "Email: ";

        foreach (var client in clientList)
        {
            Console.WriteLine(
                clientNameLabel
                + client.Name
                + dividerCharacter
                + clientEmailLabel
                + client.Email
            );
        }
    }
}

#endregion