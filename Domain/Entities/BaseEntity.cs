namespace Domain.Entities;
/// <summary>
/// Базовый класс для сущностей
/// </summary>
public abstract class BaseEntity
{
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
        if (obj is not BaseEntity entity)
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
    public static bool operator ==(BaseEntity? left, BaseEntity? right)
    {
        // Проверка на null
        if (left is null && right is null) return true;
        if (left is null || right is null) return false;

        return left.Equals(right);
    }

    /// <summary>
    /// Переопределение оператора неравенства
    /// </summary>
    public static bool operator !=(BaseEntity? left, BaseEntity? right)
    {
        return !(left == right); 
    }
}