using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.ProfileQueries.Handlers;

/// <summary>
/// Обработчик запроса для получения данных о пользователях с применением OData параметров.
/// </summary>
public class GetProfileQueryableQueryHandler(IProfileReadRepository profileReadRepository): IRequestHandler<GetProfileQueryableQuery, IQueryable<Profile>>
{
    /// <summary>
    /// Обрабатывает запрос для получения данных о пользователях с использованием OData.
    /// </summary>
    /// <param name="request">Запрос, содержащий параметры OData для фильтрации, сортировки и т.д.</param>
    /// <param name="cancellationToken">Токен отмены для асинхронной операции.</param>
    /// <returns>Коллекция элементов типа <see cref="Profile"/>, соответствующих параметрам OData.</returns>
    public async Task<IQueryable<Profile>> Handle(GetProfileQueryableQuery request, CancellationToken cancellationToken)
    {
        var response = await profileReadRepository.GetQueryableAsync(request.QueryOptions, cancellationToken);
        return response;
    }
}