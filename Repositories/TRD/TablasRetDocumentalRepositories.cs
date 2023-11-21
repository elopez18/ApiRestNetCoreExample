using AutoMapper;
using OrfeoServiceWCF;

namespace ANLA.Artemisa.GestionDocumental.Api.Repositories
{
    /// <summary>
    /// TablasRetencionDocumentalRepositories
    /// </summary>
    public class TablasRetencionDocumentalRepositories
    {
        private readonly IMapper _mapper;
        private readonly ILogger<TablasRetencionDocumentalRepositories> _logger;
        private readonly OrfeoServiceWCFClient _orfeoServiceWCFClient;

        /// <summary>
        /// Constructor TablasRetencionDocumentalRepositories
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        public TablasRetencionDocumentalRepositories(IMapper mapper, ILogger<TablasRetencionDocumentalRepositories> logger)
        {
            _mapper = mapper;
            _logger = logger;
            _orfeoServiceWCFClient = new OrfeoServiceWCFClient();
        }

        /// <summary>
        /// AplicarTRDDependenciaRepositories
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Radicado"></param>
        /// <returns></returns>
        public async Task<Models.TablasRetencionDocumental> AplicarTRDDependenciaRepositories(string Usuario, string Radicado)
        {
            Models.TablasRetencionDocumental colecionTRD = new Models.TablasRetencionDocumental();

            try
            {
                _logger.LogInformation("Consulta de Radicado registrado, {Usuario, Radicado}: {" + Usuario + "," + Radicado + "}");
                var result = await _orfeoServiceWCFClient.aplicarTRDDependenciaJSONAsync(Usuario, Radicado);
                Models.TablasRetencionDocumental root = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.TablasRetencionDocumental>(result.aplicarTRDDependenciaJSONResult);
                return root;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error en la consulta del Radicado en el sistema. Detalle del error: " + ex.Message);
            }

            return colecionTRD;
        }


    }
}
