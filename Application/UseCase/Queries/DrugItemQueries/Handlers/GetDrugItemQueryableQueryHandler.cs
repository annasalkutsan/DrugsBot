using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.DrugItemQueries.Handlers;

public class GetDrugItemQueryableQueryHandler(IDrugItemReadRepository drugItemReadRepository):IRequestHandler<GetDrugItemQueryableQuery, IQueryable<DrugItem>>
{
    public async Task<IQueryable<DrugItem>> Handle(GetDrugItemQueryableQuery request, CancellationToken cancellationToken)
    {
        var response = await drugItemReadRepository.GetQueryableAsync(request.QueryOptions, cancellationToken);
        return response;
    }
}