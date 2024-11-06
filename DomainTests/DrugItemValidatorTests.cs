using Domain.Entities;
using Domain.ValueObject;

namespace DomainTests;

public class DrugItemValidatorTests
{
    [Fact]
    public void ValidateDrugItem_WithValidData()
    {
        // Arrange
        var drugId = Guid.NewGuid();
        var drugStoreId = Guid.NewGuid();
        var drug = new Drug("Paracetamol", "PharmaCorp", "USA", new Country("USA", "USA"));
        var drugStore = new DrugStore("PharmaShop", 143, new Address("Town", "Street", "4"), "053378965" );
        var drugItem = new DrugItem(drugId, drugStoreId, 10.99m, 50, drug, drugStore);

        // Assert
        // Проверка, что объект создается без ошибок
    }

    [Fact]
    public void NotValidateDrugItem_WithNegativeCount()
    {
        // Arrange & Act
        var exception = Assert.Throws<System.Exception>(() => new DrugItem(Guid.NewGuid(), Guid.NewGuid(), 10.99m, -1, 
            new Drug("Paracetamol", "PharmaCorp", "USA", 
                new Country("USA", "USA")), 
            new DrugStore("PharmaShop", 143, new Address("Town", "Street", "4"), "053378965" )));

        // Assert
        Assert.Contains("Count", exception.Message); // Проверяем, что ошибка относится к полю Count
    }
}