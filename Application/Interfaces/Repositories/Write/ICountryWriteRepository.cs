using Domain.Entities;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для операций, изменяющих данные сущности Country
/// </summary>
public interface ICountryWriteRepository:IWriteRepository<Country>
{
    
}