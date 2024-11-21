using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.FavoriteDrugCommands.Handlers;

/// <summary>
/// Обработчик команды для удаления избранного лекарства.
/// </summary>
/// <param name="favoriteDrugWriteRepository">Репозиторий для операций, изменяющих данные о избранных лекарствах.</param>
public class DeleteFavoriteDrugCommandHandler(IFavoriteDrugWriteRepository favoriteDrugWriteRepository):IRequestHandler<DeleteFavoriteDrugCommand, Unit>
{
    /// <summary>
    ///  Обрабатывает команду удаления избранного лекарства из базы данных.
    /// </summary>
    /// <param name="request"> Запрос с идентификаторами сущности <see cref="FavoriteDrug"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(DeleteFavoriteDrugCommand request, CancellationToken cancellationToken)
    {
        await favoriteDrugWriteRepository.DeleteFavoriteDrugByIdAsync(request.ProfileId, request.DrugId, request.DrugStoreId, cancellationToken);
        return Unit.Value;
    }
}