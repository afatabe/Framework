using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace System.Xml_Example
{
    [Serializable()]
    public class Contato
    {
        [XmlElement("Nome")]
        public string Nome;
        [XmlElement("Telefone")]
        public string Telefone;
    }
}
