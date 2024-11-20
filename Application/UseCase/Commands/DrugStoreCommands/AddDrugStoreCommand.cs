using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.DrugStoreCommands;

/// <summary>
/// Команда для добавления новой аптеки.
/// </summary>
/// <param name="DrugStore">Объект сущности <see cref="DrugStore"/>, который необходимо добавить.</param>
public record AddDrugStoreCommand(DrugStore DrugStore) : IRequest<Unit>;