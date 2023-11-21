using ANLA.Artemisa.GestionDocumental.Api.Dto.Radicado;
using ANLA.Artemisa.GestionDocumental.Api.Services;
using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace ANLA.Artemisa.GestionDocumental.Api.Controllers
{
    /// <summary>
    /// RadicadoController
    /// </summary>
    [Route("api/[controller]")]
    public class RadicadoController : Controller
    {
        private readonly IRadicadoService _IRadicadoServices;
        private readonly ILogger<RadicadoController> _logger;

        /// <summary>
        /// Constructor del Controller RadicadoController
        /// </summary>
        /// <param name="RadicadoServices"></param>
        /// <param name="logger"></param>
        public RadicadoController(IRadicadoService RadicadoServices,
            ILogger<RadicadoController> logger)
        {
            _IRadicadoServices = RadicadoServices;
            _logger = logger;
        }

        /// <summary>
        /// Consulta la información asociada a un radicado específico.
        /// </summary>
        /// <remarks>
        /// Metodo consulta sobre Orfeo si el radicado ingresado existe o no.
        /// </remarks>
        /// <param name="Usuario">Usuario con acceso a consultar.</param>
        /// <param name="Radicado">Número de radicado a consultar.</param>
        /// <returns>Información detallada del radicado.</returns>
        /// <response code="200">La consulta se realizó con éxito y se devolvió la información del radicado.</response>
        /// <response code="404">No se encontró el radicado especificado.</response>
        /// <response code="550">Se presento un error al realizar la consulta del Metodo ConsultarRadicado.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [HttpGet("ConsultarRadicado/{radicado}")]
        public async Task<IActionResult> ConsultarRadicado(string Usuario, string Radicado)
        {
            try
            {
                _logger.LogInformation("Consultar Radicado registrada en el sistema");
                string objetoLogger = "{" + Usuario.ToString() + ":" + Radicado.ToString() + "}";
                string fechaActual = DateTime.Now.ToString("yyyy/MM/dd");
                var usuario = "{\"UsuarioTXDT\":[{\"documento\":null,\"login\":\"" + Usuario + "\"}]}";
                string radicado = @"{""datosConsultarRadicado"": [{""NoRadicado"": """ + Radicado + @""",""fechaInicio"": ""2022/01/01"",""fechaFin"": """ + fechaActual + @"""}]}";

                var coleccionRadicado = await _IRadicadoServices.ConsultarRadicadoService(usuario, radicado);

                if (coleccionRadicado.ExistenRegistros == true)
                {
                    return Ok(new ApiResponse("Consulta Exitosa de Radicado.", coleccionRadicado, 200));
                }
                else
                {
                    return NotFound(new ApiResponse(coleccionRadicado.Mensaje.Replace("\n", ""), null, 404));
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Error en consulta de ConsultarRadicado. Detalle del error: ", ex.Message);
                return NotFound(new ApiResponse("Not Found.", null, 550));
            }
        }

        /// <summary>
        /// Incluye radicados a un expediente
        /// </summary>
        /// <remarks>
        /// Metodo sobre Orfeo para incluir un Radicado A un Expediente.
        /// </remarks>
        /// <param name="Usuario"></param>
        /// <param name="Radicado"></param>
        /// <returns></returns>
        [HttpGet("IncluirRadicadoAExpediente")]
        public async Task<IActionResult> IncluirRadicadoAExpediente(string Usuario, IncluirRadicadoAExpediente incluirRadicadoAExpediente)
        {
            try
            {
                string objetoLogger = "{" + Usuario.ToString() + ":" + incluirRadicadoAExpediente.NoRadicado.ToString() + "}";
                _logger.LogInformation("Consulta de ArchivarRadicado registrada en el sistema por elemento , {Usuario, Radicado}: " + objetoLogger);

                var usuario = "{\"UsuarioTXDT\":[{\"documento\":null,\"login\":\"" + Usuario + "\"}]}";
                string radicado = @"{""datosConsultarRadicado"": [{""NoRadicado"": """ + incluirRadicadoAExpediente.NoRadicado + @""",""NoExpediente"": """ + incluirRadicadoAExpediente.NoExpediente + @""",""NoSila"": """ + incluirRadicadoAExpediente.NoSila + @"""}]}";

                var coleccion = await _IRadicadoServices.IncluirRadicadoAExpedienteService(usuario, radicado);
                if (coleccion != null)
                {
                    return Ok(new ApiResponse("Consulta Exitosa de IncluirRadicadoAExpediente.", coleccion, 200));
                }
                else
                {
                    return NotFound(new ApiResponse("No existen registros de IncluirRadicadoAExpediente en el sistema.", null, 404));
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Error en consulta de IncluirRadicadoAExpediente. Detalle del error: ", ex.Message);
                return NotFound(new ApiResponse("No encontrado.", null, 550));
            }
        }

        /// <summary>
        /// Consulta la información asociada a una Imagen de un radicado específico.
        /// </summary>
        /// <remarks>
        /// Metodo consulta sobre Orfeo si ahy una imagen asociada a un radicado ingresado existe o no.
        /// </remarks>
        /// <param name="Usuario">Usuario con acceso a consultar.</param>
        /// <param name="Radicado">Número de radicado a consultar.</param>
        /// <returns>Información detallada del radicado.</returns>
        /// <response code="200">La consulta se realizó con éxito y se devolvió la información del radicado.</response>
        /// <response code="404">No se encontró el radicado especificado.</response>
        /// <response code="550">Se presento un error al realizar la consulta del Metodo ConsultarRadicado.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [HttpGet("ConsultarImagenRadicado")]
        public async Task<IActionResult> ConsultarImagenRadicado(string Usuario, string Radicado)
        {
            try
            {
                string objetoLogger = "{" + Usuario.ToString() + ":" + Radicado.ToString() + "}";
                _logger.LogInformation("Consulta de ConsultarRadicado registrada en el sistema por elemento , {Usuario, Radicado}: " + objetoLogger);

                // Construir el objeto JSON con los parámetros solictados por el WSDL
                string fechaActual = DateTime.Now.ToString("yyyy/MM/dd");
                var usuario = "{\"UsuarioTXDT\":[{\"documento\":null,\"login\":\"" + Usuario + "\"}]}";
                string radicado = @"{""datosConsultarRadicado"": [{""NoRadicado"": """ + Radicado + @""",""fechaInicio"": ""2022/01/01"",""fechaFin"": """ + fechaActual + @"""}]}";


                var coleccion = await _IRadicadoServices.ConsultarImagenRadicadoService(usuario, radicado);
                if (coleccion != null)
                {
                    return Ok(new ApiResponse("Consulta Exitosa de ConsultarRadicado.", coleccion, 200));
                }
                else
                {
                    return NotFound(new ApiResponse("No existen registros de ConsultarRadicado en el sistema.", null, 404));
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Error en consulta de ConsultarRadicado. Detalle del error: ", ex.Message);
                return NotFound(new ApiResponse("No encontrado.", null, 550));
            }

        }

        /// <summary>
        /// Permite realizar el archivo de un radicado específico.
        /// </summary>
        /// <remarks>
        /// Metodo que ermite realizar el archivo de un radicado específico.
        /// </remarks>
        /// <param name="Usuario">Usuario con acceso a consultar.</param>
        /// <param name="Radicado">Número de radicado a consultar.</param>
        /// <returns> Permite realizar el archivo de un radicado específico.</returns>
        /// <response code="200">El archivo del radicado se realizó con éxito y se devolvió la información del radicado.</response>
        /// <response code="404">No se pudo archivar el radicado especificado.</response>
        /// <response code="550">Se presento un error al ejecutar el Metodo ArchivarRadicado.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [HttpGet("ArchivarRadicado")]
        public async Task<IActionResult> ArchivarRadicado(string Usuario, string Radicado)
        {
            try
            {
                string objetoLogger = "{" + Usuario.ToString() + ":" + Radicado.ToString() + "}";
                _logger.LogInformation("Consulta de ConsultarRadicado registrada en el sistema por elemento , {Usuario, Radicado}: " + objetoLogger);

                string fechaActual = DateTime.Now.ToString("yyyy/MM/dd");
                var usuario = "{\"UsuarioTXDT\":[{\"documento\":null,\"login\":\"" + Usuario + "\"}]}";
                string radicado = @"{""datosConsultarRadicado"": [{""NoRadicado"": """ + Radicado + @""",""fechaInicio"": ""2022/01/01"",""fechaFin"": """ + fechaActual + @"""}]}";


                var coleccion = await _IRadicadoServices.ArchivarRadicadoService(usuario, radicado);
                if (coleccion != null)
                {
                    return Ok(new ApiResponse("Consulta Exitosa de ConsultarRadicado.", coleccion, 200));
                }
                else
                {
                    return NotFound(new ApiResponse("No existen registros de ConsultarRadicado en el sistema.", null, 404));
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Error en consulta de ConsultarRadicado. Detalle del error: ", ex.Message);
                return NotFound(new ApiResponse("No encontrado.", null, 550));
            }
        }

    }
}