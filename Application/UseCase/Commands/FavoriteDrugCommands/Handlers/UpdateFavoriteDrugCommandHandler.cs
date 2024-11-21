using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.FavoriteDrugCommands.Handlers;

/// <summary>
/// Обработчик команды для обновления избранного лекарства.
/// </summary>
/// <param name="favoriteDrugWriteRepository">Репозиторий для операций, изменяющих данные о избранных лекарствах.</param>
public class UpdateFavoriteDrugCommandHandler(IFavoriteDrugWriteRepository favoriteDrugWriteRepository):IRequestHandler<UpdateFavoriteDrugCommand, Unit>
{
    /// <summary>
    ///  Обрабатывает команду обновления избранного лекарства в базе данных.
    /// </summary>
    /// <param name="request">Запрос с объектом <see cref="FavoriteDrug"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(UpdateFavoriteDrugCommand request, CancellationToken cancellationToken)
    {
        await favoriteDrugWriteRepository.UpdateAsync(request.FavoriteDrug, cancellationToken);
        return Unit.Value;
    }
}