using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.OData.Query;

namespace Application.UseCase.Queries.DrugQueries;

/// <summary>
/// Запрос для получения данных о лекарствах с использованием OData.
/// </summary>
/// <param name="QueryOptions">OData параметры для фильтрации, сортировки и т.д.</param>
/// <returns>Коллекция элементов типа <see cref="Drug"/>, соответствующая запросу.</returns>
public record GetDrugQueryableQuery(ODataQueryOptions<Drug> QueryOptions) : IRequest<IQueryable<Drug>>;