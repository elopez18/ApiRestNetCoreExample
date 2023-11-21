using ANLA.Artemisa.GestionDocumental.Api.Repositories;
using ANLA.Artemisa.GestionDocumental.Api.Services;

namespace ANLA.Artemisa.GestionDocumentalApi.Extentions
{
    /// <summary>
    /// DocumentoExtentions
    /// </summary>
    public static class DocumentoExtentions
    {
        /// <summary>
        /// AddDocumentoExtentions
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddDocumentoExtentions(this IServiceCollection services)
        {
            services.AddScoped<IDocumentoService, DocumentoService>();
            services.AddScoped<IDocumentoRepositories, DocumentoRepositories>();

            return services;
        }


    }
}
