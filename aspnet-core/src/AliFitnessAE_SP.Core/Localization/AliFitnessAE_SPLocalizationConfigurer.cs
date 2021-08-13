using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AliFitnessAE_SP.Localization
{
    public static class AliFitnessAE_SPLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AliFitnessAE_SPConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AliFitnessAE_SPLocalizationConfigurer).GetAssembly(),
                        "AliFitnessAE_SP.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
