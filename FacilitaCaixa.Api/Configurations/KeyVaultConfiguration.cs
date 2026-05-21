using Azure.Security.KeyVault.Secrets;
using FacilitaCaixa.Api.Settings;

namespace FacilitaCaixa.Api.Configurations
{
    public static class KeyVaultConfiguration
    {
        public static AppSettings GetAppSettingsKeyVaultValues(this WebApplicationBuilder builder)
        {
            var keyVaultUrl = builder.Configuration.GetValue<string>("UrlKeyVault");

            if (string.IsNullOrEmpty(keyVaultUrl))
            {
                throw new ArgumentException("A URL do Key Vault não pode ser nula ou vazia.", nameof(keyVaultUrl));
            }

            var secretClient = new SecretClient(new Uri(keyVaultUrl), new Azure.Identity.DefaultAzureCredential());

            return InicializarAppSettings.ConfigurarAppSettings(builder.Configuration, secretClient);
        }
    }
}