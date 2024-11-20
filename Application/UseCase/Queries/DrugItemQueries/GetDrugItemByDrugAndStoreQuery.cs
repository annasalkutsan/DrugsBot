using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.DrugItemQueries;

/// <summary>
/// Запрос для получения информации о лекарстве в аптеке по его идентификаторам
/// </summary>
/// <param name="DrugStoreId">Первый идентификатор сущности <see cref="DrugItem"/></param>
/// <param name="DrugId">Второй идентификатор сущности <see cref="DrugItem"/></param>
public record GetDrugItemByDrugAndStoreQuery(Guid DrugStoreId, Guid DrugId):IRequest<ICollection<DrugItem?>>;