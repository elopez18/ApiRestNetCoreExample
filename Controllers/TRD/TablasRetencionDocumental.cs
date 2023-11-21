using ANLA.Artemisa.GestionDocumental.Api.Services;
using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace ANLA.Artemisa.GestionDocumental.Api.Controllers
{
    /// <summary>
    /// TablasRetencionDocumentalController
    /// </summary>
    [Route("api/[controller]")]
    public class TablasRetencionDocumentalController : Controller
    {
        private readonly ITablasRetencionDocumentalService _ITablasRetencionDocumentalServices;
        private readonly ILogger<TablasRetencionDocumentalController> _logger;

        /// <summary>
        /// Constructor TablasRetencionDocumentalController
        /// </summary>
        /// <param name="TablasRetencionDocumentalServices"></param>
        /// <param name="logger"></param>
        public TablasRetencionDocumentalController(ITablasRetencionDocumentalService TablasRetencionDocumentalServices,
            ILogger<TablasRetencionDocumentalController> logger)
        {
            _ITablasRetencionDocumentalServices = TablasRetencionDocumentalServices;
            _logger = logger;
        }

        /// <summary>
        /// Permite Aplicar Tablas de Retencion Documental por Dependencia.
        /// </summary>
        /// <remarks>
        /// Metodo que permite Aplicar Tablas de Retencion Documental por Dependencia.
        /// </remarks>
        /// <param name="Usuario">Usuario con acceso a consultar.</param>
        /// <param name="Documento">Número de radicado a consultar.</param>
        /// <returns> Permite Aplicar Tablas de Retencion Documental por Dependencia.</returns>
        /// <response code="200">Aplicacion de Tablas de Retencion Documental por Dependencia con éxito y se devolvió la información del radicado.</response>
        /// <response code="404">No se pudo Aplicar Tablas de Retencion Documental por Dependencia..</response>
        /// <response code="550">Se presento un error al ejecutar el Metodo AplicarTRDDependencia.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [HttpGet("AplicarTRDDependencia")]
        public async Task<IActionResult> AplicarTRDDependencia(string Usuario, string Documento)
        {
            try
            {
                string objetoLogger = "{" + Usuario.ToString() + ":" + Documento.ToString() + "}";
                _logger.LogInformation("Consulta de AplicarTRDDependencia registrada en el sistema por elemento , {Usuario, Documento}: " + objetoLogger);

                string fechaActual = DateTime.Now.ToString("yyyy/MM/dd");
                var usuario = "{\"UsuarioTXDT\":[{\"documento\":null,\"login\":\"" + Usuario + "\"}]}";
                string radicado = @"{""datosConsultarRadicado"": [{""NoRadicado"": """ + Documento + @""",""fechaInicio"": ""2022/01/01"",""fechaFin"": """ + fechaActual + @"""}]}";

                var coleccion = await _ITablasRetencionDocumentalServices.AplicarTRDDependencia(usuario, radicado);
                if (coleccion != null)
                {
                    return Ok(new ApiResponse("Consulta Exitosa de AplicarTRDDependencia.", coleccion, 200));
                }
                else
                {
                    return NotFound(new ApiResponse("No existen registros de AplicarTRDDependencia en el sistema.", null, 404));
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Error en consulta de AplicarTRDDependencia. Detalle del error: ", ex.Message);
                return NotFound(new ApiResponse("No encontrado.", null, 550));
            }

        }
    }
}