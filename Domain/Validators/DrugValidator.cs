using Domain.Entities;
using FluentValidation;

namespace Domain.Validators;

public class DrugValidator:AbstractValidator<Drug>
{
    DrugValidator()
    {
        RuleFor(d => d.Name)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Length(2, 40).WithMessage(ValidationMessage.WrongLength);
        
        RuleFor(drug => drug.Manufacturer)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .MaximumLength(100).WithMessage(ValidationMessage.WrongLength);

        RuleFor(drug => drug.CountryCodeId)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Must(BeValidCountryCode).WithMessage(ValidationMessage.WrongLength);
    }
    private bool BeValidCountryCode(string countryCode)
    {
        return countryCode != null && countryCode.Length == 3;
    }
}