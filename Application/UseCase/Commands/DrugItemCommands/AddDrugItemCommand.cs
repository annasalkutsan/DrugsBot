using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.DrugItemCommands;

/// <summary>
/// Команда для добавления нового лекарства в аптеке.
/// </summary>
/// <param name="DrugItem">Объект сущности <see cref="DrugItem"/>, который необходимо добавить.</param>
public record AddDrugItemCommand(DrugItem DrugItem) : IRequest<Unit>;