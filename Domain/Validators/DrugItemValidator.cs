using Domain.Entities;
using FluentValidation;

namespace Domain.Validators;

public class DrugItemValidator : AbstractValidator<DrugItem>
{
    public DrugItemValidator()
    {
        RuleFor(di => di.Cost)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .GreaterThan(0).WithMessage(ValidationMessage.PositiveInteger);

        RuleFor(di => di.Count)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .GreaterThan(0).WithMessage(ValidationMessage.PositiveInteger);

        RuleFor(di => di.DrugId)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty);

        RuleFor(di => di.DrugStoreId)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty);
    }
}