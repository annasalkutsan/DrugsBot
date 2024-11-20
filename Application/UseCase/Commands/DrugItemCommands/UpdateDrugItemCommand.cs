using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.DrugItemCommands;

/// <summary>
/// Команда для обновления лекарства в аптеке.
/// </summary>
/// <param name="DrugItem">Объект сущности <see cref="DrugItem"/>, который необходимо обновить.</param>
public record UpdateDrugItemCommand(DrugItem DrugItem) : IRequest<Unit>;