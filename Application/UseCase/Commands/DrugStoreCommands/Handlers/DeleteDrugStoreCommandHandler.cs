using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.DrugStoreCommands.Handlers;

/// <summary>
/// Обработчик команды для удаления аптеки.
/// </summary>
/// <param name="drugStoreWriteRepository">Репозиторий для операций, изменяющих данные об аптеках.</param>
public class DeleteDrugStoreCommandHandler(IDrugStoreWriteRepository drugStoreWriteRepository):IRequestHandler<DeleteDrugStoreCommand, Unit>
{
    /// <summary>
    ///  Обрабатывает команду удаления аптеки из базы данных.
    /// </summary>
    /// <param name="request"> Запрос с идентификатор сущности <see cref="DrugStore"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(DeleteDrugStoreCommand request, CancellationToken cancellationToken)
    {
        await drugStoreWriteRepository.DeleteAsync(request.Id, cancellationToken);
        return Unit.Value;
    }
}