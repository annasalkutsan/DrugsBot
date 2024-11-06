﻿using Domain.Validators;
using FluentValidation.Results;

namespace Domain.Entities;

public class DrugItem : BaseEntity
{
    public DrugItem(Guid drugId, Guid drugStoreId, decimal cost, int count, Drug drug, DrugStore drugStore)
    {
        DrugId = drugId;
        DrugStoreId = drugStoreId;
        Cost = cost;
        Count = count;
        Drug = drug;
        DrugStore = drugStore;

        IsValid();
    }
    
    /// <summary>
    /// Идентификатор лекарственного препарата
    /// </summary>
    public Guid DrugId { get; private set; }

    /// <summary>
    /// Препарат
    /// </summary>
    public Drug Drug { get; private set; }

    /// <summary>
    /// Идентификатор аптеки
    /// </summary>
    public Guid DrugStoreId { get; private set; }

    /// <summary>
    /// Аптека
    /// </summary>
    public DrugStore DrugStore { get; private set; }

    /// <summary>
    /// Цена
    /// </summary>
    public decimal Cost { get; private set; }

    /// <summary>
    /// Количество
    /// </summary>
    public int Count { get; private set; }
    
    private bool IsValid()
    {
        var validator = new DrugItemValidator();
        ValidationResult result = validator.Validate(this);

        if (!result.IsValid)
        {
            var errorMessages = string.Join(" ", result.Errors.Select(e => e.ErrorMessage));
            throw new Exception("Validation failed: " + errorMessages);
        }
        
        return true;
    }
}