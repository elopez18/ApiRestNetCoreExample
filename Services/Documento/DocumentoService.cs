using ANLA.Artemisa.GestionDocumental.Api.Repositories;

namespace ANLA.Artemisa.GestionDocumental.Api.Services
{
    /// <summary>
    /// DocumentoService
    /// </summary>
    public class DocumentoService : IDocumentoService
    {
        private readonly IDocumentoRepositories _IDocumentoServices;
        private readonly ILogger<DocumentoService> _logger;

        /// <summary>
        /// Constructor DocumentoService
        /// </summary>
        /// <param name="DocumentoRepositories"></param>
        /// <param name="logger"></param>
        public DocumentoService(IDocumentoRepositories DocumentoRepositories, ILogger<DocumentoService> logger)
        {
            _IDocumentoServices = DocumentoRepositories;
            _logger = logger;
        }

        /// <summary>
        /// ConsultarDocumentoService
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Documento"></param>
        /// <returns></returns>
        public async Task<Models.Documento> ConsultarDocumentoService(string Usuario, string Documento)
        {
            Models.Documento coleccionDocumento = new Models.Documento();

            try
            {
                if (!string.IsNullOrEmpty(Usuario) && !string.IsNullOrEmpty(Documento.ToString()))
                {
                    coleccionDocumento = await _IDocumentoServices.ConsultarDocumentoRepositories(Usuario, Documento);
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

            return coleccionDocumento;
        }

        /// <summary>
        /// CargarDocumentoElectronicoService
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Documento"></param>
        /// <returns></returns>
        public async Task<Models.Documento> CargarDocumentoElectronicoService(string Usuario, string Documento)
        {
            Models.Documento coleccionDocumento = new Models.Documento();

            try
            {
                if (!string.IsNullOrEmpty(Usuario) && !string.IsNullOrEmpty(Documento.ToString()))
                {
                    coleccionDocumento = await _IDocumentoServices.CargarDocumentoElectronicoRepositories(Usuario, Documento);
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

            return coleccionDocumento;
        }
    }
}
