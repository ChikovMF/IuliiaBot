namespace Services.Models;

/// <summary>
/// Информация о схеме транслитерации.
/// </summary>
public sealed class TransliterationSchemaInfo
{
    /// <summary>
    /// Название схемы.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Схема транслитерации.
    /// </summary>
    public required TransliterationSchema TransliterationSchema { get; init; }

    /// <summary>
    /// Примеры транслитерации.
    /// </summary>
    public required IReadOnlyList<Sample> Samples { get; init; } = Array.Empty<Sample>();

    /// <summary>
    /// Пример транслитерации.
    /// </summary>
    public class Sample
    {
        /// <summary>
        /// Исходный текст.
        /// </summary>
        public required string Original { get; init; }

        /// <summary>
        /// Результат транслитерации.
        /// </summary>
        public required string Translated { get; init; }
    }
}