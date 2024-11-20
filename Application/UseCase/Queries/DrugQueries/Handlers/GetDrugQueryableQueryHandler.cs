using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.DrugQueries.Handlers;

/// <summary>
/// Обработчик запроса для получения данных о лекарствах с применением OData параметров.
/// </summary>
public class GetDrugQueryableQueryHandler(IDrugReadRepository drugReadRepository): IRequestHandler<GetDrugQueryableQuery, IQueryable<Drug>>
{
    /// <summary>
    /// Обрабатывает запрос для получения данных о лекарствах с использованием OData.
    /// </summary>
    /// <param name="request">Запрос, содержащий параметры OData для фильтрации, сортировки и т.д.</param>
    /// <param name="cancellationToken">Токен отмены для асинхронной операции.</param>
    /// <returns>Коллекция элементов типа <see cref="Drug"/>, соответствующих параметрам OData.</returns>
    public async Task<IQueryable<Drug>> Handle(GetDrugQueryableQuery request, CancellationToken cancellationToken)
    {
        var response = await drugReadRepository.GetQueryableAsync(request.QueryOptions, cancellationToken);
        return response;
    }
}
