using System.Xml.Serialization;

namespace ANLA.Artemisa.GestionDocumental.Api.Models
{
    public class RadicarDocumento
    {
        [XmlRoot(ElementName = "fileName")]
        public class FileName
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "correo")]
        public class Correo
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "documento")]
        public class Documento
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "cc_documento")]
        public class CcDocumento
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "tipo_emp")]
        public class TipoEmp
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "nombre")]
        public class Nombre
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "prim_apel")]
        public class PrimApel
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "seg_apel")]
        public class SegApel
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "telefono")]
        public class Telefono
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "direccion")]
        public class Direccion
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "mail")]
        public class Mail
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "otro")]
        public class Otro
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "idcont")]
        public class Idcont
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "idpais")]
        public class Idpais
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "codep")]
        public class Codep
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "muni")]
        public class Muni
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "destinatario")]
        public class Destinatario
        {

            [XmlElement(ElementName = "documento")]
            public Documento Documento { get; set; }

            [XmlElement(ElementName = "cc_documento")]
            public CcDocumento CcDocumento { get; set; }

            [XmlElement(ElementName = "tipo_emp")]
            public TipoEmp TipoEmp { get; set; }

            [XmlElement(ElementName = "nombre")]
            public Nombre Nombre { get; set; }

            [XmlElement(ElementName = "prim_apel")]
            public PrimApel PrimApel { get; set; }

            [XmlElement(ElementName = "seg_apel")]
            public SegApel SegApel { get; set; }

            [XmlElement(ElementName = "telefono")]
            public Telefono Telefono { get; set; }

            [XmlElement(ElementName = "direccion")]
            public Direccion Direccion { get; set; }

            [XmlElement(ElementName = "mail")]
            public Mail Mail { get; set; }

            [XmlElement(ElementName = "otro")]
            public Otro Otro { get; set; }

            [XmlElement(ElementName = "idcont")]
            public Idcont Idcont { get; set; }

            [XmlElement(ElementName = "idpais")]
            public Idpais Idpais { get; set; }

            [XmlElement(ElementName = "codep")]
            public Codep Codep { get; set; }

            [XmlElement(ElementName = "muni")]
            public Muni Muni { get; set; }

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "predio")]
        public class Predio
        {

            [XmlElement(ElementName = "documento")]
            public Documento Documento { get; set; }

            [XmlElement(ElementName = "cc_documento")]
            public CcDocumento CcDocumento { get; set; }

            [XmlElement(ElementName = "tipo_emp")]
            public TipoEmp TipoEmp { get; set; }

            [XmlElement(ElementName = "nombre")]
            public Nombre Nombre { get; set; }

            [XmlElement(ElementName = "prim_apel")]
            public PrimApel PrimApel { get; set; }

            [XmlElement(ElementName = "seg_apel")]
            public SegApel SegApel { get; set; }

            [XmlElement(ElementName = "telefono")]
            public Telefono Telefono { get; set; }

            [XmlElement(ElementName = "direccion")]
            public Direccion Direccion { get; set; }

            [XmlElement(ElementName = "mail")]
            public Mail Mail { get; set; }

            [XmlElement(ElementName = "otro")]
            public Otro Otro { get; set; }

            [XmlElement(ElementName = "idcont")]
            public Idcont Idcont { get; set; }

            [XmlElement(ElementName = "idpais")]
            public Idpais Idpais { get; set; }

            [XmlElement(ElementName = "codep")]
            public Codep Codep { get; set; }

            [XmlElement(ElementName = "muni")]
            public Muni Muni { get; set; }

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "esp")]
        public class Esp
        {

            [XmlElement(ElementName = "documento")]
            public Documento Documento { get; set; }

            [XmlElement(ElementName = "cc_documento")]
            public CcDocumento CcDocumento { get; set; }

            [XmlElement(ElementName = "tipo_emp")]
            public TipoEmp TipoEmp { get; set; }

            [XmlElement(ElementName = "nombre")]
            public Nombre Nombre { get; set; }

            [XmlElement(ElementName = "prim_apel")]
            public PrimApel PrimApel { get; set; }

            [XmlElement(ElementName = "seg_apel")]
            public SegApel SegApel { get; set; }

            [XmlElement(ElementName = "telefono")]
            public Telefono Telefono { get; set; }

            [XmlElement(ElementName = "direccion")]
            public Direccion Direccion { get; set; }

            [XmlElement(ElementName = "mail")]
            public Mail Mail { get; set; }

            [XmlElement(ElementName = "otro")]
            public Otro Otro { get; set; }

            [XmlElement(ElementName = "idcont")]
            public Idcont Idcont { get; set; }

            [XmlElement(ElementName = "idpais")]
            public Idpais Idpais { get; set; }

            [XmlElement(ElementName = "codep")]
            public Codep Codep { get; set; }

            [XmlElement(ElementName = "muni")]
            public Muni Muni { get; set; }

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "asu")]
        public class Asu
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "med")]
        public class Med
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "ane")]
        public class Ane
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "coddepe")]
        public class Coddepe
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "tpRadicado")]
        public class TpRadicado
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "cuentai")]
        public class Cuentai
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "radi_usua_actu")]
        public class RadiUsuaActu
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "tip_rem")]
        public class TipRem
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "tdoc")]
        public class Tdoc
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "tip_doc")]
        public class TipDoc
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "carp_codi")]
        public class CarpCodi
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "carp_per")]
        public class CarpPer
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "usuaLogin")]
        public class UsuaLogin
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "radicarDocumento")]
        public class RadicarDocumentoXML
        {

            [XmlElement(ElementName = "fileName")]
            public FileName FileName { get; set; }

            [XmlElement(ElementName = "correo")]
            public Correo Correo { get; set; }

            [XmlElement(ElementName = "destinatario")]
            public Destinatario Destinatario { get; set; }

            [XmlElement(ElementName = "predio")]
            public Predio Predio { get; set; }

            [XmlElement(ElementName = "esp")]
            public Esp Esp { get; set; }

            [XmlElement(ElementName = "asu")]
            public Asu Asu { get; set; }

            [XmlElement(ElementName = "med")]
            public Med Med { get; set; }

            [XmlElement(ElementName = "ane")]
            public Ane Ane { get; set; }

            [XmlElement(ElementName = "coddepe")]
            public Coddepe Coddepe { get; set; }

            [XmlElement(ElementName = "tpRadicado")]
            public TpRadicado TpRadicado { get; set; }

            [XmlElement(ElementName = "cuentai")]
            public Cuentai Cuentai { get; set; }

            [XmlElement(ElementName = "radi_usua_actu")]
            public RadiUsuaActu RadiUsuaActu { get; set; }

            [XmlElement(ElementName = "tip_rem")]
            public TipRem TipRem { get; set; }

            [XmlElement(ElementName = "tdoc")]
            public Tdoc Tdoc { get; set; }

            [XmlElement(ElementName = "tip_doc")]
            public TipDoc TipDoc { get; set; }

            [XmlElement(ElementName = "carp_codi")]
            public CarpCodi CarpCodi { get; set; }

            [XmlElement(ElementName = "carp_per")]
            public CarpPer CarpPer { get; set; }

            [XmlElement(ElementName = "usuaLogin")]
            public UsuaLogin UsuaLogin { get; set; }

            [XmlAttribute(AttributeName = "encodingStyle")]
            public string EncodingStyle { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "Body")]
        public class Body
        {

            [XmlElement(ElementName = "radicarDocumento")]
            public RadicarDocumento RadicarDocumento { get; set; }
        }

        [XmlRoot(ElementName = "Envelope")]
        public class Envelope
        {

            [XmlElement(ElementName = "Header")]
            public object Header { get; set; }

            [XmlElement(ElementName = "Body")]
            public Body Body { get; set; }

            [XmlAttribute(AttributeName = "xsi")]
            public string Xsi { get; set; }

            [XmlAttribute(AttributeName = "xsd")]
            public string Xsd { get; set; }

            [XmlAttribute(AttributeName = "soapenv")]
            public string Soapenv { get; set; }

            [XmlAttribute(AttributeName = "web")]
            public string Web { get; set; }

            [XmlText]
            public string Text { get; set; }
        }


    }
}
