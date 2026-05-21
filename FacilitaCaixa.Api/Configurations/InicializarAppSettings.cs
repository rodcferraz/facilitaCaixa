using Azure.Security.KeyVault.Secrets;
using FacilitaCaixa.Api.Settings;

namespace FacilitaCaixa.Api.Configurations
{
    public class InicializarAppSettings
    {
        public static AppSettings ConfigurarAppSettings(IConfiguration configuration, SecretClient secretClient)
        {
            var appSettings = new AppSettings();

            configuration.Bind(appSettings);

            appSettings.Teste = secretClient.GetSecret(appSettings.Teste).Value.Value;

            return appSettings;
        }
    }
}