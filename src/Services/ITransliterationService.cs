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
}