using Iuliia;
using Services.Models;

namespace Services;

public class TransliterationService : ITransliterationService
{
    public string Transliterate(string text, TransliterationSchema transliterationSchema)
    {
        var scheme = GetSchema(transliterationSchema);

        return IuliiaTranslator.Translate(text, scheme);
    }

    private static Scheme GetSchema(TransliterationSchema schema)
    {
        return schema switch
        {
            TransliterationSchema.Wikipedia => Schemas.Wikipedia,
            _ => throw new ArgumentOutOfRangeException(nameof(schema), schema, "Неизвестная схема транслитерации")
        };
    }
}