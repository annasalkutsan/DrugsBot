using Application.Interfaces.Repositories;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Dal.Repositories.Read;

/// <summary>
/// Базовый репозиторий для операций чтения
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class BaseReadRepository<T> : IReadRepository<T> where T : class
{
    private readonly DbContext _dbContext;

    protected BaseReadRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Получение сущности по идентификатору
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _dbContext.Set<T>()
            .AsNoTracking()
            .FirstOrDefaultAsync(e => EF.Property<Guid>(e, "Id") == id, cancellationToken);
    }

    /// <summary>
    /// Получение запроса с помощью OData
    /// </summary>
    /// <param name="queryOptions"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task<IQueryable<T>> GetQueryableAsync(ODataQueryOptions<T> queryOptions,
        CancellationToken cancellationToken = default)
    {
        var query = _dbContext.Set<T>().AsNoTracking();
        var filteredQuery = queryOptions.ApplyTo(query, new ODataQuerySettings()) as IQueryable<T>;

        return Task.FromResult(filteredQuery!);
    }
}