using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.DrugStoreCommands;

/// <summary>
/// Команда для удаления аптеки.
/// </summary>
/// <param name="Id">Идентификатор сущности <see cref="DrugStore"/>, которую необходимо удалить</param>
public record DeleteDrugStoreCommand(Guid Id):IRequest<Unit>;