using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.ProfileCommands;

/// <summary>
/// Команда для обновления пользователя.
/// </summary>
/// <param name="Profile">Объект сущности <see cref="Profile"/>, который необходимо обновить.</param>
public record UpdateProfileCommand(Profile Profile) : IRequest<Unit>;