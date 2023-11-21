using AutoMapper;
using OrfeoServiceWCF;

namespace ANLA.Artemisa.GestionDocumental.Api.Repositories
{
    /// <summary>
    /// DocumentoRepositories
    /// </summary>
    public class DocumentoRepositories : IDocumentoRepositories
    {
        private readonly IMapper _mapper;
        private readonly ILogger<DocumentoRepositories> _logger;
        private readonly OrfeoServiceWCFClient _orfeoServiceWCFClient;

        /// <summary>
        /// DocumentoRepositories
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        public DocumentoRepositories(IMapper mapper, ILogger<DocumentoRepositories> logger)
        {
            _mapper = mapper;
            _logger = logger;
            _orfeoServiceWCFClient = new OrfeoServiceWCFClient();
        }

        /// <summary>
        /// ConsultarDocumentoRepositories
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Documento"></param>
        /// <returns></returns>
        public async Task<Models.Documento> ConsultarDocumentoRepositories(string Usuario, string Documento)
        {
            Models.Documento colecionDocumento = new Models.Documento();

            try
            {
                _logger.LogInformation("Consulta de Documento registrado, {Usuario, Documento}: {" + Usuario + "," + Documento + "}");
                var result = await _orfeoServiceWCFClient.consultarTiposDocumentalJSONAsync(Usuario, Documento);
                Models.Documento root = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Documento>(result.consultarTiposDocumentalJSONResult);
                return root;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error en la consulta del Documento en el sistema. Detalle del error: " + ex.Message);
            }

            return colecionDocumento;
        }

        /// <summary>
        /// CargarDocumentoElectronicoRepositories
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Documento"></param>
        /// <returns></returns>
        public async Task<Models.Documento> CargarDocumentoElectronicoRepositories(string Usuario, string Documento)
        {
            Models.Documento colecionDocumento = new Models.Documento();

            try
            {
                _logger.LogInformation("Consulta de Documento registrado, {Usuario, Documento}: {" + Usuario + "," + Documento + "}");
                var result = await _orfeoServiceWCFClient.cargarDocumentoElectronicoJSONAsync(Usuario, Documento);
                Models.Documento root = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Documento>(result.cargarDocumentoElectronicoJSONResult);
                return root;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error en la consulta del Documento en el sistema. Detalle del error: " + ex.Message);
            }

            return colecionDocumento;
        }
    }
}
