using Microsoft.AspNetCore.OData.Query;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для операций чтения
/// </summary>
public interface IReadRepository<T> where T : class
{
    /// <summary>
    /// Получение сущности по идентификатору
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task<T> GetByIdAsync (Guid id, CancellationToken cancellationToken = default);
    
    //ToDo почитать про OData чтобы переложить фильтр на фронт (через endpoint)
    
    /// <summary>
    /// Получение запроса с помощью OData
    /// </summary>
    /// <param name="queryOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IQueryable<T>> GetQueryableAsync(ODataQueryOptions<T> queryOptions, CancellationToken cancellationToken= default);
}