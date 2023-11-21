using ANLA.Artemisa.GestionDocumental.Api.Repositories;
using ANLA.Artemisa.GestionDocumental.Api.Services;

namespace ANLA.Artemisa.GestionDocumentalApi.Extentions
{
    /// <summary>
    /// ExpedienteExtentions
    /// </summary>
    public static class ExpedienteExtentions
    {
        /// <summary>
        /// AddExpedienteExtentions
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddExpedienteExtentions(this IServiceCollection services)
        {
            services.AddScoped<IExpedienteService, ExpedienteService>();
            services.AddScoped<IExpedienteRepositories, ExpedienteRepositories>();

            return services;
        }
    }
}
