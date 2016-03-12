using System.Collections.Generic;
using System.Xml.Serialization;

namespace System.Xml_Example
{
    [Serializable()]
    public class Contato
    {
        [XmlElement("Id")]
        public int Id { get; set; }
        [XmlElement("Nome")]
        public string Nome { get; set; }
        [XmlElement("Telefone")]
        public List<Telefone> Telefone { get; set; }
        [XmlElement("Obs")]
        public string Obs { get; set; }
    }
}
