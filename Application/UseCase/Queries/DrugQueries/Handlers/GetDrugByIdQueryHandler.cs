using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCase.Queries.DrugQueries.Handlers;

/// <summary>
/// Обработчик запроса для получения информации о лекарстве по его идентификатору.
/// </summary>
/// <param name="drugReadRepository">Репозиторий для чтения данных о лекарствах.</param>
public class GetDrugByIdQueryHandler(IDrugReadRepository drugReadRepository) : IRequestHandler<GetDrugByIdQuery, Drug?>
{
    /// <summary>
    /// Обрабатывает запрос на получение лекарства по идентификатору.
    /// </summary>
    /// <param name="request">Запрос с идентификатором лекарства.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns>Объект <see cref="Drug"/> или null, если лекарство не найдено.</returns>
    public async Task<Drug?> Handle(GetDrugByIdQuery request, CancellationToken cancellationToken)
    {
        var response = await drugReadRepository.GetByIdAsync(request.Id, cancellationToken);
        return response;
    }
}
//ToDo для каждой сущности из домена сделать  страна драг и драг сторе сделать круд таким образом. а потом на другитес и фаворит (но там сложно) сделать команд (там запись обнова и удаление)
