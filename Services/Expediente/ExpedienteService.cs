using ANLA.Artemisa.GestionDocumental.Api.Repositories;

namespace ANLA.Artemisa.GestionDocumental.Api.Services
{
    /// <summary>
    /// ExpedienteService
    /// </summary>
    public class ExpedienteService : IExpedienteService
    {
        private readonly IExpedienteRepositories _IExpedienteServices;
        private readonly ILogger<ExpedienteService> _logger;

        /// <summary>
        /// Constructor ExpedienteService
        /// </summary>
        /// <param name="ExpedienteRepositories"></param>
        /// <param name="logger"></param>
        public ExpedienteService(IExpedienteRepositories ExpedienteRepositories, ILogger<ExpedienteService> logger)
        {
            _IExpedienteServices = ExpedienteRepositories;
            _logger = logger;
        }

        /// <summary>
        /// ConsultarExpedienteService
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Expediente"></param>
        /// <returns></returns>
        public async Task<Models.Expediente> ConsultarExpedienteService(string Usuario, string Expediente)
        {
            Models.Expediente coleccionExpediente = new Models.Expediente();

            try
            {
                if (!string.IsNullOrEmpty(Usuario) && !string.IsNullOrEmpty(Expediente.ToString()))
                {
                    coleccionExpediente = await _IExpedienteServices.ConsultarExpedienteRepositories(Usuario, Expediente);
                }
                else
                {
                    _logger.LogError("Parametros de consulta de elemento de Expediente errados, {Usuario, Expediente}:", "{" + Usuario + "," + Expediente + "}");
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Error en la consulta de Expediente. Detalle del error: " + ex.Message);
            }

            return coleccionExpediente;
        }
    }
}
