using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.CountryCommands.Handlers;

/// <summary>
/// Обработчик команды для обновления страны.
/// </summary>
/// <param name="countryWriteRepository">Репозиторий для операций, изменяющих данные о странах.</param>
public class UpdateCountryCommandHandler(ICountryWriteRepository countryWriteRepository):IRequestHandler<UpdateCountryCommand, Unit>
{
    /// <summary>
    ///  Обрабатывает команду обновления страны в базе данных.
    /// </summary>
    /// <param name="request">Запрос с объектом <see cref="Country"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(UpdateCountryCommand request, CancellationToken cancellationToken)
    {
        await countryWriteRepository.UpdateAsync(request.Country, cancellationToken);
        return Unit.Value;
    }
}