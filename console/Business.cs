using System;
using System.Collections.Generic;
using System.IO;

namespace LegacySystem
{
    #region Client Related Classes

    class Client
    {
        public int Id;
        public string nome;
        public string EMAIL;

        public Client(int i, string n, string e)
        {
            Id = i;
            nome = n;
            EMAIL = e;
        }

        public void mudarNome(string n)
        {
            if (n != null && n.Length > 0)
            {
                nome = n;
            }
        }
    }

    class ClientSystem
    {
        public List<Client> clientes = new List<Client>();

        public void ExibirTodosOsClientes()
        {
            foreach (Client c in clientes)
            {
                Console.WriteLine("ID: " + c.Id + " Nome: " + c.nome + " Email: " + c.EMAIL);
            }
        }

        public void AddCliente(int id, string nome, string email)
        {
            clientes.Add(new Client(id, nome, email));
        }

        public void AtualizarNomeCliente(int id, string nome)
        {
            Client c = clientes.Find(x => x.Id == id);
            if (c != null)
            {
                c.mudarNome(nome);
            }
        }

        public void removerCliente(int id)
        {
            Client c = clientes.Find(x => x.Id == id);
            if (c != null)
            {
                clientes.Remove(c);
            }
        }
    }

    #endregion

    #region Transaction Related Classes

    class Transaction
    {
        public int id;
        public decimal v;
        public string descricao;

        public Transaction(int i, decimal val, string desc)
        {
            id = i;
            v = val;
            descricao = desc;
        }
    }

    class TransactionSystem
    {
        public List<Transaction> listaDeTransacoes = new List<Transaction>();

        public void AdicionarTransacao(int id, decimal valor, string descricao)
        {
            Transaction t = new Transaction(id, valor, descricao);
            listaDeTransacoes.Add(t);
        }

        public void ExibirTransacoes()
        {
            foreach (var transacao in listaDeTransacoes)
            {
                Console.WriteLine("Id: " + transacao.id + " Valor: " + transacao.v + " Descrição: " +
                                  transacao.descricao);
            }
        }
    }

    #endregion

    #region Report Related Classes

    class Report
    {
        public void GerarRelatorioCliente(List<Client> clientes)
        {
            foreach (var c in clientes)
            {
                Console.WriteLine("Cliente: " + c.nome + " | Email: " + c.EMAIL);
            }
        }
    }

    #endregion
}