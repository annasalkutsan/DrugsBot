using Domain.Validators;
using Domain.ValueObject;
using FluentValidation.Results;

namespace Domain.Entities;

public class DrugStore:BaseEntity
{
    public DrugStore(string drugNetwork, int number, Address address, string phoneNumber)
    {
        DrugNetwork = drugNetwork;
        Number = number;
        Address = address;
        PhoneNumber = phoneNumber;

        IsValid();
    }
    
    /// <summary>
    /// Название аптечной сети
    /// </summary>
    public string DrugNetwork { get; private set; }
    
    /// <summary>
    /// Номер аптеки
    /// </summary>
    public int Number { get; private set; }
    
    /// <summary>
    /// Адресс
    /// </summary>
    public Address Address { get; private set; }
    
    /// <summary>
    /// Номер телефона
    /// </summary>
    public string PhoneNumber { get; private set; }
    
    /// <summary>
    /// Коллекция товаров в аптеке
    /// </summary>
    public ICollection<DrugItem> DrugItems { get; private set; } = new List<DrugItem>();
    
    private bool IsValid()
    {
        var validator = new DrugStoreValidator();
        ValidationResult result = validator.Validate(this);

        if (!result.IsValid)
        {
            var errorMessages = string.Join(" ", result.Errors.Select(e => e.ErrorMessage));
            throw new Exception("Validation failed: " + errorMessages);
        }
        
        return true;
    }
}