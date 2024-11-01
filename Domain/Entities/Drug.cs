namespace Domain.Entities;

/// <summary>
/// Лекарственный препарат
/// </summary>
public class Drug: BaseEntity
{
    /// <summary>
    /// Название лекарственного препарата
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Производитель
    /// </summary>
    public string Manufacturer { get; set; }
    
    /// <summary>
    /// Код страны производителя 
    /// </summary>
    public string CountryCodeId { get; set; }
    
    /// <summary>
    /// Навигационное свойство для страны
    /// </summary>
    public Country Country { get; set; }

    /// <summary>
    /// Коллекция товаров с данным препаратом
    /// </summary>
    public ICollection<DrugItem> DrugItems { get; set; }
}