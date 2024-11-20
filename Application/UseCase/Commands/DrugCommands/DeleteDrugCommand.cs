using MediatR;

namespace Application.UseCase.Commands.DrugCommands;

/// <summary>
/// Команда для удаления лекарства.
/// </summary>
/// <param name="Id">Идентификатор сущности <see cref="Drug"/>, которую необходимо удалить</param>
public record DeleteDrugCommand(Guid Id):IRequest<Unit>;