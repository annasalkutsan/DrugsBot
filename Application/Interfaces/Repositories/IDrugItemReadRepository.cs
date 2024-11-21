using Domain.Entities;
using Microsoft.AspNetCore.OData.Query;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для операций чтения сущности <see cref="DrugItem"/>
/// </summary>
public interface IDrugItemReadRepository:IReadRepository<DrugItem>
{
    /// <summary>
    /// Получение сущности по идентификаторам
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Список препаратов в аптеке</returns>
    Task<ICollection<DrugItem>> GetByDrugAndStoreAsync(Guid id, CancellationToken cancellationToken = default);
        
    /// <summary>
    /// Получение запроса с помощью OData
    /// </summary>
    /// <param name="queryOptions">Параметры запроса OData</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Запрос для коллекции препаратов</returns>
    Task<IQueryable<DrugItem>> GetQueryableAsync(ODataQueryOptions<DrugItem> queryOptions, CancellationToken cancellationToken = default);
}