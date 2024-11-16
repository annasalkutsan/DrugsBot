using Domain.Interfaces;

namespace Domain.Events;

/// <summary>
/// Доменное событие обновления единицы лекарства.
/// </summary>
public sealed class DrugItemUpdatedEvent : IDomainEvent
{
    public Guid DrugItemId { get; }
    public double OldCount { get; }
    public double NewCount { get; }

    public DrugItemUpdatedEvent(Guid drugItemId, double oldCount, double newCount)
    {
        DrugItemId = drugItemId;
        OldCount = oldCount;
        NewCount = newCount;
    }
}