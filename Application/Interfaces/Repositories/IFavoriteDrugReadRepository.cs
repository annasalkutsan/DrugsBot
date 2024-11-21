using Domain.Entities;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для операций чтения сущности <see cref="FavoriteDrug"/>
/// </summary>
public interface IFavoriteDrugReadRepository:IReadRepository<FavoriteDrug>
{
    /// <summary>
    /// Получение сущности по идентификаторам
    /// </summary>
    /// <param name="profileId"></param>
    /// <param name="drugId"></param>
    /// <param name="drugStoreId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>Лекарство <see cref="FavoriteDrug"/> или null</returns>
    Task<FavoriteDrug?> GetFavoriteDrugByIdAsync(Guid profileId,
        Guid drugId, Guid? drugStoreId, CancellationToken cancellationToken = default);
}