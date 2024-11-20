using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.DrugCommands;

/// <summary>
/// Команда для обновления лекарства.
/// </summary>
/// <param name="Drug">Объект сущности <see cref="Drug"/>, который необходимо обновить.</param>
public record UpdateDrugCommand(Drug Drug) : IRequest<Unit>;
