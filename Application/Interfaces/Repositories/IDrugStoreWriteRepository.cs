using Domain.Entities;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для операций, изменяющих данные сущности DrugStore
/// </summary>
public interface IDrugStoreWriteRepository: IWriteRepository<DrugStore>
{
    
}