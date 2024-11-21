using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.ProfileCommands.Handlers;

/// <summary>
/// Обработчик команды для обновления пользователя.
/// </summary>
/// <param name="profileWriteRepository">Репозиторий для операций, изменяющих данные о пользователях.</param>
public class UpdateProfileCommandHandler(IProfileWriteRepository profileWriteRepository):IRequestHandler<UpdateProfileCommand, Unit>
{
    /// <summary>
    /// Обрабатывает команду обновления пользователя в базе данных.
    /// </summary>
    /// <param name="request">Запрос с объектом <see cref="Profile"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(UpdateProfileCommand request, CancellationToken cancellationToken)
    {
        await profileWriteRepository.UpdateAsync(request.Profile, cancellationToken);
        return Unit.Value;
    }
}