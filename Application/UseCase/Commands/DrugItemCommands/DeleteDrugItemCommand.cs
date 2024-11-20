using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.DrugItemCommands;

/// <summary>
/// Команда для удаления лекарства в аптеке.
/// </summary>
/// <param name="DrugId">Первый идентификатор сущности, для <see cref="Drug"/>, которую необходимо удалить</param>
/// <param name="DrugStoreId">Второй идентификатор сущности, для <see cref="DrugStore"/>, которую необходимо удалить</param>
public record DeleteDrugItemCommand(Guid DrugId, Guid DrugStoreId):IRequest<Unit>;