using Domain.Entities;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для операций, изменяющих данные сущности <see cref="FavoriteDrug"/>
/// </summary>
public interface IFavoriteDrugWriteRepository:IWriteRepository<FavoriteDrug>
{
    /// <summary>
    /// Метод для удаления сущности
    /// </summary>
    /// <param name="profileId"></param>
    /// <param name="drugId"></param>
    /// <param name="drugStoreId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DeleteFavoriteDrugByIdAsync (Guid profileId,
        Guid drugId, Guid? drugStoreId, CancellationToken cancellationToken = default);
}