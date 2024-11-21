using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.FavoriteDrugQueries.Handlers;


/// <summary>
/// Обработчик запроса для получения информации о лекарстве по его идентификатору.
/// </summary>
/// <param name="favoriteDrugReadRepository">Репозиторий для чтения данных о лекарствах.</param>
public class GetFavoriteDrugByIdQueryHandler(IFavoriteDrugReadRepository favoriteDrugReadRepository) : IRequestHandler<GetFavoriteDrugByIdQuery, FavoriteDrug?>
{
    /// <summary>
    /// Обрабатывает запрос на получение лекарства по идентификатору.
    /// </summary>
    /// <param name="request">Запрос с идентификатором лекарства.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns>Объект <see cref="Drug"/> или null, если лекарство не найдено.</returns>
    public async Task<FavoriteDrug?> Handle(GetFavoriteDrugByIdQuery request, CancellationToken cancellationToken)
    {
        var response = await favoriteDrugReadRepository.GetFavoriteDrugByIdAsync( request.ProfileId,
            request.DrugId, request.DrugStoreId, cancellationToken);
        return response;
    }
}