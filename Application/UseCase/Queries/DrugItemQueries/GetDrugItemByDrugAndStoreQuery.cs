using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.DrugItemQueries;

public record GetDrugItemByDrugAndStoreQuery(Guid DrugStoreId, Guid DrugId):IRequest<ICollection<DrugItem>>;