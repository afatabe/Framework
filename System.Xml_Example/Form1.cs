using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace System.Xml_Example
{
    public partial class Form1 : Form
    {
        string arquivo = @"c:\bk\agenda.xml";
        XmlDocument xmlDoc = new XmlDocument();

        public Form1()
        {
            InitializeComponent();


            if (!File.Exists(arquivo))
            {
                XmlNode noderoot = xmlDoc.CreateElement("Contatos");
                xmlDoc.AppendChild(noderoot);
                xmlDoc.Save(arquivo);
            }

            lblNome.Text = "";
            ReadAgenda();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(arquivo);
            XmlNode nodeNome = xmlDoc.CreateElement("nome");
            XmlNode nodeTelefone = xmlDoc.CreateElement("telefone");

            nodeNome.InnerText = txtNome.Text;
            nodeTelefone.InnerText = txtTelefone.Text;

            XmlNode nodeContato = xmlDoc.CreateElement("Contato");

            xmlDoc.SelectSingleNode("/Contatos").PrependChild(nodeContato);
            xmlDoc.SelectSingleNode("/Contatos/Contato").AppendChild(nodeNome);
            xmlDoc.SelectSingleNode("/Contatos/Contato").AppendChild(nodeTelefone);
            xmlDoc.Save(arquivo);

            ReadAgenda();
        }

        private void ReadAgenda() {
            xmlDoc.Load(arquivo);
            listBox1.Items.Clear();

            foreach (XmlNode node in xmlDoc.GetElementsByTagName("Contato")) {
                listBox1.Items.Add("Nome    : " + node.ChildNodes[0].InnerText.ToUpper());
                listBox1.Items.Add("Telefone: " + node.ChildNodes[1].InnerText.ToUpper());


            }

        }

    }

}
