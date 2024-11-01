namespace Domain.ValueObject;

public class Address
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
}