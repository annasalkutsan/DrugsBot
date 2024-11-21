using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.FavoriteDrugQueries;

/// <summary>
/// Запрос для получения информации о лекарстве по его идентификатору
/// </summary>
/// <param name="ProfileId">Уникальный идентификатор пользователя</param>
/// <param name="DrugId">Уникальный идентификатор лекарства</param>
/// <param name="DrugStoreId">Уникальный идентификатор аптеки</param>
/// <returns>Объект <see cref="FavoriteDrug"/> или null, если лекарство не найдено</returns>
public record GetFavoriteDrugByIdQuery(Guid ProfileId,
    Guid DrugId, Guid? DrugStoreId) : IRequest<FavoriteDrug?>;