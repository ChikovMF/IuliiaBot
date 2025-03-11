namespace Services.Models;

/// <summary>
/// Схема транслитерации.
/// </summary>
public enum TransliterationSchema
{
    /// <summary>
    /// Википедия.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/wikipedia/">Схема</see>.
    /// </remarks>
    Wikipedia,

    /// <summary>
    /// Московский метрополитен.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/mosmetro/">Схема</see>.
    /// </remarks>
    MosMetro,

    /// <summary>
    /// Яндекс.Карты.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/yandex-maps/">Схема</see>.
    /// </remarks>
    YandexMaps,

    /// <summary>
    /// Яндекс.Деньги.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/yandex-money/">Схема</see>.
    /// </remarks>
    YandexMoney,

    /// <summary>
    /// Телеграм.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/telegram/">Схема</see>.
    /// </remarks>
    Telegram,

    /// <summary>
    /// Научная.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/scientific/">Схема</see>.
    /// </remarks>
    Scientific,

    /// <summary>
    /// ALA-LC.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/ala-lc/">Схема</see>.
    /// </remarks>
    AlaLc,

    /// <summary>
    /// ALA-LC (альтернативная).
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/ala-lc/">Схема</see>.
    /// </remarks>
    AlaLcAlt,

    /// <summary>
    /// BGN/PCGN.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/bgn-pcgn/">Схема</see>.
    /// </remarks>
    BgnPcgn,

    /// <summary>
    /// BGN/PCGN (альтернативная).
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/bgn-pcgn/">Схема</see>.
    /// </remarks>
    BgnPcgnAlt,

    /// <summary>
    /// British Standard 2979:1958.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/bs-2979/">Схема</see>.
    /// </remarks>
    Bs2979,

    /// <summary>
    /// British Standard 2979:1958 (альтернативная).
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/bs-2979/">Схема</see>.
    /// </remarks>
    Bs2979Alt,

    /// <summary>
    /// GOST 1983 или СТ СЭВ 1362-78.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/gost-16876/">Схема</see>.
    /// </remarks>
    Gost16876,

    /// <summary>
    /// GOST 1983 или СТ СЭВ 1362-78 (альтернативная).
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/gost-16876/">Схема</see>.
    /// </remarks>
    Gost16876Alt,

    /// <summary>
    /// ГОСТ Р 52290-2004.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/gost-52290/">Схема</see>.
    /// </remarks>
    Gost52290,

    /// <summary>
    /// ГОСТ Р 52535.1-2006.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/gost-52535/">Схема</see>.
    /// </remarks>
    Gost52535,

    /// <summary>
    /// ГОСТ Р 7.0.34-2014.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/gost-7034/">Схема</see>.
    /// </remarks>
    Gost7034,

    /// <summary>
    /// ГОСТ 7.79-2000.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/gost-779/">Схема</see>.
    /// </remarks>
    Gost779,

    /// <summary>
    /// ГОСТ 7.79-2000 (альтернативная).
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/gost-779/">Схема</see>.
    /// </remarks>
    Gost779Alt,

    /// <summary>
    /// ICAO DOC 9303.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/icao-doc-9303/">Схема</see>.
    /// </remarks>
    IcaoDoc9303,

    /// <summary>
    /// ISO/R 9:1954.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/iso-9-1954/">Схема</see>.
    /// </remarks>
    Iso91954,

    /// <summary>
    /// ISO/R 9:1968.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/iso-9-1968/">Схема</see>.
    /// </remarks>
    Iso91968,

    /// <summary>
    /// ISO/R 9:1968 (альтернативная).
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/iso-9-1968/">Схема</see>.
    /// </remarks>
    Iso91968Alt,

    /// <summary>
    /// МВД 310-1997 (Английский).
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/mvd-310/">Схема</see>.
    /// </remarks>
    Mvd310,

    /// <summary>
    /// МВД 310-1997 (Французский).
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/mvd-310/">Схема</see>.
    /// </remarks>
    Mvd310Fr,

    /// <summary>
    /// МВД 782-2000.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/mvd-782/">Схема</see>.
    /// </remarks>
    Mvd782,

    /// <summary>
    /// UNGEGN 1987 V/18.
    /// </summary>
    /// <remarks>
    /// <see href="https://iuliia.ru/ungegn-1987/">Схема</see>.
    /// </remarks>
    Ungegn1987
}