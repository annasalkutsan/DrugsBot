namespace Domain.Entities;

public class DrugItem : BaseEntity
{
    /// <summary>
    /// Идентификатор лекарственного препарата
    /// </summary>
    public Guid DrugId { get; set; }

    /// <summary>
    /// Препарат
    /// </summary>
    public Drug Drug { get; set; }

    /// <summary>
    /// Идентификатор аптеки
    /// </summary>
    public Guid DrugstoreId { get; set; }

    /// <summary>
    /// Аптека
    /// </summary>
    public DrugStore DrugStore { get; set; }

    /// <summary>
    /// Цена
    /// </summary>
    public decimal Cost { get; set; }

    /// <summary>
    /// Количество
    /// </summary>
    public int Count { get; set; }
}