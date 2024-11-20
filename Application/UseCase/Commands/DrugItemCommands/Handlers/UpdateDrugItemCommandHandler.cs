using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.DrugItemCommands.Handlers;

/// <summary>
/// Обработчик команды для обновления лекарства в аптеке.
/// </summary>
/// <param name="drugItemWriteRepository">Репозиторий для операций, изменяющих данные о лекарствах в аптеке.</param>
public class UpdateDrugItemCommandHandler(IDrugItemWriteRepository drugItemWriteRepository):IRequestHandler<UpdateDrugItemCommand, Unit>
{
    /// <summary>
    ///  Обрабатывает команду обновления лекарства в аптеке в базе данных.
    /// </summary>
    /// <param name="request">Запрос с объектом <see cref="DrugItem"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(UpdateDrugItemCommand request, CancellationToken cancellationToken)
    {
        await drugItemWriteRepository.UpdateAsync(request.DrugItem, cancellationToken);
        return Unit.Value;
    }
}