using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.FavoriteDrugCommands;

/// <summary>
/// Команда для добавления нового избранного лекарства.
/// </summary>
/// <param name="FavoriteDrug">Объект сущности <see cref="FavoriteDrug"/>, который необходимо добавить.</param>
public record AddFavoriteDrugCommand(FavoriteDrug FavoriteDrug) : IRequest<Unit>;