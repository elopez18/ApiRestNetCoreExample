using ANLA.Artemisa.GestionDocumentalApi.Repositories.Test;

namespace ANLA.Artemisa.GestionDocumentalApi.Services.Test
{
    public class TestServices : ITestServices
    {
        private readonly ILogger<TestServices> _logger;
        private readonly ITestRepositories _ITestRepositories;

        public TestServices(ITestRepositories testRepositories, ILogger<TestServices> logger)
        {
            _ITestRepositories = testRepositories;
            _logger = logger;
        }

        public async Task<bool> GetstatusAPIservices()
        {
            bool result = false;
            try
            {
                result = await _ITestRepositories.GetstatusAPIRepositories();
            }
            catch (Exception Ex)
            {
                _logger.LogWarning("Error en metodo firmaMecanicaBLL mas detalle:  " + Ex);  
            }
            return result;
        }
    }
}
