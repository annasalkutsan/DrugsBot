using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.DrugItemCommands.Handlers;

/// <summary>
/// Обработчик команды для удаления лекарства в аптеке.
/// </summary>
/// <param name="drugItemWriteRepository">Репозиторий для операций, изменяющих данные о лекарствах в аптеке.</param>
public class DeleteDrugItemCommandHandler(IDrugItemWriteRepository drugItemWriteRepository):IRequestHandler<DeleteDrugItemCommand, Unit>
{
    /// <summary>
    ///  Обрабатывает команду удаления лекарства в аптекек из базы данных.
    /// </summary>
    /// <param name="request"> Запрос с идентификаторами сущности <see cref="DrugItem"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(DeleteDrugItemCommand request, CancellationToken cancellationToken)
    {
        await drugItemWriteRepository.DeleteAsync(request.Id, cancellationToken);
        return Unit.Value;
    }
}