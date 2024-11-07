using Domain.Entities;
using FluentValidation;

namespace Domain.Validators;

public class DrugStoreValidator : AbstractValidator<DrugStore>
{
    // Статическая коллекция для хранения уникальных номеров аптек
    private static readonly HashSet<int> ExistingNumbers = new HashSet<int>();
    
    // Набор поддерживаемых ISO-кодов стран
    private static readonly HashSet<string> ValidIsoCodes = new HashSet<string>
    {
        "US", "RU", "DE", "FR", "GB" // Пример поддерживаемых ISO-кодов
    };
    
    public DrugStoreValidator()
    {
        // DrugNetwork validation
        RuleFor(ds => ds.DrugNetwork)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Length(2, 100).WithMessage(ValidationMessage.WrongLength);

        // Number validation (note: unique validation typically happens in service layer)
        RuleFor(ds => ds.Number)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .GreaterThan(0).WithMessage(ValidationMessage.PositiveInteger)
            .Must(BeUniqueNumber).WithMessage("Номер аптеки должен быть уникальным в пределах сети.");

        // Address.City validation
        RuleFor(ds => ds.Address.City)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Length(2, 50).WithMessage(ValidationMessage.WrongLength)
            .Matches(@"^[a-zA-Zа-яА-Я]+$").WithMessage("Поле 'Город' должно содержать только буквы");

        // Address.Street validation
        RuleFor(ds => ds.Address.Street)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Length(3, 100).WithMessage(ValidationMessage.WrongLength)
            .Matches(@"^[a-zA-Zа-яА-Я\s]+$").WithMessage("Поле 'Улица' должно содержать только буквы и пробелы");

        // Address.House validation
        RuleFor(ds => ds.Address.House)
            .NotNull().WithMessage(x => ValidationMessage.NotNull)
            .NotEmpty().WithMessage(x => ValidationMessage.NotEmpty)
            .Matches(@"^\d+[a-zA-Zа-яА-Я]*$").WithMessage(ValidationMessage.IsRight);
        
        // Address.PostalCode validation
        RuleFor(ds => ds.Address.PostalCode)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Matches(@"^\d{5,6}$").WithMessage("Поле 'Почтовый код' должно быть числовым и содержать 5-6 цифр");

        // Address.Country validation (ISO country code, 2 uppercase letters)
        RuleFor(ds => ds.Address.Country)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Must(countryCode => IsValidIsoCode(countryCode))
            .WithMessage("Поле 'Страна' должно быть действительным ISO-кодом страны");

        // PhoneNumber validation (assuming this field is required)
        RuleFor(ds => ds.PhoneNumber)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Matches(@"^\+?\d{9,15}$").WithMessage("Поле 'Телефон' должно содержать от 9 до 15 цифр, включая код страны");
    }
    private bool IsValidIsoCode(string countryIsoCode)
    {
        return ValidIsoCodes.Contains(countryIsoCode.ToUpper());
    }
    
    private bool BeUniqueNumber(int number)
    {
        if (ExistingNumbers.Contains(number))
        {
            return false; 
        }
        else
        {
            ExistingNumbers.Add(number); 
            return true; 
        }
    }
}