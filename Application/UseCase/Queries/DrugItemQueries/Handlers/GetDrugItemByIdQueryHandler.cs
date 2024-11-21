using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.DrugItemQueries.Handlers;

/// <summary>
/// Обработчик запроса для получения информации о лекарстве в аптеке по его идентификаторам.
/// </summary>
/// <param name="drugItemReadRepository">Репозиторий для чтения данных о лекарствах в аптеке.</param>
public class GetDrugItemByIdQueryHandler(IDrugItemReadRepository drugItemReadRepository):IRequestHandler<GetDrugItemByIdQuery, ICollection<DrugItem>>
{
    /// <summary>
    /// Обрабатывает запрос на получение лекарства в аптеке по идентификаторам.
    /// </summary>
    /// <param name="request">Запрос с идентификаторами лекарства.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns>Объект <see cref="DrugItem"/> или null, если лекарство не найдено.</returns>
    public async Task<ICollection<DrugItem>> Handle(GetDrugItemByIdQuery request, CancellationToken cancellationToken)
    {
        var response = await drugItemReadRepository.GetByDrugAndStoreAsync(request.Id, cancellationToken);
        return response;
    }
}