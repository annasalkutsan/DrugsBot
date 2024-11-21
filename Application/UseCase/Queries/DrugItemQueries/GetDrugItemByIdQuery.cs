using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.DrugItemQueries;

/// <summary>
/// Запрос для получения информации о лекарстве в аптеке по его идентификаторам
/// </summary>
/// <param name="Id">Идентификатор сущности <see cref="DrugItem"/></param>
public record GetDrugItemByIdQuery(Guid Id):IRequest<ICollection<DrugItem?>>;