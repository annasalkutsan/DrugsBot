using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.CountryCommands;

/// <summary>
/// Команда для обновления страны.
/// </summary>
/// <param name="Country">Объект сущности <see cref="Country"/>, который необходимо обновить.</param>
public record UpdateCountryCommand(Country Country) : IRequest<Unit>;