using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.CountryCommands;

/// <summary>
/// Команда для удаления страны.
/// </summary>
/// <param name="Id">Идентификатор сущности <see cref="Country"/>, которую необходимо удалить</param>
public record DeleteCountryCommand(Guid Id):IRequest<Unit>;