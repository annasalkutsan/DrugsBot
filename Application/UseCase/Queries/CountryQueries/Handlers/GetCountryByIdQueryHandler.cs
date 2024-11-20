using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.CountryQueries.Handlers;

/// <summary>
/// Обработчик запроса для получения информации о стране по её идентификатору.
/// </summary>
/// <param name="countryReadRepository">Репозиторий для чтения данных о странах.</param>
public class GetCountryByIdQueryHandler(ICountryReadRepository countryReadRepository)
    : IRequestHandler<GetCountryByIdQuery, Country?>
{

    /// <summary>
    /// Обрабатывает запрос на получение страны по идентификатору.
    /// </summary>
    /// <param name="request">Запрос с идентификатором страны.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns>Объект <see cref="Country"/> или null, если страна не найдена.</returns>
    public async Task<Country?> Handle(GetCountryByIdQuery request, CancellationToken cancellationToken)
    {
        var response = await countryReadRepository.GetByIdAsync(request.Id, cancellationToken);
        return response;
    }
}