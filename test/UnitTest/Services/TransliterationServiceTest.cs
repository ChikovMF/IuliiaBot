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
            { "ezhik, chayka, schuka", TransliterationSchema.MosMetro },
            { "yozhik, chayka, schuka", TransliterationSchema.YandexMaps },
            { "ezhik, chaika, schuka", TransliterationSchema.YandexMoney },
            { "ejik, chaika, scuka", TransliterationSchema.Telegram },
            { "ёžik, čajka, ščuka", TransliterationSchema.Scientific },
            { "ёzhik, chaĭka, shchuka", TransliterationSchema.AlaLc },
            { "ezhik, chaika, shchuka", TransliterationSchema.AlaLcAlt },
            { "yёzhik, chayka, shchuka", TransliterationSchema.BgnPcgn },
            { "yёzhik, chayka, shchuka", TransliterationSchema.BgnPcgnAlt },
            { "ёzhik, chaĭka, shchuka", TransliterationSchema.Bs2979 },
            { "ezhik, chaika, shchuka", TransliterationSchema.Bs2979Alt },
            { "ёžik, čajka, ŝuka", TransliterationSchema.Gost16876 },
            { "jozhik, chajjka, shhuka", TransliterationSchema.Gost16876Alt },
            { "yozhik, chayka, shchuka", TransliterationSchema.Gost52290 },
            { "ezhik, chaika, shchuka", TransliterationSchema.Gost52535 },
            { "yozhik, chajka, shhuka", TransliterationSchema.Gost7034 },
            { "ёžik, čajka, ŝuka", TransliterationSchema.Gost779 },
            { "yozhik, chajka, shhuka", TransliterationSchema.Gost779Alt },
            { "ezhik, chaika, shchuka", TransliterationSchema.IcaoDoc9303 },
            { "ëžik, čajka, ščuka", TransliterationSchema.Iso91954 },
            { "ëžik, čajka, ščuka", TransliterationSchema.Iso91968 },
            { "ëzhyk, chaĭka, shchuka", TransliterationSchema.Iso91968Alt },
            { "ezhik, chayka, shchuka", TransliterationSchema.Mvd310 },
            { "ejik, tchaika, chtchouka", TransliterationSchema.Mvd310Fr },
            { "yozhik, chayka, shchuka", TransliterationSchema.Mvd782 },
            { "ёžik, čajka, ščuka", TransliterationSchema.Ungegn1987 }
        };
    }
}