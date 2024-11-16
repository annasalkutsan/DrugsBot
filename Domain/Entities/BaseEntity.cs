using Domain.Interfaces;
using FluentValidation;

namespace Domain.Entities;
/// <summary>
/// Базовый класс для сущностей
/// </summary>
public abstract class BaseEntity<T> where T : BaseEntity<T>
{
    private readonly List<IDomainEvent> _domainEvents = [];
    protected BaseEntity()
    {
        Id = Guid.NewGuid();
    }
    
    /// <summary>
    /// Идентификатор сущности
    /// </summary>
    public Guid Id { get; protected set; }

    /// <summary>
    /// Дата создания сущности
    /// </summary>
    public DateTime CreationDate { get; set; }

    /// <summary>
    /// Сравнение сущностей по Id
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (obj is not BaseEntity<T>  entity)
        {
            return false;
        }

        if (ReferenceEquals(this, entity)) return true;

        return Id == entity.Id;
    }

    /// <summary>
    /// Получение хешкода сущности из Id
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
    
    /// <summary>
    /// Переопределение оператора равенства
    /// </summary>
    public static bool operator ==(BaseEntity<T>? left, BaseEntity<T>? right)
    {
        // Проверка на null
        if (left is null && right is null) return true;
        if (left is null || right is null) return false;

        return left.Equals(right);
    }

    /// <summary>
    /// Переопределение оператора неравенства
    /// </summary>
    public static bool operator !=(BaseEntity<T>? left, BaseEntity<T>? right)
    {
        return !(left == right); 
    }
    
    /// <summary>
    /// Выполняет валидацию сущности с использованием указанного валидатора.
    /// </summary>
    /// <param name="validator">Валидатор FluentValidator.</param>
    protected void ValidateEntity(AbstractValidator<T> validator)
    {
        var validationResult = validator.Validate((T)this);
        if (validationResult.IsValid)
        {
            return;
        }

        var errorMessages = string.Join("; ", validationResult.Errors.Select(e => e.ErrorMessage));
        throw new ValidationException(errorMessages);
    }
    
    /// <summary>
    /// Получить доменные события.
    /// </summary>
    /// <returns>Список доменных событий</returns>
    public IReadOnlyList<IDomainEvent> GetDomainEvents()
    {
        return _domainEvents.AsReadOnly();
    }

    /// <summary>
    /// Очистить доменные события.
    /// </summary>
    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    /// <summary>
    /// Добавить доменное событие.
    /// </summary>
    /// <param name="domainEvent">Доменное событие.</param>
    protected void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

}