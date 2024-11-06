using Domain.Entities;
using Domain.Validators;
using FluentValidation.TestHelper;

namespace DomainTests;

public class DrugValidatorTests
{
    [Fact]
    public void ValidateDrug_WithValidData()
    {
        // Arrange
        var drug = new Drug("Paracetamol", "PharmaCorp", "USA", new Country("USA", "USA"));
        var validator = new DrugValidator();

        // Act & Assert
        var result = validator.TestValidate(drug);
        result.ShouldNotHaveAnyValidationErrors(); // Проверка, что нет ошибок валидации
    }
    
    [Fact]
    public void NotValidateDrug_WithEmptyCountryCode()
    {
        // Arrange & Act
        var exception = Assert.Throws<System.Exception>(() => new Drug("Paracetamol", "PharmaCorp", "", new Country("USA", "USA")));

        // Assert
        Assert.Contains("Country Code Id", exception.Message); // Проверяем, что ошибка относится к CountryCodeId
    }

}