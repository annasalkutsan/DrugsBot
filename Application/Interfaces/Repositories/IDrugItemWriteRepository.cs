using Domain.Entities;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для операций, изменяющих данные сущности <see cref="DrugItem"/>
/// </summary>
public interface IDrugItemWriteRepository:IWriteRepository<DrugItem>
{
    /// <summary>
    /// Метод для удаления сущности
    /// </summary>
    /// <param name="drugId"></param>
    /// <param name="drugStoreId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DeleteByDrugAndStoreAsync (Guid drugStoreId, Guid drugId, CancellationToken cancellationToken = default);
}