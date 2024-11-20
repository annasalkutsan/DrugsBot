using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.DrugQueries;

/// <summary>
/// Запрос для получения информации о лекарстве по его идентификатору
/// </summary>
/// <param name="Id">Уникальный идентификатор лекарства</param>
/// <returns>Объект <see cref="Drug"/> или null, если лекарство не найдено</returns>
public record GetDrugByIdQuery(Guid Id) : IRequest<Drug?>;

//ToDo почитать про record
