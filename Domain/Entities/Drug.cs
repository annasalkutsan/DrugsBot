namespace Domain.Entities;

/// <summary>
/// Лекарственный препарат
/// </summary>
public class Drug: BaseEntity
{
    public Drug(string name, string manufacturer, string countryCodeId, Country country)
    {
        Name = name;
        Manufacturer = manufacturer;
        CountryCodeId = countryCodeId;
        Country = country;
    }
    
    /// <summary>
    /// Название лекарственного препарата
    /// </summary>
    public string Name { get; private set; }
    
    /// <summary>
    /// Производитель
    /// </summary>
    public string Manufacturer { get; private set; }
    
    /// <summary>
    /// Код страны производителя 
    /// </summary>
    public string CountryCodeId { get; private set; }
    
    /// <summary>
    /// Навигационное свойство для страны
    /// </summary>
    public Country Country { get; private set; }

    /// <summary>
    /// Коллекция товаров с данным препаратом
    /// </summary>
    public ICollection<DrugItem> DrugItems { get; private set; } = new List<DrugItem>();
}