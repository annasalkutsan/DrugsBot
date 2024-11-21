using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.FavoriteDrugCommands;

/// <summary>
/// Команда для обновления избранного лекарства.
/// </summary>
/// <param name="FavoriteDrug">Объект сущности <see cref="FavoriteDrug"/>, который необходимо обновить.</param>
public record UpdateFavoriteDrugCommand(FavoriteDrug FavoriteDrug) : IRequest<Unit>;