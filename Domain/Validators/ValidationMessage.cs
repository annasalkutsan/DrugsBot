namespace Domain.Validators;

public class ValidationMessage
{
    public const string NotNull = "{PropertyName} не может быть NULL";
    public const string NotEmpty = "{PropertyName} не может быть пустым";
    public const string WrongLength = "{PropertyName} должен быть от {min} до {max}";
    public const string PositiveInteger = "{PropertyName} должен быть положительным числом.";
    public const string IsRight = "{PropertyName} не корректно";
    public const string InvalidCharacters = "{PropertyName} должно содержать только буквы и пробелы";
}