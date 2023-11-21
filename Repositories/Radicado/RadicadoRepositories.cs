using AutoMapper;
using OrfeoServiceWCF;
using static ANLA.Artemisa.GestionDocumental.Api.Models.Radicado;

namespace ANLA.Artemisa.GestionDocumental.Api.Repositories
{
    /// <summary>
    /// RadicadoRepositories
    /// </summary>
    public class RadicadoRepositories : IRadicadoRepositories
    {
        private readonly IMapper _mapper;
        private readonly ILogger<RadicadoRepositories> _logger;
        private readonly OrfeoServiceWCFClient _orfeoServiceWCFClient;

        /// <summary>
        /// Constructor RadicadoRepositories
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        public RadicadoRepositories(IMapper mapper, ILogger<RadicadoRepositories> logger)
        {
            _mapper = mapper;
            _logger = logger;
            _orfeoServiceWCFClient = new OrfeoServiceWCFClient();
        }

        /// <summary>
        /// ConsultarRadicadoRepositories
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Radicado"></param>
        /// <returns></returns>
        public async Task<Models.Radicado> ConsultarRadicadoRepositories(string Usuario, string Radicado)
        {
            Models.Radicado coleccionRadicado = new Models.Radicado();

            try
            {
                _logger.LogInformation("Consulta de Radicado registrado, {Usuario, Radicado}: {" + Usuario + "," + Radicado + "}");
                var result = await _orfeoServiceWCFClient.consultarRadicadoJSONAsync(Usuario, Radicado);
                RespuestaServicio RespuestaObjeto = Newtonsoft.Json.JsonConvert.DeserializeObject<RespuestaServicio>(result.consultarRadicadoJSONResult);

                if (RespuestaObjeto.RespuestaEstado != null && RespuestaObjeto.RespuestaEstado.Length > 0)
                {
                    coleccionRadicado.ExistenRegistros = false;
                    coleccionRadicado.Mensaje = RespuestaObjeto.RespuestaEstado[0].Mensaje.ToString();
                }
                else
                {
                    coleccionRadicado.ExistenRegistros = true;
                    coleccionRadicado.Mensaje = RespuestaObjeto.RespuestaEstado[0].Mensaje.ToString();
                    coleccionRadicado = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Radicado>(result.consultarRadicadoJSONResult);
                }

                return coleccionRadicado;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error en la consulta del Radicado en el sistema. Detalle del error: " + ex.Message);
            }

            return coleccionRadicado;
        }

        /// <summary>
        /// IncluirRadicadoAExpedienteRepositories
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Radicado"></param>
        /// <returns></returns>
        public async Task<Models.IncluirRadicadoAExpediente> IncluirRadicadoAExpedienteRepositories(string Usuario, string Radicado)
        {
            Models.IncluirRadicadoAExpediente coleccionRadicado = new Models.IncluirRadicadoAExpediente();

            try
            {
                _logger.LogInformation("Consulta de Radicado registrado, {Usuario, Radicado}: {" + Usuario + "," + Radicado + "}");
                var result = await _orfeoServiceWCFClient.incluirRadicadoAExpedienteJSONAsync(Usuario, Radicado);
                RespuestaServicio RespuestaObjeto = Newtonsoft.Json.JsonConvert.DeserializeObject<RespuestaServicio>(result.incluirRadicadoAExpedienteJSONResult);

                if (RespuestaObjeto.RespuestaEstado != null && RespuestaObjeto.RespuestaEstado.Length > 0)
                {
                    coleccionRadicado.ExistenRegistros = false;
                    coleccionRadicado.Mensaje = RespuestaObjeto.RespuestaEstado[0].Mensaje.ToString();
                }
                else
                {
                    coleccionRadicado.ExistenRegistros = true;
                    coleccionRadicado.Mensaje = RespuestaObjeto.RespuestaEstado[0].Mensaje.ToString();
                    coleccionRadicado = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.IncluirRadicadoAExpediente>(result.incluirRadicadoAExpedienteJSONResult);
                }

                return coleccionRadicado;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error en la consulta del Radicado en el sistema. Detalle del error: " + ex.Message);
            }

            return coleccionRadicado;
        }

        /// <summary>
        /// ConsultarImagenRadicadoRepositories
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Radicado"></param>
        /// <returns></returns>
        public async Task<Models.Radicado> ConsultarImagenRadicadoRepositories(string Usuario, string Radicado)
        {
            Models.Radicado colecionRadicado = new Models.Radicado();

            try
            {
                _logger.LogInformation("Consulta de Radicado registrado, {Usuario, Radicado}: {" + Usuario + "," + Radicado + "}");
                var result = await _orfeoServiceWCFClient.consultarImagenAnexoExpedienteJSONAsync(Usuario, Radicado);
                Models.Radicado root = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Radicado>(result.consultarImagenAnexoExpedienteJSONResult);
                return root;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error en la consulta del Radicado en el sistema. Detalle del error: " + ex.Message);
            }

            return colecionRadicado;
        }

        /// <summary>
        /// ArchivarRadicadoRepositories
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Radicado"></param>
        /// <returns></returns>
        public async Task<Models.Radicado> ArchivarRadicadoRepositories(string Usuario, string Radicado)
        {
            Models.Radicado colecionRadicado = new Models.Radicado();

            try
            {
                _logger.LogInformation("Consulta de Radicado registrado, {Usuario, Radicado}: {" + Usuario + "," + Radicado + "}");
                var result = await _orfeoServiceWCFClient.archivarRadicadoJSONAsync(Usuario, Radicado);
                Models.Radicado root = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Radicado>(result.archivarRadicadoJSONResult);
                return root;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error en la consulta del Radicado en el sistema. Detalle del error: " + ex.Message);
            }

            return colecionRadicado;
        }
    }
}
