namespace ANLA.Artemisa.GestionDocumentalApi.Helpers.Configuration
{
    public class GetConfig : IGetConfig
    {
        public IConfigurationRoot GetConfiguration()
        {
            var secret = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json");

            IConfigurationRoot Config = secret.Build();

            var secretID = Config.GetConnectionString("SecretID");

            var builder = new ConfigurationBuilder()
                      .AddUserSecrets(secretID)
                      .Build();
            return builder;
        }
    }
}





