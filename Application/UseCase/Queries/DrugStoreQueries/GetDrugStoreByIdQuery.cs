using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.DrugStoreQueries;

/// <summary>
/// Запрос для получения информации об аптеке по ее идентификатору
/// </summary>
/// <param name="Id">Уникальный идентификатор аптеки</param>
/// <returns>Объект <see cref="DrugStore"/> или null, если аптека не найдена</returns>
public record GetDrugStoreByIdQuery(Guid Id) : IRequest<DrugStore?>;