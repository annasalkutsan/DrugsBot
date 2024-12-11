using Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Dal;

/// <summary>
/// Реализует паттерн Unit of Work для управления транзакциями и изменениями в базе данных
/// </summary>
public class UnitOfWork : IUnitOfWork
{
    private readonly DbContext _dbContext;
    private bool _disposed = false;
    private bool _transactionStarted = false;

    public UnitOfWork(DbContext dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext), "DbContext не может быть null");
    }

    /// <summary>
    /// Начинает транзакцию
    /// </summary>
    public async Task BeginTransactionAsync(CancellationToken cancellationToken = default)
    {
        if (!_transactionStarted)
        {
            await _dbContext.Database.BeginTransactionAsync(cancellationToken);
            _transactionStarted = true;
        }
    }

    /// <summary>
    /// Подтверждает транзакцию
    /// </summary>
    public async Task CommitTransactionAsync(CancellationToken cancellationToken = default)
    {
        if (_transactionStarted)
        {
            await _dbContext.Database.CommitTransactionAsync(cancellationToken);
            _transactionStarted = false;
        }
    }

    /// <summary>
    /// Откатывает транзакцию
    /// </summary>
    public async Task RollbackTransactionAsync(CancellationToken cancellationToken = default)
    {
        if (_transactionStarted)
        {
            await _dbContext.Database.RollbackTransactionAsync(cancellationToken);
            _transactionStarted = false;
        }
    }

    /// <summary>
    /// Сохраняет все изменения, выполненные в репозиториях
    /// </summary>
    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            _dbContext.Dispose();
            _disposed = true;
        }
    }
}