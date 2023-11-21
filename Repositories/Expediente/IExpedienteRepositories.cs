namespace ANLA.Artemisa.GestionDocumental.Api.Repositories
{
    /// <summary>
    /// Intefaz IExpedienteRepositories
    /// </summary>
    public interface IExpedienteRepositories
    {
        /// <summary>
        /// ConsultarExpedienteRepositories
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Expediente"></param>
        /// <returns></returns>
        Task<Models.Expediente> ConsultarExpedienteRepositories(string Usuario, string Expediente);
    }
}
