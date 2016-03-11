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
        XmlDocument xmlDoc = new XmlDocument();
        XElement xDoc;
        Contatos contatos;

        // XmlDocument xmlDoc = new XmlDocument();

        public Form3()
        {
            InitializeComponent();

            if (!File.Exists(arquivo))
            {
                XmlNode noderoot = xmlDoc.CreateElement("Contatos");
                xmlDoc.AppendChild(noderoot);
                xmlDoc.Save(arquivo);
            }

            ReadAgenda();
        }

        private void ReadAgenda()
        {
            xDoc = XElement.Load(arquivo);
            contatos = Serializer.Deserialize<Contatos>(xDoc);
            listBox1.Items.Clear();

            foreach (Contato c in contatos.Contato) {
                listBox1.Items.Add("Nome     : " + c.Nome);
                listBox1.Items.Add("Telefone : " + c.Telefone);
                listBox1.Items.Add("");
            }
            //XElement result = Serializer.Serialize<Contatos>(contatos);

        }
        
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contato c = new Contato();
            c.Nome = txtNome.Text;
            c.Telefone = txtTelefone.Text;

            contatos.Contato.Add(c);

            XElement xmlReturn = Serializer.Serialize<Contatos>(contatos);

            xmlReturn.Save(arquivo);

            ReadAgenda();

        }
    }
}
