using ANLA.Artemisa.GestionDocumental.Api.Models;
using ANLA.Artemisa.GestionDocumental.Api.Repositories;

namespace ANLA.Artemisa.GestionDocumental.Api.Services
{
    public class RadicadoService : IRadicadoService
    {
        private readonly IRadicadoRepositories _IRadicadoServices;
        private readonly ILogger<RadicadoService> _logger;

        public RadicadoService(IRadicadoRepositories RadicadoRepositories, ILogger<RadicadoService> logger)
        {
            _IRadicadoServices = RadicadoRepositories;
            _logger = logger;
        }

        public async Task<Radicado> ConsultarRadicadoService(string Usuario, string Radicado)
        {
            Models.Radicado coleccionRadicado = new Models.Radicado();

            try
            {
                if (!string.IsNullOrEmpty(Usuario) && !string.IsNullOrEmpty(Radicado.ToString()))
                {
                    coleccionRadicado = await _IRadicadoServices.ConsultarRadicadoRepositories(Usuario, Radicado);
                }
                else
                {
                    _logger.LogError("Parametros de consulta de elemento de Radicado errados, {Usuario, Radicado}:", "{" + Usuario + "," + Radicado + "}");
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Error en la consulta de Radicado. Detalle del error: " + ex.Message);
            }

            return coleccionRadicado;
        }
        public async Task<IncluirRadicadoAExpediente> IncluirRadicadoAExpedienteService(string Usuario, string Radicado)
        {
            Models.IncluirRadicadoAExpediente coleccionRadicado = new Models.IncluirRadicadoAExpediente();

            try
            {
                if (!string.IsNullOrEmpty(Usuario) && !string.IsNullOrEmpty(Radicado.ToString()))
                {
                    coleccionRadicado = await _IRadicadoServices.IncluirRadicadoAExpedienteRepositories(Usuario, Radicado);
                }
                else
                {
                    _logger.LogError("Parametros de consulta de elemento de Radicado errados, {Usuario, Radicado}:", "{" + Usuario + "," + Radicado + "}");
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Error en la consulta de Radicado. Detalle del error: " + ex.Message);
            }

            return coleccionRadicado;
        }
        public async Task<Radicado> ConsultarImagenRadicadoService(string Usuario, string Radicado)
        {
            Models.Radicado coleccionRadicado = new Models.Radicado();

            try
            {
                if (!string.IsNullOrEmpty(Usuario) && !string.IsNullOrEmpty(Radicado.ToString()))
                {
                    coleccionRadicado = await _IRadicadoServices.ConsultarImagenRadicadoRepositories(Usuario, Radicado);
                }
                else
                {
                    _logger.LogError("Parametros de consulta de elemento de Radicado errados, {Usuario, Radicado}:", "{" + Usuario + "," + Radicado + "}");
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Error en la consulta de Radicado. Detalle del error: " + ex.Message);
            }

            return coleccionRadicado;
        }
        public async Task<Radicado> ArchivarRadicadoService(string Usuario, string Radicado)
        {
            Models.Radicado coleccionRadicado = new Models.Radicado();

            try
            {
                if (!string.IsNullOrEmpty(Usuario) && !string.IsNullOrEmpty(Radicado.ToString()))
                {
                    coleccionRadicado = await _IRadicadoServices.ArchivarRadicadoRepositories(Usuario, Radicado);
                }
                else
                {
                    _logger.LogError("Parametros de consulta de elemento de Radicado errados, {Usuario, Radicado}:", "{" + Usuario + "," + Radicado + "}");
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Error en la consulta de Radicado. Detalle del error: " + ex.Message);
            }

            return coleccionRadicado;
        }
    }
}
