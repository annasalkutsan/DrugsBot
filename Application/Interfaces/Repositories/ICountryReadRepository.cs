using Domain.Entities;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Репозиторий для операций чтения сущности Country
/// </summary>
public interface ICountryReadRepository:IReadRepository<Country>
{
    
}