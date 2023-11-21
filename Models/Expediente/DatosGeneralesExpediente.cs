namespace ANLA.Artemisa.GestionDocumental.Api.Models
{
    public class DatosGeneralesExpediente
    {
        public string NoExpediente { get; set; }
        public string Nombre { get; set; }
        public object CodigoSector { get; set; }
        public object NombreSector { get; set; }
        public DateTime FechaInicio { get; set; }
        public object Responsable { get; set; }
        public object CodDependencia { get; set; }
        public object NombreDependencia { get; set; }
        public int CodSerie { get; set; }
        public string NombreSerie { get; set; }
        public int CodSubSerie { get; set; }
        public string NombreSubSerie { get; set; }
        public string NoSila { get; set; }
        public int RowNum { get; set; }
        public int TotalRows { get; set; }
    }
}
