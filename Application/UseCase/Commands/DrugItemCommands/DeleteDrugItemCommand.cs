using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.DrugItemCommands;

/// <summary>
/// Команда для удаления лекарства в аптеке.
/// </summary>
/// <param name="Id">Идентификатор сущности, для <see cref="DrugItem"/>, которую необходимо удалить</param>
public record DeleteDrugItemCommand(Guid Id):IRequest<Unit>;