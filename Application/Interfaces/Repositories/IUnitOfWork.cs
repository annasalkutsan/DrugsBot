namespace Application.Interfaces.Repositories
{
    /// <summary>
    /// Интерфейс для управления транзакциями и изменениями в базе данных
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Сохраняет все изменения, выполненные в репозиториях
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>Количество сохраненных изменений в базе данных.</returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Начинает транзакцию
        /// </summary>
        Task BeginTransactionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Подтверждает транзакцию
        /// </summary>
        Task CommitTransactionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Откатывает транзакцию
        /// </summary>
        Task RollbackTransactionAsync(CancellationToken cancellationToken = default);
    }
}