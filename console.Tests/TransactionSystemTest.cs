using Xunit;

namespace console.Tests;

public class TransactionSystemTest
{
    [Fact]
    public void AddTransaction_ShouldAddTransactionToList()
    {
        // Arrange
        var transactionSystem = new TransactionSystem();
        const int transactionIdTest = 1;
        const decimal transactionPriceTest = 100.50m;
        const string transactionDescriptionTest = "Product Purchase";

        // Act
        transactionSystem.AddTransaction(
            transactionIdTest,
            transactionPriceTest,
            transactionDescriptionTest
        );

        // Assert
        Assert.Single(transactionSystem.TransactionsList);
    }
}