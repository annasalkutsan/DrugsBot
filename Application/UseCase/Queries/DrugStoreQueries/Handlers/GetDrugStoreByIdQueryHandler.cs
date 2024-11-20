using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.DrugStoreQueries.Handlers;

/// <summary>
/// Обработчик запроса для получения информации об аптеке по её идентификатору.
/// </summary>
/// <param name="drugStoreReadRepository">Репозиторий для чтения данных об аптеках.</param>
public class GetDrugStoreByIdQueryHandler(IDrugStoreReadRepository drugStoreReadRepository) : IRequestHandler<GetDrugStoreByIdQuery, DrugStore?>
{
    /// <summary>
    /// Обрабатывает запрос на получение аптеки по идентификатору.
    /// </summary>
    /// <param name="request">Запрос с идентификатором аптеки.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns>Объект <see cref="DrugStore"/> или null, если аптека не найдена.</returns>
    public async Task<DrugStore?> Handle(GetDrugStoreByIdQuery request, CancellationToken cancellationToken)
    {
        var response = await drugStoreReadRepository.GetByIdAsync(request.Id, cancellationToken);
        return response;
    }
}