using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.FavoriteDrugQueries.Handlers;

/// <summary>
/// Обработчик запроса для получения данных о избранных лекарствах с применением OData параметров.
/// </summary>
public class GetFavoriteDrugQueryableQueryHandler(IFavoriteDrugReadRepository favoriteDrugReadRepository): IRequestHandler<GetFavoriteDrugQueryableQuery, IQueryable<FavoriteDrug>>
{
    /// <summary>
    /// Обрабатывает запрос для получения данных о избранных лекарствах с использованием OData.
    /// </summary>
    /// <param name="request">Запрос, содержащий параметры OData для фильтрации, сортировки и т.д.</param>
    /// <param name="cancellationToken">Токен отмены для асинхронной операции.</param>
    /// <returns>Коллекция элементов типа <see cref="FavoriteDrug"/>, соответствующих параметрам OData.</returns>
    public async Task<IQueryable<FavoriteDrug>> Handle(GetFavoriteDrugQueryableQuery request, CancellationToken cancellationToken)
    {
        var response = await favoriteDrugReadRepository.GetQueryableAsync(request.QueryOptions, cancellationToken);
        return response;
    }
}