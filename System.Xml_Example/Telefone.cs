using System.Xml.Serialization;

namespace System.Xml_Example
{
    [Serializable()]
    public class Telefone
    {
        public Telefone() { }
        public Telefone(int tipo, string numero) {
            Tipo = tipo;
            Numero = numero;
                
        }
        [XmlElement("Tipo")]
        public int Tipo { get; set; }
        [XmlElement("Numero")]
        public string Numero { get; set; }

    }

}
