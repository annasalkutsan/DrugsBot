using Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Dal.Repositories.Write;

/// <summary>
/// Базовый репозиторий для операций, изменяющих данные
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class BaseWriteRepository<T>:IWriteRepository<T> where T : class
{
    private readonly DbContext _dbContext;
    private readonly IUnitOfWork _unitOfWork;

    protected BaseWriteRepository(DbContext dbContext, IUnitOfWork unitOfWork)
    {
        _dbContext = dbContext;
        _unitOfWork = unitOfWork;
    }

    /// <summary>
    /// Метод для добавления сущности
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="cancellationToken"></param>
    public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
    {
       await _dbContext.Set<T>().AddAsync(entity, cancellationToken);
    }

    /// <summary>
    /// Метод для обновления сущности
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
    {
        _dbContext.Set<T>().Attach(entity);
        _dbContext.Entry(entity).State = EntityState.Modified;

        return Task.CompletedTask;
    }

    /// <summary>
    /// Метод для удаления сущности
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <exception cref="KeyNotFoundException"></exception>
    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var entity = await _dbContext.Set<T>().FindAsync(new object[] { id }, cancellationToken);

        if (entity == null)
        {
            throw new KeyNotFoundException($"Сущность типа {typeof(T).Name} с ключом ID {id} не найдена");
        }

        _dbContext.Set<T>().Remove(entity);
    }
    
    /// <summary>
    /// Метод для сохранения изменений использующий UnitOfWork
    /// </summary>
    /// <param name="cancellationToken"></param>
    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}