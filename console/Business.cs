using System;
using System.Collections.Generic;
using System.IO;

namespace LegacySystem
{
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
            if (name.Length > 0)
            {
                Name = name;
            }
        }
    }

    class ClientSystem
    {
        public List<Client> ClientList = new();

        public void DisplayAllClients()
        {
            foreach (Client client in ClientList)
            {
                Console.WriteLine("ID: " + client.Id + " Name: " + client.Name + " Email: " + client.Email);
            }
        }

        public void AddClient(int id, string name, string email)
        {
            ClientList.Add(new Client(id, name, email));
        }

        public void UpdateClientName(int id, string nome)
        {
            Client client = ClientList.Find(c => c.Id == id);
            if (client != null)
            {
                client.SetName(nome);
            }
        }

        public void RemoveClient(int id)
        {
            Client client = ClientList.Find(c => c.Id == id);
            if (client != null)
            {
                ClientList.Remove(client);
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
            foreach (var transaction in TransactionsList)
            {
                Console.WriteLine("Id: " + transaction.Id + " Price: " + transaction.Price + " Description: " +
                                  transaction.Description);
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
        public void GenerateClientReport(List<Client> clientes)
        {
            foreach (var client in clientes)
            {
                Console.WriteLine("Client: " + client.Name + " | Email: " + client.Email);
            }
        }
    }

    #endregion
}