using MediatR;

namespace Application.UseCase.Commands.FavoriteDrugCommands;

/// <summary>
/// Команда для удаления избранного лекарства.
/// </summary>
/// <param name="ProfileId"></param>
/// <param name="DrugId"></param>
/// <param name="DrugStoreId"></param>
public record DeleteFavoriteDrugCommand(Guid ProfileId,
    Guid DrugId, Guid? DrugStoreId):IRequest<Unit>;