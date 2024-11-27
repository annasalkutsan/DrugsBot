﻿using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Dal;

/// <summary>
/// Контекст базы данных
/// Наследуется от <see cref="DbContext"/> и предоставляет доступ к таблицам базы данных через DbSet для каждой сущности.
/// </summary>
public class DrugsBotDbContext:DbContext
{
    public DrugsBotDbContext(DbContextOptions<DrugsBotDbContext> options) : base(options) { }

    public DrugsBotDbContext()
    { }
    
    /// <summary>
    /// Таблица для хранения информации о препаратах.
    /// </summary>
    public DbSet<Drug> Drugs { get; set; }

    /// <summary>
    /// Таблица для хранения информации о аптеках.
    /// </summary>
    public DbSet<DrugStore> DrugStores { get; set; }

    /// <summary>
    /// Таблица для хранения информации о препаратах в аптеках.
    /// </summary>
    public DbSet<DrugItem> DrugItems { get; set; }

    /// <summary>
    /// Таблица для хранения информации о странах.
    /// </summary>
    public DbSet<Country> Countries { get; set; }

    /// <summary>
    /// Таблица для хранения профилей пользователей.
    /// </summary>
    public DbSet<Profile> Profiles { get; set; }

    /// <summary>
    /// Таблица для хранения избранных препаратов пользователей.
    /// </summary>
    public DbSet<FavoriteDrug> FavoriteDrugs { get; set; }

    /// <summary>
    /// Конфигурирует модели сущностей при создании базы данных, включая применение всех конфигураций из текущей сборки.
    /// </summary>
    /// <param name="modelBuilder">Объект, используемый для конфигурации моделей.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    
    /// <summary>
    /// Конфигурирует параметры подключения к базе данных.
    /// </summary>
    /// <param name="optionsBuilder">Объект, который используется для конфигурации параметров контекста базы данных.</param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=12345;Database=postgres;");
        }
    }
}