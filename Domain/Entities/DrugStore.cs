using Domain.Validators;
using Domain.ValueObject;
using FluentValidation.Results;

namespace Domain.Entities;

/// <summary>
/// Аптека
/// </summary>
public class DrugStore : BaseEntity<DrugStore>
{
    public DrugStore(){}
    public DrugStore(string drugNetwork, int number, Address address, string phoneNumber)
    {
        DrugNetwork = drugNetwork;
        Number = number;
        Address = address;
        PhoneNumber = phoneNumber;

        ValidateEntity(new DrugStoreValidator());
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
}