using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.DrugItemQueries.Handlers;

/// <summary>
/// Обработчик запроса для получения данных о лекарствах в аптеке с применением OData параметров.
/// </summary>
public class GetDrugItemQueryableQueryHandler(IDrugItemReadRepository drugItemReadRepository)
    : IRequestHandler<GetDrugItemQueryableQuery, IQueryable<DrugItem>>
{
    /// <summary>
    /// Обрабатывает запрос для получения данных о лекарствах в аптеке с использованием OData.
    /// </summary>
    /// <param name="request">Запрос, содержащий параметры OData для фильтрации, сортировки и т.д.</param>
    /// <param name="cancellationToken">Токен отмены для асинхронной операции.</param>
    /// <returns>Коллекция элементов типа <see cref="DrugItem"/>, соответствующих параметрам OData.</returns>
    public async Task<IQueryable<DrugItem>> Handle(GetDrugItemQueryableQuery request, CancellationToken cancellationToken)
    {
        var response = await drugItemReadRepository.GetQueryableAsync(request.QueryOptions, cancellationToken);
        return response;
    }
}