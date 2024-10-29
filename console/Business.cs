namespace console;

#region Client Related Classes

public class Client
{
    public int Id { get; }
    public string Name { get; private set; }
    public string Email { get; }

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

public class ClientSystem
{
    public readonly List<Client> ClientList = [];

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
        var foundClient = ClientList.Find(c => c.Id == id);
        if (foundClient != null)
        {
            foundClient.SetName(newName);
        }
    }

    public void RemoveClient(int id)
    {
        var foundClient = ClientList.Find(c => c.Id == id);
        if (foundClient != null)
        {
            ClientList.Remove(foundClient);
        }
    }
}

#endregion

#region Transaction Related Classes

public class Transaction
{
    public int Id { get; }
    public decimal Price { get; }
    public string Description { get; }

    public Transaction(int id, decimal price, string description)
    {
        Id = id;
        Price = price;
        Description = description;
    }
}

public class TransactionSystem
{
    public readonly List<Transaction> TransactionsList = [];

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

public class Report
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