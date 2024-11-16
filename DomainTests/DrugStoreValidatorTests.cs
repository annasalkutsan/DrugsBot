using Domain.Entities;
using Domain.ValueObject;

namespace DomainTests;

public class DrugStoreValidatorTests
{/*
    [Fact]
    public void ValidateDrugStore_WithValidData()
    {
        // Arrange
        var address = new Address("CityName", "Main Street", "12A", "456789", "US");
        var drugStore = new DrugStore("PharmaNetwork", 1, address, "+1234567890");

        // Act & Assert
        var exception = Record.Exception(() => drugStore); // Проверяем, что исключение не возникает
        Assert.Null(exception);
    }

    [Fact]
    public void ValidateDrugStore_WithEmptyDrugNetwork()
    {
        // Arrange
        var address = new Address("CityName", "Main Street", "12A", "456789", "UK");

        // Act & Assert
        var exception = Assert.Throws<Exception>(() => new DrugStore("", 1, address, "+1234567890"));
        Assert.Contains("Drug Network", exception.Message); // Проверяем, что ошибка относится к полю DrugNetwork
    } 
    
  
    [Fact]
    public void ValidateDrugStore_WithNonUniqueNumber()
    {
        // Arrange
        var address = new Address("CityName", "Main Street", "12A", "456789", "US");
        var drugStore1 = new DrugStore("PharmaNetwork", 10, address, "+1234567890"); // Первый объект с номером 10

        // Act
        // Попытка создать второй объект с таким же номером
        DrugStore drugStore2 = null;
        var exception = Record.Exception(() => 
        {
            drugStore2 = new DrugStore("PharmaNetwork", 10, address, "+0987654321");
        });

        // Assert
        Assert.NotNull(exception); // Ожидаем, что будет выброшено исключение
        Assert.IsType<System.Exception>(exception); // Проверяем, что исключение типа ArgumentException
        Assert.Equal("Validation failed: Номер аптеки должен быть уникальным в пределах сети.", exception?.Message); // Проверяем сообщение исключения
    }*/
}