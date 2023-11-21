using ANLA.Artemisa.GestionDocumental.Api.Repositories;

namespace ANLA.Artemisa.GestionDocumental.Api.Services
{
    /// <summary>
    /// TablasRetencionDocumentalService
    /// </summary>
    public class TablasRetencionDocumentalService : ITablasRetencionDocumentalService
    {
        private readonly ITablasRetencionDocumentalRepositories _ITablasRetencionDocumentalServices;
        private readonly ILogger<TablasRetencionDocumentalService> _logger;

        /// <summary>
        /// Constructor TablasRetencionDocumentalService
        /// </summary>
        /// <param name="TablasRetencionDocumentalRepositories"></param>
        /// <param name="logger"></param>
        public TablasRetencionDocumentalService(ITablasRetencionDocumentalRepositories TablasRetencionDocumentalRepositories, ILogger<TablasRetencionDocumentalService> logger)
        {
            _ITablasRetencionDocumentalServices = TablasRetencionDocumentalRepositories;
            _logger = logger;
        }

        /// <summary>
        /// AplicarTRDDependencia
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Documento"></param>
        /// <returns></returns>
        public async Task<Models.TablasRetencionDocumental> AplicarTRDDependencia(string Usuario, string Documento)
        {
            Models.TablasRetencionDocumental coleccionTRD = new Models.TablasRetencionDocumental();

            try
            {
                if (!string.IsNullOrEmpty(Usuario) && !string.IsNullOrEmpty(Documento.ToString()))
                {
                    coleccionTRD = await _ITablasRetencionDocumentalServices.AplicarTRDDependencia(Usuario, Documento);
                }
                else
                {
                    _logger.LogError("Parametros de consulta de elemento de Documento errados, {Usuario, Documento}:", "{" + Usuario + "," + Documento + "}");
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Error en la consulta de Documento. Detalle del error: " + ex.Message);
            }

            return coleccionTRD;
        }

    }
}
