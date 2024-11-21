using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.ProfileCommands.Handlers;

/// <summary>
/// Обработчик команды для добавления нового пользователя.
/// </summary>
/// <param name="profileWriteRepository">Репозиторий для операций, изменяющих данные о пользователях.</param>
public class AddProfileCommandHandler(IProfileWriteRepository profileWriteRepository):IRequestHandler<AddProfileCommand, Unit>
{
    /// <summary>
    ///  Обрабатывает команду добавления нового пользователя в базу данных.
    /// </summary>
    /// <param name="request">Запрос с объектом <see cref="Profile"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(AddProfileCommand request, CancellationToken cancellationToken)
    {
        await profileWriteRepository.AddAsync(request.Profile, cancellationToken);
        return Unit.Value;
    }
}
