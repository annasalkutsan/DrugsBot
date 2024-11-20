using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.CountryCommands.Handlers;

/// <summary>
/// Обработчик команды для добавления новой страны.
/// </summary>
/// <param name="countryWriteRepository">Репозиторий для операций, изменяющих данные о странах.</param>
public class AddCountryCommandHandler(ICountryWriteRepository countryWriteRepository):IRequestHandler<AddCountryCommand, Unit>
{
    /// <summary>
    ///  Обрабатывает команду добавления новой страны в базу данных.
    /// </summary>
    /// <param name="request">Запрос с объектом <see cref="Country"/>.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns></returns>
    public async Task<Unit> Handle(AddCountryCommand request, CancellationToken cancellationToken)
    {
        await countryWriteRepository.AddAsync(request.Country, cancellationToken);
        return Unit.Value;
    }
}