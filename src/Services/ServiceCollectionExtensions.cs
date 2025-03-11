using Microsoft.Extensions.DependencyInjection;

namespace Services;

/// <summary>
/// Классы-расширения для коллекции сервисов.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Добавление сервисов в коллекцию сервисов.
    /// </summary>
    /// <param name="services">Коллекция сервисов.</param>
    /// <returns>Обновленная коллекция сервисов.</returns>
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<ITransliterationService, TransliterationService>();

        return services;
    }
}