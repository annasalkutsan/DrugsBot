using Domain.Entities;
using FluentValidation;

namespace Domain.Validators;

public class DrugStoreValidator : AbstractValidator<DrugStore>
{
    public DrugStoreValidator()
    {
        RuleFor(ds => ds.DrugNetwork)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Length(2, 100).WithMessage(ValidationMessage.WrongLength);

        RuleFor(ds => ds.Number)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .GreaterThan(0).WithMessage(ValidationMessage.PositiveInteger);

        RuleFor(ds => ds.Address.City)
            .NotNull().WithMessage(x => ValidationMessage.NotNull)
            .NotEmpty().WithMessage(x => ValidationMessage.NotEmpty)
            .Matches(@"^[a-zA-Zа-яА-Я]+$").WithMessage(ValidationMessage.IsRight);

        RuleFor(ds => ds.Address.Street)
            .NotNull().WithMessage(x => ValidationMessage.NotEmpty)
            .NotEmpty().WithMessage(x => ValidationMessage.NotEmpty)
            .Matches(@"^[a-zA-Zа-яА-Я\s]+$").WithMessage(ValidationMessage.IsRight);

        RuleFor(ds => ds.Address.House)
            .NotNull().WithMessage(x => ValidationMessage.NotNull)
            .NotEmpty().WithMessage(x => ValidationMessage.NotEmpty)
            .Matches(@"^\d+[a-zA-Zа-яА-Я]*$").WithMessage(ValidationMessage.IsRight);

        RuleFor(ds => ds.PhoneNumber)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Matches(@"^\+?\d{9,15}$").WithMessage(ValidationMessage.IsRight);
    }
}