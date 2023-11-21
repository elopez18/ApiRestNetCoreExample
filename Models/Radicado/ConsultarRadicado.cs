using System.Xml.Serialization;

namespace ANLA.Artemisa.GestionDocumental.Api.Models
{
    /// <summary>
    /// ConsultarRadicado
    /// </summary>
    public class ConsultarRadicado
    {
        [XmlRoot(ElementName = "consultarRadicado")]
        public class ConsultarRadicadoXML
        {

            [XmlElement(ElementName = "usuarioConsulta")]
            public object UsuarioConsulta { get; set; }

            [XmlElement(ElementName = "datosConsulta")]
            public object DatosConsulta { get; set; }
        }

        [XmlRoot(ElementName = "Body")]
        public class Body
        {

            [XmlElement(ElementName = "consultarRadicado")]
            public ConsultarRadicado ConsultarRadicado { get; set; }
        }

        [XmlRoot(ElementName = "Envelope")]
        public class Envelope
        {

            [XmlElement(ElementName = "Header")]
            public object Header { get; set; }

            [XmlElement(ElementName = "Body")]
            public Body Body { get; set; }

            [XmlAttribute(AttributeName = "soapenv")]
            public string Soapenv { get; set; }

            [XmlAttribute(AttributeName = "tem")]
            public string Tem { get; set; }
        }


    }
}
