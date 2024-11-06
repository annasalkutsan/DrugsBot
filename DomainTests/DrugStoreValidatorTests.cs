using Domain.Entities;
using Domain.ValueObject;

namespace DomainTests;

public class DrugStoreValidatorTests
{
    [Fact]
    public void ValidateDrugStore_WithValidData()
    {
        // Arrange
        var address = new Address("CityName", "Main Street", "12A");
        var drugStore = new DrugStore("PharmaNetwork", 1, address, "+1234567890");

        // Act & Assert
        var exception = Record.Exception(() => drugStore); // Проверяем, что исключение не возникает
        Assert.Null(exception);
    }

    [Fact]
    public void ValidateDrugStore_WithEmptyDrugNetwork()
    {
        // Arrange
        var address = new Address("CityName", "Main Street", "12A");

        // Act & Assert
        var exception = Assert.Throws<Exception>(() => new DrugStore("", 1, address, "+1234567890"));
        Assert.Contains("Drug Network", exception.Message); // Проверяем, что ошибка относится к полю DrugNetwork
    } 
}