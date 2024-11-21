using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.ProfileQueries;

/// <summary>
/// Запрос для получения информации о пользователе по его идентификатору
/// </summary>
/// <param name="Id">Уникальный идентификатор пользователя</param>
/// <returns>Объект <see cref="Profile"/> или null, если пользователь не найден</returns>
public record GetProfileByIdQuery(Guid Id) : IRequest<Profile?>;