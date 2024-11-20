using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.OData.Query;

namespace Application.UseCase.Queries.DrugStoreQueries;

/// <summary>
/// Запрос для получения данных об аптеках с использованием OData.
/// </summary>
/// <param name="QueryOptions">OData параметры для фильтрации, сортировки и т.д.</param>
/// <returns>Коллекция элементов типа <see cref="DrugStore"/>, соответствующая запросу.</returns>
public record GetDrugStoreQueryableQuery(ODataQueryOptions<DrugStore> QueryOptions) : IRequest<IQueryable<DrugStore>>;