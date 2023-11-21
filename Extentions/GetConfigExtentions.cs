using ANLA.Artemisa.GestionDocumentalApi.Helpers.Configuration;
using ANLA.Artemisa.GestionDocumentalApi.Repositories.Test;
using ANLA.Artemisa.GestionDocumentalApi.Services.Test;

namespace ANLA.Artemisa.GestionDocumentalApi.Extentions
{
    public static class GetConfigExtentions
    {
        public static IServiceCollection AddGetConfigExtentions(this IServiceCollection services)
        {
            services.AddScoped<IGetConfig, GetConfig>();
            
            return services;
        }
    }
}
