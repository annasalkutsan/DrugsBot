using Domain.Entities;
using Domain.Events;
using FluentValidation;

namespace DomainTests;

public class DomainEventTests
{
    [Fact]
    public void UpdateCount_ShouldAddDomainEvent()
    {
        // Arrange
        var drugItem = new DrugItem(Guid.NewGuid(), Guid.NewGuid(), 100m, 10, null, null);
    
        // Act
        drugItem.UpdateCount(15);

        // Assert
        var events = drugItem.GetDomainEvents();
        Assert.Single(events);
        var @event = Assert.IsType<DrugItemUpdatedEvent>(events.First());
        Assert.Equal(10, @event.OldCount);
        Assert.Equal(15, @event.NewCount);
    }

    [Fact]
    public void UpdateCount_InvalidCount_ShouldThrowValidationException()
    {
        // Arrange
        var drugItem = new DrugItem(Guid.NewGuid(), Guid.NewGuid(), 100m, 10, null, null);
    
        // Act & Assert
        Assert.Throws<ValidationException>(() => drugItem.UpdateCount(-5));
    }

}