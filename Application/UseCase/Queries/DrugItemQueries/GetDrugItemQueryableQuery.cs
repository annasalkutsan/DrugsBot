using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.OData.Query;

namespace Application.UseCase.Queries.DrugItemQueries;

/// <summary>
/// Запрос для получения данных о лекарствах в аптеке с использованием OData.
/// </summary>
/// <param name="QueryOptions">OData параметры для фильтрации, сортировки и т.д.</param>
/// <returns>Коллекция элементов типа <see cref="DrugItem"/>, соответствующая запросу.</returns>
public record GetDrugItemQueryableQuery(ODataQueryOptions<DrugItem> QueryOptions): IRequest<IQueryable<DrugItem?>>;
