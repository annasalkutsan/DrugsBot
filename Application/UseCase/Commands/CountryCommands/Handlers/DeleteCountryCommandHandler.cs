using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.CountryCommands.Handlers;

/// <summary>
/// Обработчик команды для удаления страны.
/// </summary>
/// <param name="countryWriteRepository">Репозиторий для операций, изменяющих данные о странах.</param>
public class DeleteCountryCommandHandler(ICountryWriteRepository countryWriteRepository):IRequestHandler<DeleteCountryCommand, Unit>
{
    /// <summary>
    ///  Обрабатывает команду удаления страны из базы данных.
    /// </summary>
    /// <param name="request"> Запрос с идентификатор сущности <see cref="Country"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(DeleteCountryCommand request, CancellationToken cancellationToken)
    {
        await countryWriteRepository.DeleteAsync(request.Id, cancellationToken);
        return Unit.Value;
    }
}