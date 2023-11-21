using ANLA.Artemisa.GestionDocumental.Api.Models;

namespace ANLA.Artemisa.GestionDocumental.Api.Services
{
    /// <summary>
    /// Interfaz IExpedienteService
    /// </summary>
    public interface IExpedienteService
    {
        /// <summary>
        /// ConsultarExpedienteService
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Expediente"></param>
        /// <returns></returns>
        Task<Expediente> ConsultarExpedienteService(string Usuario, string Expediente);
    }
}
