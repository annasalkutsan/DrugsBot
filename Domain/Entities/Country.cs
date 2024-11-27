using Domain.Validators;
using FluentValidation.Results;

namespace Domain.Entities;

/// <summary>
/// Страна
/// </summary>
public class Country:BaseEntity<Country>
{
    public Country(){}
    public Country(string name, string code)
    {
        Name = name;
        Code = code;

        ValidateEntity(new CountryValidator());
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