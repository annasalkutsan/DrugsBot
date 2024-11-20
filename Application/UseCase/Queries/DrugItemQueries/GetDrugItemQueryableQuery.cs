using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.OData.Query;

namespace Application.UseCase.Queries.DrugItemQueries;

public record GetDrugItemQueryableQuery(ODataQueryOptions<DrugItem> QueryOptions): IRequest<IQueryable<DrugItem>>;
