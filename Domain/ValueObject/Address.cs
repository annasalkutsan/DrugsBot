namespace Domain.ValueObject;

/// <summary>
/// Адрес
/// </summary>
public class Address : BaseValueObject
{
    public Address(string city, string street, string house)
    {
        City = city;
        Street = street;
        House = house;
    }

    /// <summary>
    /// Город
    /// </summary>
    public string City { get; private set; }
    
    /// <summary>
    /// Улица
    /// </summary>
    public string Street { get; private set; }
    
    /// <summary>
    /// Дом
    /// </summary>
    public string House { get; private set; }
    
    /// <summary>
    /// Возвращает строковое представление адреса.
    /// </summary>
    /// <returns>Строка, представляющая адрес.</returns>
    public override string ToString()
    {
        return $"{City}, {Street} {House}";
    }
}