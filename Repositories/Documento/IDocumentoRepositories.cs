namespace ANLA.Artemisa.GestionDocumental.Api.Repositories
{
    /// <summary>
    /// Intefaz IDocumentoRepositories
    /// </summary>
    public interface IDocumentoRepositories
    {
        /// <summary>
        /// ConsultarDocumentoRepositories
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Documento"></param>
        /// <returns></returns>
        Task<Models.Documento> ConsultarDocumentoRepositories(string Usuario, string Documento);

        /// <summary>
        /// CargarDocumentoElectronicoRepositories
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Documento"></param>
        /// <returns></returns>
        Task<Models.Documento> CargarDocumentoElectronicoRepositories(string Usuario, string Documento);
    }
}
