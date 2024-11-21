using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.ProfileQueries.Handlers;

/// <summary>
/// Обработчик запроса для получения информации о пользователе по его идентификатору.
/// </summary>
/// <param name="profileReadRepository">Репозиторий для чтения данных о пользователях.</param>
public class GetProfileByIdQueryHandler(IProfileReadRepository profileReadRepository) : IRequestHandler<GetProfileByIdQuery, Profile?>
{
    /// <summary>
    /// Обрабатывает запрос на получение пользователя по идентификатору.
    /// </summary>
    /// <param name="request">Запрос с идентификатором пользователя.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns>Объект <see cref="Profile"/> или null, если пользователь не найден.</returns>
    public async Task<Profile?> Handle(GetProfileByIdQuery request, CancellationToken cancellationToken)
    {
        var response = await profileReadRepository.GetByIdAsync(request.Id, cancellationToken);
        return response;
    }
}