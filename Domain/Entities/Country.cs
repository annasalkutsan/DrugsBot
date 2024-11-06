namespace Domain.Entities;

public class Country:BaseEntity 
{
    public Country(string name, string code)
    {
        Name = name;
        Code = code;
    }
    
    /// <summary>
    /// Название страны
    /// </summary>
    public string Name { get; private set; }
    
    /// <summary>
    /// Код страны
    /// </summary>
    public string Code { get; private set; }
    
    /// <summary>
    /// Коллекция препаратов, производимых в этой стране
    /// </summary>
    public ICollection<Drug> Drugs { get; private set; } = new List<Drug>();
}