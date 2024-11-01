namespace Domain.Entities;

public class Country:BaseEntity 
{
    /// <summary>
    /// Название страны
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Код страны
    /// </summary>
    public string Code { get; set; }
    
    /// <summary>
    /// Коллекция препаратов, производимых в этой стране
    /// </summary>
    public ICollection<Drug> Drugs { get; set; }
}