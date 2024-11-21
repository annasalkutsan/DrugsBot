using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.ProfileCommands;

/// <summary>
/// Команда для добавления нового пользователя.
/// </summary>
/// <param name="Profile">Объект сущности <see cref="Profile"/>, который необходимо добавить.</param>
public record AddProfileCommand(Profile Profile) : IRequest<Unit>;