using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.FavoriteDrugCommands.Handlers;

/// <summary>
/// Обработчик команды для добавления нового избранного лекарства.
/// </summary>
/// <param name="favoriteDrugWriteRepository">Репозиторий для операций, изменяющих данные о избранных лекарствах.</param>
public class AddFavoriteDrugCommandHandler(IFavoriteDrugWriteRepository favoriteDrugWriteRepository):IRequestHandler<AddFavoriteDrugCommand, Unit>
{
    /// <summary>
    ///  Обрабатывает команду добавления нового избранного лекарства в базу данных.
    /// </summary>
    /// <param name="request">Запрос с объектом <see cref="FavoriteDrug"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(AddFavoriteDrugCommand request, CancellationToken cancellationToken)
    {
        await favoriteDrugWriteRepository.AddAsync(request.FavoriteDrug, cancellationToken);
        return Unit.Value;
    }
}