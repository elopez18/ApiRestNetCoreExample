using ANLA.Artemisa.GestionDocumental.Api.Repositories;
using ANLA.Artemisa.GestionDocumental.Api.Services;

namespace ANLA.Artemisa.GestionDocumentalApi.Extentions
{
    /// <summary>
    /// RadicadoExtentions
    /// </summary>
    public static class RadicadoExtentions
    {
        /// <summary>
        /// AddRadicadoExtentions
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRadicadoExtentions(this IServiceCollection services)
        {
            services.AddScoped<IRadicadoService, RadicadoService>();
            services.AddScoped<IRadicadoRepositories, RadicadoRepositories>();

            return services;
        }
    }
}
