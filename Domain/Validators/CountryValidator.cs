using Domain.Entities;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Domain.Validators;

public class CountryValidator : AbstractValidator<Country>
{
    public CountryValidator()
    {
        // Name validation
        RuleFor(c => c.Name)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Length(2, 100).WithMessage(ValidationMessage.WrongLength)
            .Matches("^[a-zA-Z ]+$").WithMessage(ValidationMessage.InvalidCharacters); 

        // Code validation
        RuleFor(c => c.Code)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Must(BeValidCountryCode).WithMessage("Поле должно состоять из 2 заглавных латинских букв");
    }

    private bool BeValidCountryCode(string code)
    {
        // Проверка на 2 заглавные латинские буквы
        return code != null && Regex.IsMatch(code, "^[A-Z]{2}$");
    }
}