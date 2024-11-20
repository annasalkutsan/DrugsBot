using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.DrugItemCommands.Handlers;

/// <summary>
/// Обработчик команды для добавления нового лекарства в аптеке.
/// </summary>
/// <param name="drugItemWriteRepository">Репозиторий для операций, изменяющих данные о лекарствах в аптеке.</param>
public class AddDrugItemCommandHandler(IDrugItemWriteRepository drugItemWriteRepository):IRequestHandler<AddDrugItemCommand, Unit>
{
    /// <summary>
    /// Обрабатывает команду добавления нового лекарства в аптеке в базу данных.
    /// </summary>
    /// <param name="request">Запрос с объектом <see cref="DrugItem"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(AddDrugItemCommand request, CancellationToken cancellationToken)
    {
        await drugItemWriteRepository.AddAsync(request.DrugItem, cancellationToken);
        return Unit.Value;
    }
}