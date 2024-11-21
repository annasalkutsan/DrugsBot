using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.ProfileCommands.Handlers;

/// <summary>
/// Обработчик команды для удаления пользователя.
/// </summary>
/// <param name="profileWriteRepository">Репозиторий для операций, изменяющих данные о пользователях.</param>
public class DeleteProfileCommandHandler(IProfileWriteRepository profileWriteRepository):IRequestHandler<DeleteProfileCommand, Unit>
{
    /// <summary>
    ///  Обрабатывает команду удаления пользователя из базы данных.
    /// </summary>
    /// <param name="request"> Запрос с идентификатор сущности <see cref="Profile"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(DeleteProfileCommand request, CancellationToken cancellationToken)
    {
        await profileWriteRepository.DeleteAsync(request.Id, cancellationToken);
        return Unit.Value;
    }
}