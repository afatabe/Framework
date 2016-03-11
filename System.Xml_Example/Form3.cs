using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;

namespace System.Xml_Example
{
    public partial class Form3 : Form
    {
        string arquivo = @"c:\bk\agenda.xml";
        // XmlDocument xmlDoc = new XmlDocument();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            XElement xElement = XElement.Load(arquivo);
            Contatos contatos = Serializer.Deserialize<Contatos>(xElement);
            
            XElement xmlRetorno = Serializer.Serialize<Contatos>(contatos);


        }


    }
}
