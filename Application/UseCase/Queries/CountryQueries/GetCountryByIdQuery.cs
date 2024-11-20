using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.CountryQueries;

/// <summary>
/// Запрос для получения информации о стране по ее идентификатору
/// </summary>
/// <param name="Id">Уникальный идентификатор страны</param>
/// <returns>Объект <see cref="Country"/> или null, если страна не найдена</returns>
public record GetCountryByIdQuery(Guid Id) : IRequest<Country?>;