using Domain.Entities;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для операций, изменяющих данные сущности Drug
/// </summary>
public interface IDrugWriteRepository:IWriteRepository<Drug>
{
    
}