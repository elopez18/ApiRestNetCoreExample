using ANLA.Artemisa.GestionDocumental.Api.Models;

namespace ANLA.Artemisa.GestionDocumental.Api.Services
{
    /// <summary>
    /// IDocumentoService
    /// </summary>
    public interface IDocumentoService
    {
        /// <summary>
        /// ConsultarDocumentoService
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Documento"></param>
        /// <returns></returns>
        Task<Documento> ConsultarDocumentoService(string Usuario, string Documento);

        /// <summary>
        /// CargarDocumentoElectronicoService
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Documento"></param>
        /// <returns></returns>
        Task<Documento> CargarDocumentoElectronicoService(string Usuario, string Documento);
    }
}
