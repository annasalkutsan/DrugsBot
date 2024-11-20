using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.DrugItemQueries.Handlers;

public class GetDrugItemByDrugAndStoreQueryHandler(IDrugItemReadRepository drugItemReadRepository):IRequestHandler<GetDrugItemByDrugAndStoreQuery, ICollection<DrugItem>>
{
    public async Task<ICollection<DrugItem>> Handle(GetDrugItemByDrugAndStoreQuery request, CancellationToken cancellationToken)
    {
        var response = await drugItemReadRepository.GetByDrugAndStoreAsync(request.DrugId, request.DrugStoreId, cancellationToken);
        return response;
    }
}