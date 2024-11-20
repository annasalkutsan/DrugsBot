using Domain.Entities;
using MediatR;

namespace Application.UseCase.Commands.DrugCommands;

/// <summary>
/// Команда для добавления нового лекарства.
/// </summary>
/// <param name="Drug">Объект сущности <see cref="Drug"/>, который необходимо добавить.</param>
public record AddDrugCommand(Drug Drug) : IRequest<Unit>;