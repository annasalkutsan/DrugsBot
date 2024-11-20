using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.DrugStoreCommands.Handlers;

/// <summary>
/// Обработчик команды для обновления аптеки.
/// </summary>
/// <param name="drugStoreWriteRepository">Репозиторий для операций, изменяющих данные об аптеках.</param>
public class UpdateDrugStoreCommandHandler(IDrugStoreWriteRepository drugStoreWriteRepository):IRequestHandler<UpdateDrugStoreCommand, Unit>
{
    /// <summary>
    ///  Обрабатывает команду обновления аптеки в базе данных.
    /// </summary>
    /// <param name="request">Запрос с объектом <see cref="DrugStore"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(UpdateDrugStoreCommand request, CancellationToken cancellationToken)
    {
        await drugStoreWriteRepository.UpdateAsync(request.DrugStore, cancellationToken);
        return Unit.Value;
    }
}