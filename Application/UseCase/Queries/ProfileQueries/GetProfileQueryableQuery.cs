using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.OData.Query;

namespace Application.UseCase.Queries.ProfileQueries;

/// <summary>
/// Запрос для получения данных о пользователях с использованием OData.
/// </summary>
/// <param name="QueryOptions">OData параметры для фильтрации, сортировки и т.д.</param>
/// <returns>Коллекция элементов типа <see cref="Profile"/>, соответствующая запросу.</returns>
public record GetProfileQueryableQuery(ODataQueryOptions<Profile> QueryOptions) : IRequest<IQueryable<Profile>>;