using JetBrains.Annotations;
using Services;
using Services.Models;

namespace UnitTest.Services;

/// <summary>
/// Тесты на <see cref="TransliterationService"/>.
/// </summary>
[TestSubject(typeof(TransliterationService))]
public sealed class TransliterationServiceTest
{
    private readonly TransliterationService _sut = new();

    [Theory(DisplayName = "Должен вернуть транслитерированный текст, на указанную схему.")]
    [MemberData(nameof(TransliterationTestData))]
    public void Method(string expectedText, TransliterationSchema schema)
    {
        // Arrange
        const string text = "ёжик, чайка, щука";

        // Act
        var result = _sut.Transliterate(text, schema);

        // Assert
        Assert.Equivalent(expectedText, result);
    }

    /// <summary>
    /// Данные для тестирования транслитерации.
    /// </summary>
    /// <returns>Возвращает ожидаемый текст и схему транслитерации.</returns>
    public static TheoryData<string, TransliterationSchema> TransliterationTestData()
    {
        return new TheoryData<string, TransliterationSchema>
        {
            { "yozhik, chayka, shchuka", TransliterationSchema.Wikipedia },
        };
    }
}