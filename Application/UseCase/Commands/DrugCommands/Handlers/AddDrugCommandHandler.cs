using Application.Interfaces.Repositories;
using MediatR;

namespace Application.UseCase.Commands.DrugCommands.Handlers;

/// <summary>
/// Обработчик команды для добавления нового лекарства.
/// </summary>
/// <param name="drugWriteRepository">Репозиторий для операций, изменяющих данные о лекарствах.</param>
public class AddDrugCommandHandler(IDrugWriteRepository drugWriteRepository):IRequestHandler<AddDrugCommand, Unit>
{
    /// <summary>
    ///  Обрабатывает команду добавления нового лекарства в базу данных.
    /// </summary>
    /// <param name="request">Запрос с объектом <see cref="Drug"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(AddDrugCommand request, CancellationToken cancellationToken)
    {
        await drugWriteRepository.AddAsync(request.Drug, cancellationToken);
        return Unit.Value;
    }
}
