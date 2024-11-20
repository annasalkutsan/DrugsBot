using Application.Interfaces.Repositories;
using MediatR;

namespace Application.UseCase.Commands.DrugCommands.Handlers;

/// <summary>
/// Обработчик команды для удаления лекарства.
/// </summary>
/// <param name="drugWriteRepository">Репозиторий для операций, изменяющих данные о лекарствах.</param>
public class DeleteDrugCommandHandler(IDrugWriteRepository drugWriteRepository):IRequestHandler<DeleteDrugCommand, Unit>
{
    /// <summary>
    ///  Обрабатывает команду удаления лекарства из базы данных.
    /// </summary>
    /// <param name="request"> Запрос с идентификатор сущности <see cref="Drug"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(DeleteDrugCommand request, CancellationToken cancellationToken)
    {
        await drugWriteRepository.DeleteAsync(request.Id, cancellationToken);
        return Unit.Value;
    }
}