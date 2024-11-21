using MediatR;

namespace Application.UseCase.Commands.ProfileCommands;

/// <summary>
/// Команда для удаления пользователя.
/// </summary>
/// <param name="Id">Идентификатор сущности <see cref="Profil"/>, которую необходимо удалить</param>
public record DeleteProfileCommand(Guid Id):IRequest<Unit>;