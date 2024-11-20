using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.OData.Query;

namespace Application.UseCase.Queries.CountryQueries;

/// <summary>
/// Запрос для получения данных о станах с использованием OData.
/// </summary>
/// <param name="QueryOptions">OData параметры для фильтрации, сортировки и т.д.</param>
/// <returns>Коллекция элементов типа <see cref="Country"/>, соответствующая запросу.</returns>
public record GetCountryQueryableQuery(ODataQueryOptions<Country> QueryOptions) : IRequest<IQueryable<Country>>;