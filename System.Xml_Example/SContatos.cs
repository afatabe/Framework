using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace System.Xml_Example
{
    public class SContatos
    {

        static string arquivo = @"c:\bk\agenda.xml";
        static XmlDocument xmlDoc = new XmlDocument();
        static XElement xDoc;
        static Contatos contatos;

        public SContatos()
        {
            if (!File.Exists(arquivo))
            {
                XmlNode noderoot = xmlDoc.CreateElement("Contatos");
                xmlDoc.AppendChild(noderoot);
                xmlDoc.Save(arquivo);
            }
        }

        public static Contatos Read()
        {
            xDoc = XElement.Load(arquivo);
            contatos = Serializer.Deserialize<Contatos>(xDoc);
            return contatos;
        }

        public static void Write(Contatos contatos)
        {
            XElement xmlReturn = Serializer.Serialize<Contatos>(contatos);
            xmlReturn.Save(arquivo);
        }

    }

}
