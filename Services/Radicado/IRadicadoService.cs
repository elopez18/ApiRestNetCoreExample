using ANLA.Artemisa.GestionDocumental.Api.Models;

namespace ANLA.Artemisa.GestionDocumental.Api.Services
{
    /// <summary>
    /// Interfaz IRadicadoService
    /// </summary>
    public interface IRadicadoService
    {
        /// <summary>
        /// ConsultarRadicadoService
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Radicado"></param>
        /// <returns></returns>
        Task<Radicado> ConsultarRadicadoService(string Usuario, string Radicado);

        /// <summary>
        /// IncluirRadicadoAExpedienteService
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Radicado"></param>
        /// <returns></returns>
        Task<IncluirRadicadoAExpediente> IncluirRadicadoAExpedienteService(string Usuario, string Radicado);

        /// <summary>
        /// ConsultarImagenRadicadoService
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Radicado"></param>
        /// <returns></returns>
        Task<Radicado> ConsultarImagenRadicadoService(string Usuario, string Radicado);

        /// <summary>
        /// ArchivarRadicadoService
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Radicado"></param>
        /// <returns></returns>
        Task<Radicado> ArchivarRadicadoService(string Usuario, string Radicado);
    }
}
