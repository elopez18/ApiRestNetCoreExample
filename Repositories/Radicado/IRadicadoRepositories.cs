namespace ANLA.Artemisa.GestionDocumental.Api.Repositories
{
    /// <summary>
    /// Interfaz IRadicadoRepositories
    /// </summary>
    public interface IRadicadoRepositories
    {
        /// <summary>
        /// ConsultarRadicadoRepositories
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Radicado"></param>
        /// <returns></returns>
        Task<Models.Radicado> ConsultarRadicadoRepositories(string Usuario, string Radicado);

        /// <summary>
        /// IncluirRadicadoAExpedienteRepositories
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Radicado"></param>
        /// <returns></returns>
        Task<Models.IncluirRadicadoAExpediente> IncluirRadicadoAExpedienteRepositories(string Usuario, string Radicado);

        /// <summary>
        /// ConsultarImagenRadicadoRepositories
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Radicado"></param>
        /// <returns></returns>
        Task<Models.Radicado> ConsultarImagenRadicadoRepositories(string Usuario, string Radicado);

        /// <summary>
        /// ArchivarRadicadoRepositories
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Radicado"></param>
        /// <returns></returns>
        Task<Models.Radicado> ArchivarRadicadoRepositories(string Usuario, string Radicado);
    }
}
