using Iuliia;
using Services.Models;

namespace Services;

internal sealed class TransliterationService : ITransliterationService
{
    public string Transliterate(string text, TransliterationSchema transliterationSchema)
    {
        var scheme = GetSchema(transliterationSchema);

        return IuliiaTranslator.Translate(text, scheme);
    }

    public TransliterationSchemaInfo GetSchemaInfo(TransliterationSchema schema)
    {
        var scheme = GetSchema(schema);

        return new TransliterationSchemaInfo
        {
            Name = scheme.Name,
            TransliterationSchema = schema,
            Samples = scheme.Samples.Select(s => new TransliterationSchemaInfo.Sample
            {
                Original = s.Original,
                Translated = s.Translated
            }).ToList()
        };
    }

    public IReadOnlyList<TransliterationSchemaInfo> GetSchemasInfo()
    {
        var schemas = Enum.GetValues<TransliterationSchema>();
        var schemasInfo = new List<TransliterationSchemaInfo>(schemas.Length);

        schemasInfo.AddRange(schemas.Select(GetSchemaInfo));

        return schemasInfo;
    }

    private static Scheme GetSchema(TransliterationSchema schema)
    {
        return schema switch
        {
            TransliterationSchema.Wikipedia => Schemas.Wikipedia,
            TransliterationSchema.MosMetro => Schemas.Mosmetro,
            TransliterationSchema.YandexMaps => Schemas.YandexMaps,
            TransliterationSchema.YandexMoney => Schemas.YandexMoney,
            TransliterationSchema.Telegram => Schemas.Telegram,
            TransliterationSchema.Scientific => Schemas.Scientific,
            TransliterationSchema.AlaLc => Schemas.ALA_LC,
            TransliterationSchema.AlaLcAlt => Schemas.ALA_LC_ALT,
            TransliterationSchema.BgnPcgn => Schemas.BGN_PCGN,
            TransliterationSchema.BgnPcgnAlt => Schemas.BGN_PCGN_ALT,
            TransliterationSchema.Bs2979 => Schemas.BS_2979,
            TransliterationSchema.Bs2979Alt => Schemas.BS_2979_ALT,
            TransliterationSchema.Gost16876 => Schemas.GOST_16876,
            TransliterationSchema.Gost16876Alt => Schemas.GOST_16876_ALT,
            TransliterationSchema.Gost52290 => Schemas.GOST_52290,
            TransliterationSchema.Gost52535 => Schemas.GOST_52535,
            TransliterationSchema.Gost7034 => Schemas.GOST_7034,
            TransliterationSchema.Gost779 => Schemas.GOST_779,
            TransliterationSchema.Gost779Alt => Schemas.GOST_779_ALT,
            TransliterationSchema.IcaoDoc9303 => Schemas.ICAO_DOC_9303,
            TransliterationSchema.Iso91954 => Schemas.ISO_9_1954,
            TransliterationSchema.Iso91968 => Schemas.ISO_9_1968,
            TransliterationSchema.Iso91968Alt => Schemas.ISO_9_1968_ALT,
            TransliterationSchema.Mvd310 => Schemas.MVD_310,
            TransliterationSchema.Mvd310Fr => Schemas.MVD_310_FR,
            TransliterationSchema.Mvd782 => Schemas.MVD_782,
            TransliterationSchema.Ungegn1987 => Schemas.UNGEGN_1987,
            _ => throw new ArgumentOutOfRangeException(nameof(schema), schema, "Неизвестная схема транслитерации")
        };
    }
}