using ANLA.Artemisa.GestionDocumental.Api.Services;
using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace ANLA.Artemisa.GestionDocumental.Api.Controllers
{
    /// <summary>
    /// DocumentoController
    /// </summary>
    [Route("api/[controller]")]
    public class DocumentoController : Controller
    {
        private readonly IDocumentoService _IDocumentoServices;
        private readonly ILogger<DocumentoController> _logger;

        /// <summary>
        /// Constructor DocumentoController
        /// </summary>
        /// <param name="DocumentoServices"></param>
        /// <param name="logger"></param>
        public DocumentoController(IDocumentoService DocumentoServices,
            ILogger<DocumentoController> logger)
        {
            _IDocumentoServices = DocumentoServices;
            _logger = logger;
        }

        /// <summary>
        /// Permite realizar la consulta de un documento específico.
        /// </summary>
        /// <remarks>
        /// Metodo que permite realizar la consulta de un documento específico..
        /// </remarks>
        /// <param name="Usuario">Usuario con acceso a consultar.</param>
        /// <param name="Documento">Número de radicado a consultar.</param>
        /// <returns> Permite realizar la Consulta de un Documento específico.</returns>
        /// <response code="200">La consulta del documento se realizó con éxito y se devolvió la información del documento.</response>
        /// <response code="404">No se pudo realiza la consulta del documento especificado.</response>
        /// <response code="550">Se presento un error al ejecutar el Metodo ConsultarDocumento.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [HttpGet("ConsultarDocumento")]
        public async Task<IActionResult> ConsultarDocumento(string Usuario, string Documento)
        {
            try
            {
                string objetoLogger = "{" + Usuario.ToString() + ":" + Documento.ToString() + "}";
                _logger.LogInformation("Consulta de ConsultarDocumento registrada en el sistema por elemento , {Usuario, Documento}: " + objetoLogger);

                string fechaActual = DateTime.Now.ToString("yyyy/MM/dd");
                var usuario = "{\"UsuarioTXDT\":[{\"documento\":null,\"login\":\"" + Usuario + "\"}]}";
                string documento = @"{""datosConsultarDocumento"": [{""NoDocumento"": """ + Documento + @""",""fechaInicio"": ""2022/01/01"",""fechaFin"": """ + fechaActual + @"""}]}";

                var coleccion = await _IDocumentoServices.ConsultarDocumentoService(usuario, documento);
                if (coleccion != null)
                {
                    return Ok(new ApiResponse("Consulta Exitosa de ConsultarDocumento.", coleccion, 200));
                }
                else
                {
                    return NotFound(new ApiResponse("No existen registros de ConsultarDocumento en el sistema.", null, 404));
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Error en consulta de ConsultarDocumento. Detalle del error: ", ex.Message);
                return NotFound(new ApiResponse("No encontrado.", null, 550));
            }
        }

        /// <summary>
        /// Permite realizar Cargar un Documento Electronico.
        /// </summary>
        /// <remarks>
        /// Metodo que permite realizar Cargar un Documento Electronico.
        /// </remarks>
        /// <param name="Usuario">Usuario con acceso a consultar.</param>
        /// <param name="Documento">Documento a cargar.</param>
        /// <returns> Permite realizar la Carga de un Documento Electronico.</returns>
        /// <response code="200">La Cargar del Documento Electronico se realizó con éxito y se devolvió la información del radicado.</response>
        /// <response code="404">No se pudo Cargar Documento Electronico especificado.</response>
        /// <response code="550">Se presento un error al ejecutar el Metodo CargarDocumentoElectronico.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [HttpPost("CargarDocumentoElectronico")]
        public async Task<IActionResult> CargarDocumentoElectronico(string Usuario, string Documento)
        {
            try
            {
                string objetoLogger = "{" + Usuario.ToString() + ":" + Documento.ToString() + "}";
                _logger.LogInformation("Consulta de CargarDocumentoElectronico registrada en el sistema por elemento , {Usuario, Documento}: " + objetoLogger);

                string fechaActual = DateTime.Now.ToString("yyyy/MM/dd");
                var usuario = "{\"UsuarioTXDT\":[{\"documento\":null,\"login\":\"" + Usuario + "\"}]}";
                string documento = @"{""datosConsultarDocumento"": [{""NoDocumento"": """ + Documento + @""",""fechaInicio"": ""2022/01/01"",""fechaFin"": """ + fechaActual + @"""}]}";

                var coleccion = await _IDocumentoServices.CargarDocumentoElectronicoService(usuario, documento);
                if (coleccion != null)
                {
                    return Ok(new ApiResponse("Consulta Exitosa de CargarDocumentoElectronico.", coleccion, 200));
                }
                else
                {
                    return NotFound(new ApiResponse("No existen registros de CargarDocumentoElectronico en el sistema.", null, 404));
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Error en consulta de CargarDocumentoElectronico. Detalle del error: ", ex.Message);
                return NotFound(new ApiResponse("No encontrado.", null, 550));
            }
        }

    }
}