using ANLA.Artemisa.GestionDocumental.Api.Models;

namespace ANLA.Artemisa.GestionDocumental.Api.Services
{
    /// <summary>
    /// Interfaz ITablasRetencionDocumentalService
    /// </summary>
    public interface ITablasRetencionDocumentalService
    {

        /// <summary>
        /// AplicarTRDDependencia
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Documento"></param>
        /// <returns></returns>
        Task<TablasRetencionDocumental> AplicarTRDDependencia(string Usuario, string Documento);
        
    }
}
