using ANLA.Artemisa.GestionDocumental.Api.Services;
using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace ANLA.Artemisa.GestionDocumental.Api.Controllers
{
    /// <summary>
    /// ExpedienteController
    /// </summary>
    [Route("api/[controller]")]
    public class ExpedienteController : Controller
    {
        private readonly IExpedienteService _IExpedienteServices;
        private readonly ILogger<ExpedienteController> _logger;

        /// <summary>
        /// Constructor ExpedienteController
        /// </summary>
        /// <param name="expedienteServices"></param>
        /// <param name="logger"></param>
        public ExpedienteController(IExpedienteService expedienteServices,
            ILogger<ExpedienteController> logger)
        {
            _IExpedienteServices = expedienteServices;
            _logger = logger;
        }

        /// <summary>
        /// Permite realizar la consulta de un expediente específico.
        /// </summary>
        /// <remarks>
        /// Metodo que permite realizar la consulta de un expediente específico..
        /// </remarks>
        /// <param name="Usuario">Usuario con acceso a consultar.</param>
        /// <param name="Expediente">Número de radicado a consultar.</param>
        /// <returns> Permite realizar la Consulta de un expediente específico.</returns>
        /// <response code="200">La consulta del expediente se realizó con éxito y se devolvió la información del expediente.</response>
        /// <response code="404">No se pudo realiza la consulta del expediente especificado.</response>
        /// <response code="550">Se presento un error al ejecutar el Metodo ConsultarExpediente.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [HttpGet("ConsultarExpediente")]
        public async Task<IActionResult> ConsultarExpediente(string Usuario, string Expediente)
        {
            try
            {
                string objetoLogger = "{" + Usuario.ToString() + ":" + Expediente.ToString() + "}";
                _logger.LogInformation("Consulta de ConsultarExpediente registrada en el sistema por elemento , {Usuario, Expediente}: " + objetoLogger);

                // Construir el objeto JSON con los parámetros solictados por el WSDL
                string fechaActual = DateTime.Now.ToString("yyyy/MM/dd");
                var usuario = "{\"UsuarioTXDT\":[{\"documento\":null,\"login\":\"" + Usuario + "\"}]}";
                string expediente = @"{""datosConsultarExpediente"": [{""NoExpediente"": """ + Expediente + @""",""fechaInicio"": ""2022/01/01"",""fechaFin"": """ + fechaActual + @"""}]}";


                var coleccion = await _IExpedienteServices.ConsultarExpedienteService(usuario, expediente);
                if (coleccion != null)
                {
                    return Ok(new ApiResponse("Consulta Exitosa de ConsultarExpediente.", coleccion, 200));
                }
                else
                {
                    return NotFound(new ApiResponse("No existen registros de ConsultarExpediente en el sistema.", null, 404));
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Error en consulta de ConsultarExpediente. Detalle del error: ", ex.Message);
                return NotFound(new ApiResponse("No encontrado.", null, 550));
            }

        }


    }
}