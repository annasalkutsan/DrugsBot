using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.CountryCommands;

/// <summary>
/// Команда для добавления новой страны.
/// </summary>
/// <param name="Country">Объект сущности <see cref="Country"/>, который необходимо добавить.</param>
public record AddCountryCommand(Country Country) : IRequest<Unit>;