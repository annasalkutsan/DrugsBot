using Domain.ValueObject;

namespace Domain.Entities;

public class DrugStore:BaseEntity
{
    /// <summary>
    /// Название аптечной сети
    /// </summary>
    public string DrugNetwork { get; set; }
    
    /// <summary>
    /// Номер аптеки
    /// </summary>
    public int Number { get; set; }
    
    /// <summary>
    /// Адресс
    /// </summary>
    public Address Address { get; set; }
    
    /// <summary>
    /// Номер телефона
    /// </summary>
    public string PhoneNumber { get; set; }
    
    /// <summary>
    /// Коллекция товаров в аптеке
    /// </summary>
    public ICollection<DrugItem> DrugItems { get; set; }
}