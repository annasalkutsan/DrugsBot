using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.CountryQueries.Handlers;

/// <summary>
/// Обработчик запроса для получения данных о странах с применением OData параметров.
/// </summary>
public class GetCountryQueryableQueryHandler(ICountryReadRepository countryReadRepository): IRequestHandler<GetCountryQueryableQuery, IQueryable<Country>>
{
    /// <summary>
    /// Обрабатывает запрос для получения данных о странах с использованием OData.
    /// </summary>
    /// <param name="request">Запрос, содержащий параметры OData для фильтрации, сортировки и т.д.</param>
    /// <param name="cancellationToken">Токен отмены для асинхронной операции.</param>
    /// <returns>Коллекция элементов типа <see cref="Country"/>, соответствующих параметрам OData.</returns>
    public async Task<IQueryable<Country>> Handle(GetCountryQueryableQuery request, CancellationToken cancellationToken)
    {
        var response = await countryReadRepository.GetQueryableAsync(request.QueryOptions, cancellationToken);
        return response;
    }
}
