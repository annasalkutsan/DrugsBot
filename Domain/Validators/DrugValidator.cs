using Domain.Entities;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Domain.Validators;

public class DrugValidator : AbstractValidator<Drug>
{
    public DrugValidator()
    {
        // Name validation
        RuleFor(d => d.Name)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Length(2, 150).WithMessage(ValidationMessage.WrongLength)  
            .Matches("^[a-zA-Z ]+$").WithMessage(ValidationMessage.InvalidCharacters); 

        // Manufacturer validation
        RuleFor(drug => drug.Manufacturer)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Length(2, 100).WithMessage(ValidationMessage.WrongLength) 
            .Matches("^[a-zA-Z\\- ]+$").WithMessage(ValidationMessage.InvalidCharacters); 
        
        // CountryCodeId validation
        RuleFor(drug => drug.CountryCodeId)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Must(BeValidCountryCode).WithMessage("Указанный код страны не существует");
    }

    private bool BeValidCountryCode(string countryCode)
    {
        // Проверка на 2 заглавные буквы
        return countryCode != null && Regex.IsMatch(countryCode, "^[A-Z]{3}$");
    }
}