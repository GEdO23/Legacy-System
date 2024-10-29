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
            clientSystem.AddCliente(1, "Joao", "joao@email.com");
            clientSystem.AddCliente(2, "Maria", "maria@email.com");

            TransactionSystem transactionSystem = new TransactionSystem();
            transactionSystem.AdicionarTransacao(1, 100.50m, "Compra de Produto");
            transactionSystem.AdicionarTransacao(2, 200.00m, "Compra de Serviço");
            transactionSystem.AdicionarTransacao(3, 300.75m, "Compra de Software");

            clientSystem.ExibirTodosOsClientes();
            transactionSystem.ExibirTransacoes();

            clientSystem.removerCliente(1);
            clientSystem.ExibirTodosOsClientes();

            clientSystem.AtualizarNomeCliente(2, "Maria Silva");

            string nomeEmpresa = "Empresa Teste";
            string descricaoTransacao = "Compra de Insumo";

            Console.WriteLine("Nome da Empresa: " + nomeEmpresa + " Descrição: " + descricaoTransacao);
            
            Report report = new Report();
            report.GerarRelatorioCliente(clientSystem.clientes);

            int soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += i;
            }

            Console.WriteLine("Soma total: " + soma);
        }
    }
}