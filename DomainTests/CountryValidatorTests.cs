using Domain.Entities;

namespace DomainTests;

public class CountryValidatorTests
{
    [Fact]
    public void ValidateCountry_WithValidData()
    {
        // Arrange & Act
        var country = new Country("USA", "USA");

        // Assert
        // Проверка, что объект создается без ошибок
    }

    [Fact]
    public void NotValidateCountry_WithInvalidCode()
    {
        // Arrange & Act
        var exception = Assert.Throws<Exception>(() => new Country("USA", "U"));

        // Assert
        Assert.Contains("Code", exception.Message); // Проверяем, что ошибка относится к полю Code
    }
}