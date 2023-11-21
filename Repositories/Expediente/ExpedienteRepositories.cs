using AutoMapper;
using OrfeoServiceWCF;

namespace ANLA.Artemisa.GestionDocumental.Api.Repositories
{
    /// <summary>
    /// ExpedienteRepositories
    /// </summary>
    public class ExpedienteRepositories : IExpedienteRepositories
    {
        private readonly IMapper _mapper;
        private readonly ILogger<ExpedienteRepositories> _logger;
        private readonly OrfeoServiceWCFClient _orfeoServiceWCFClient;

        /// <summary>
        /// Constructor ExpedienteRepositories
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        public ExpedienteRepositories(IMapper mapper, ILogger<ExpedienteRepositories> logger)
        {
            _mapper = mapper;
            _logger = logger;
            _orfeoServiceWCFClient = new OrfeoServiceWCFClient();
        }

        /// <summary>
        /// ConsultarExpedienteRepositories
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Expediente"></param>
        /// <returns></returns>
        public async Task<Models.Expediente> ConsultarExpedienteRepositories(string Usuario, string Expediente)
        {
            Models.Expediente colecionExpediente = new Models.Expediente();

            try
            {
                _logger.LogInformation("Consulta de Expediente registrado, {Usuario, Expediente}: {" + Usuario + "," + Expediente + "}");
                var result = await _orfeoServiceWCFClient.consultarExpedienteJSONAsync(Usuario, Expediente);
                Models.Expediente root = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Expediente>(result.consultarExpedienteJSONResult);
                return root;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error en la consulta del Expediente en el sistema. Detalle del error: " + ex.Message);
            }

            return colecionExpediente;
        }
    }
}
