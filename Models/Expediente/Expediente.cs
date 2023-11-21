namespace ANLA.Artemisa.GestionDocumental.Api.Models
{
    public class Expediente
    {
        public List<DatosGeneralesExpediente> DatosGeneralesExpediente { get; set; }
        public List<RespuestaEstado> RespuestaEstado { get; set; }
        public List<RadicadosIncluidos> RadicadosIncluidos { get; set; }
    }
}
