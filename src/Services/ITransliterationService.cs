using Services.Models;

namespace Services;

/// <summary>
/// Сервис транслитерации текста.
/// </summary>
public interface ITransliterationService
{
    /// <summary>
    /// Транслитерация текста.
    /// </summary>
    /// <param name="text">Текст для транслитерации.</param>
    /// <param name="transliterationSchema">Схема транслитерации.</param>
    /// <returns>Результат транслитерации.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Неизвестная схема транслитерации.</exception>
    string Transliterate(string text, TransliterationSchema transliterationSchema);
    
    /// <summary>
    /// Получить информацию о схеме транслитерации.
    /// </summary>
    /// <param name="schema">Схема транслитерации.</param>
    /// <returns>Информация о схеме транслитерации.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Неизвестная схема транслитерации.</exception>
    TransliterationSchemaInfo GetSchemaInfo(TransliterationSchema schema);

    /// <summary>
    /// Получить информацию о всех схемах транслитерации.
    /// </summary>
    /// <returns>Список информации о всех схемах транслитерации.</returns>
    IReadOnlyList<TransliterationSchemaInfo> GetSchemasInfo();
}