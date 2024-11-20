using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.DrugCommands.Handlers;

/// <summary>
/// Обработчик команды для обновления лекарства.
/// </summary>
/// <param name="drugWriteRepository">Репозиторий для операций, изменяющих данные о лекарствах.</param>
public class UpdateDrugCommandHandler(IDrugWriteRepository drugWriteRepository):IRequestHandler<UpdateDrugCommand, Unit>
{
    /// <summary>
    ///  Обрабатывает команду обновления лекарства в базе данных.
    /// </summary>
    /// <param name="request">Запрос с объектом <see cref="Drug"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(UpdateDrugCommand request, CancellationToken cancellationToken)
    {
        await drugWriteRepository.UpdateAsync(request.Drug, cancellationToken);
        return Unit.Value;
    }
}