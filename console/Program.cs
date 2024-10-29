using System;
using System.Collections.Generic;
using System.IO;

namespace LegacySystem
{
    class MainSistema
    {
        static void Main(string[] args)
        {
            ClientSystem clientSystem = new ClientSystem();
            clientSystem.AddClient(1, "Joao", "joao@email.com");
            clientSystem.AddClient(2, "Maria", "maria@email.com");

            TransactionSystem transactionSystem = new TransactionSystem();
            transactionSystem.AddTransaction(1, 100.50m, "Compra de Produto");
            transactionSystem.AddTransaction(2, 200.00m, "Compra de Serviço");
            transactionSystem.AddTransaction(3, 300.75m, "Compra de Software");

            clientSystem.DisplayAllClients();
            transactionSystem.DisplayAllTransactions();

            clientSystem.RemoveClient(1);
            clientSystem.DisplayAllClients();

            clientSystem.UpdateClientName(2, "Maria Silva");

            string nomeEmpresa = "Empresa Teste";
            string descricaoTransacao = "Compra de Insumo";

            Console.WriteLine("Nome da Empresa: " + nomeEmpresa + " Descrição: " + descricaoTransacao);
            
            Report report = new Report();
            report.GenerateClientReport(clientSystem.ClientList);

            int soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += i;
            }

            Console.WriteLine("Soma total: " + soma);
        }
    }
}