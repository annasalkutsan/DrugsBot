using Domain.Events;
using Domain.Validators;
using FluentValidation.Results;

namespace Domain.Entities;

/// <summary>
/// Лекарственный препарат в определенной аптеке
/// </summary>
public class DrugItem : BaseEntity<DrugItem>
{
    public DrugItem(){}
    public DrugItem(Guid drugId, Guid drugStoreId, decimal cost, int count, Drug drug, DrugStore drugStore)
    {
        DrugId = drugId;
        DrugStoreId = drugStoreId;
        Cost = cost;
        Count = count;
        Drug = drug;
        DrugStore = drugStore;

        ValidateEntity(new DrugItemValidator());
    }
    
    /// <summary>
    /// Идентификатор лекарственного препарата
    /// </summary>
    public Guid DrugId { get; private set; }

    /// <summary>
    /// Препарат
    /// </summary>
    public Drug Drug { get; private set; }

    /// <summary>
    /// Идентификатор аптеки
    /// </summary>
    public Guid DrugStoreId { get; private set; }

    /// <summary>
    /// Аптека
    /// </summary>
    public DrugStore DrugStore { get; private set; }

    /// <summary>
    /// Цена
    /// </summary>
    public decimal Cost { get; private set; }

    /// <summary>
    /// Количество
    /// </summary>
    public double Count { get; private set; }
    
    /// <summary>
    /// Обновить количество препарата на складе.
    /// </summary>
    /// <param name="count"></param>
    public void UpdateCount(double count)
    {
        var oldCount = Count; // Сохраняем текущее значение
        Count = count;

        // Валидация
        ValidateEntity(new DrugItemValidator());

        // Генерируем событие
        AddDomainEvent(new DrugItemUpdatedEvent(Id, oldCount, count));
    }
}