using System;
using Xunit;

namespace console.Tests;

public class ClientSystemTest
{
    [Fact]
    public void AddClient_ShouldAddClientToList()
    {
        // Arrange
        var clientSystem = new ClientSystem();
        const int clientIdTest = 1;
        const string clientNameTest = "Ana Paula";
        const string clientEmailTest = "ana123@hotmail.com";

        // Act
        clientSystem.AddClient(
            clientIdTest,
            clientNameTest,
            clientEmailTest
        );

        // Assert
        Assert.Single(clientSystem.ClientList);
    }

    [Fact]
    public void UpdateClientName_ShouldUpdateClientNameFromList()
    {
        // Arrange
        var clientSystem = new ClientSystem();
        const int clientIdTest = 1;
        const string clientNameTest = "Ana Paula";
        const string clientEmailTest = "ana123@hotmail.com";
        const string clientNewNameTest = "Ana Rodriguez";

        clientSystem.AddClient(
            clientIdTest,
            clientNameTest,
            clientEmailTest
        );

        // Act
        clientSystem.UpdateClientName(clientIdTest, clientNewNameTest);

        // Assert
        Assert.Equal(clientNewNameTest, clientSystem.ClientList[0].Name);
    }

    [Fact]
    public void UpdateClientName_ShouldNotAddANewClientToTheList()
    {
        // Arrange
        var clientSystem = new ClientSystem();
        const int clientIdTest = 1;
        const string clientNameTest = "Ana Paula";
        const string clientEmailTest = "ana123@hotmail.com";
        const string clientNewNameTest = "Ana Rodriguez";

        clientSystem.AddClient(
            clientIdTest,
            clientNameTest,
            clientEmailTest
        );

        // Act
        clientSystem.UpdateClientName(clientIdTest, clientNewNameTest);

        // Assert
        Assert.Single(clientSystem.ClientList);
    }

    [Fact]
    public void UpdateClientName_ShouldNotUpdate_IfRequestedClient_IsNotFound()
    {
        // Arrange
        var clientSystem = new ClientSystem();
        const int clientIdTest = 1;
        const int clientWrongIdTest = 2;
        const string clientNameTest = "Ana Paula";
        const string clientEmailTest = "ana123@hotmail.com";
        const string clientNewNameTest = "Ana Rodriguez";

        clientSystem.AddClient(
            clientIdTest,
            clientNameTest,
            clientEmailTest
        );

        // Act
        clientSystem.UpdateClientName(clientWrongIdTest, clientNewNameTest);

        // Assert
        Assert.Equal(clientNameTest, clientSystem.ClientList[0].Name);
    }

    [Fact]
    public void UpdateClientName_ShouldNotUpdate_IfNewNameLength_IsBelowTheMinimumNumberOfCharacters()
    {
        // Arrange
        var clientSystem = new ClientSystem();
        const int clientIdTest = 1;
        const string clientNameTest = "Ana Paula";
        const string clientEmailTest = "ana123@hotmail.com";
        const string clientNewNameTest = "";

        clientSystem.AddClient(
            clientIdTest,
            clientNameTest,
            clientEmailTest
        );

        // Act
        clientSystem.UpdateClientName(clientIdTest, clientNewNameTest);

        // Assert
        Assert.Equal(clientNameTest, clientSystem.ClientList[0].Name);
    }

    [Fact]
    public void RemoveClient_ShouldRemoveClientFromList()
    {
        // Arrange
        var clientSystem = new ClientSystem();
        const int clientIdTest = 1;
        const string clientNameTest = "Ana Paula";
        const string clientEmailTest = "ana123@hotmail.com";

        clientSystem.AddClient(
            clientIdTest,
            clientNameTest,
            clientEmailTest
        );

        // Act
        clientSystem.RemoveClient(clientIdTest);

        // Assert
        Assert.Empty(clientSystem.ClientList);
    }
}