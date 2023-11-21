using ANLA.Artemisa.GestionDocumentalApi.Services.Test;

namespace ANLA.Artemisa.GestionDocumentalApi.Repositories.Test
{
    public class TestRepositories : ITestRepositories
    {
        private readonly ILogger<TestRepositories> _logger;

        public TestRepositories(ILogger<TestRepositories> logger) 
        {
            _logger = logger;
        }

        public Task<bool> GetstatusAPIRepositories()
        {
            return Task.FromResult(true);
        }
    }
}
