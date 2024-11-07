namespace Domain.ValueObject;

public class Address : BaseValueObject
{
    public Address(string city, string street, string house, string postalCode, string country)
    {
        City = city;
        Street = street;
        House = house;
        PostalCode = postalCode;
        Country = country;
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
    /// Почтовый код
    /// </summary>
    public string PostalCode { get; private set; }
    
    /// <summary>
    /// Код страны (ISO)
    /// </summary>
    public string Country { get; private set; }

    /// <summary>
    /// Возвращает строковое представление адреса.
    /// </summary>
    /// <returns>Строка, представляющая адрес.</returns>
    public override string ToString()
    {
        return $"{City}, {Street} {House}, {PostalCode}, {Country}";
    }
}