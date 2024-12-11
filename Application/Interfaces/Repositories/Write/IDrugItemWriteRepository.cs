using Domain.Entities;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для операций, изменяющих данные сущности <see cref="DrugItem"/>
/// </summary>
public interface IDrugItemWriteRepository:IWriteRepository<DrugItem>
{
    
}