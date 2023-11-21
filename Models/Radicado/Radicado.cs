namespace ANLA.Artemisa.GestionDocumental.Api.Models
{
    /// <summary>
    /// Radicado
    /// </summary>
    public class Radicado
    {
        public bool ExistenRegistros { get; set; }
        public string Mensaje { get; set; }

        /// <summary>
        /// RespuestaEstado
        /// </summary>
        public class RespuestaEstado
        {
            public bool Estado { get; set; }
            public string Mensaje { get; set; }
            public int? NoPaginasResultado { get; set; }
            public int? NoRegistrosPagina { get; set; }
        }

        /// <summary>
        /// RespuestaServicio
        /// </summary>
        public class RespuestaServicio
        {
            public RespuestaEstado[] RespuestaEstado { get; set; }
            public object[] DatosGenerales { get; set; }
        }
    }
}