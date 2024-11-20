using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.DrugStoreCommands;

/// <summary>
/// Команда для обновления аптеки.
/// </summary>
/// <param name="DrugStore">Объект сущности <see cref="DrugStore"/>, который необходимо обновить.</param>
public record UpdateDrugStoreCommand(DrugStore DrugStore) : IRequest<Unit>;