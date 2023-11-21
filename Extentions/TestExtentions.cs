using ANLA.Artemisa.GestionDocumentalApi.Repositories;
using ANLA.Artemisa.GestionDocumentalApi.Repositories.Test;
using ANLA.Artemisa.GestionDocumentalApi.Services.Test;

namespace ANLA.Artemisa.GestionDocumentalApi.Extentions
{
    public static class TestExtentions
    {
        public static IServiceCollection AddTestExtentions(this IServiceCollection services)
        {
            services.AddScoped<ITestServices, TestServices>();
            services.AddScoped<ITestRepositories, TestRepositories>();

            return services;
        }


    }
}
