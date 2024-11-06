using Domain.Validators;
using FluentValidation.Results;

namespace Domain.Entities;

public class Country:BaseEntity 
{
    public Country(string name, string code)
    {
        Name = name;
        Code = code;

        IsValid();
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
    
    private bool IsValid()
    {
        var validator = new CountryValidator();
        ValidationResult result = validator.Validate(this);

        if (!result.IsValid)
        {
            var errorMessages = string.Join(" ", result.Errors.Select(e => e.ErrorMessage));
            throw new Exception("Validation failed: " + errorMessages);
        }
        
        return true;
    }
}