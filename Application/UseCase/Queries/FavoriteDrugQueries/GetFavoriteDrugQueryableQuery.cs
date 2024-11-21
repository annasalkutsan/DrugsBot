using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.OData.Query;

namespace Application.UseCase.Queries.FavoriteDrugQueries;

/// <summary>
/// Запрос для получения данных о избранных лекарствах с использованием OData.
/// </summary>
/// <param name="QueryOptions">OData параметры для фильтрации, сортировки и т.д.</param>
/// <returns>Коллекция элементов типа <see cref="FavoriteDrug"/>, соответствующая запросу.</returns>
public record GetFavoriteDrugQueryableQuery(ODataQueryOptions<FavoriteDrug> QueryOptions) : IRequest<IQueryable<FavoriteDrug>>;