using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.DrugStoreQueries.Handlers;

/// <summary>
/// Обработчик запроса для получения данных об аптеках с применением OData параметров.
/// </summary>
public class GetDrugStoreQueryableQueryHandler(IDrugStoreReadRepository drugStoreReadRepository): IRequestHandler<GetDrugStoreQueryableQuery, IQueryable<DrugStore>>
{
    /// <summary>
    /// Обрабатывает запрос для получения данных об аптеках с использованием OData.
    /// </summary>
    /// <param name="request">Запрос, содержащий параметры OData для фильтрации, сортировки и т.д.</param>
    /// <param name="cancellationToken">Токен отмены для асинхронной операции.</param>
    /// <returns>Коллекция элементов типа <see cref="DrugStore"/>, соответствующих параметрам OData.</returns>
    public async Task<IQueryable<DrugStore>> Handle(GetDrugStoreQueryableQuery request, CancellationToken cancellationToken)
    {
        var response = await drugStoreReadRepository.GetQueryableAsync(request.QueryOptions, cancellationToken);
        return response;
    }
}
