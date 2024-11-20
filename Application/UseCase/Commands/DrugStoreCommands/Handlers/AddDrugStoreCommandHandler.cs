using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.DrugStoreCommands.Handlers;

/// <summary>
/// Обработчик команды для добавления новой аптеки.
/// </summary>
/// <param name="drugStoreWriteRepository">Репозиторий для операций, изменяющих данные об аптеках.</param>
public class AddDrugStoreCommandHandler(IDrugStoreWriteRepository drugStoreWriteRepository):IRequestHandler<AddDrugStoreCommand, Unit>
{
    /// <summary>
    ///  Обрабатывает команду добавления новой аптеки в базу данных.
    /// </summary>
    /// <param name="request">Запрос с объектом <see cref="DrugStore"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(AddDrugStoreCommand request, CancellationToken cancellationToken)
    {
        await drugStoreWriteRepository.AddAsync(request.DrugStore, cancellationToken);
        return Unit.Value;
    }
}
