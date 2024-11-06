using Domain.Entities;
using FluentValidation;

namespace Domain.Validators;

public class CountryValidator : AbstractValidator<Country>
{
    public CountryValidator()
    {
        RuleFor(c => c.Name)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Length(2, 100).WithMessage(ValidationMessage.WrongLength);

        RuleFor(c => c.Code)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Must(BeValidCountryCode).WithMessage(ValidationMessage.WrongLength);
    }
    private bool BeValidCountryCode(string code)
    {
        return code != null && code.Length == 3;
    }
}