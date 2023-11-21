namespace ANLA.Artemisa.GestionDocumental.Api.Repositories
{
    /// <summary>
    /// Interfaz ITablasRetencionDocumentalRepositories
    /// </summary>
    public interface ITablasRetencionDocumentalRepositories
    {
        /// <summary>
        /// AplicarTRDDependencia
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Radicado"></param>
        /// <returns></returns>
        Task<Models.TablasRetencionDocumental> AplicarTRDDependencia(string Usuario, string Radicado);

    }
}
