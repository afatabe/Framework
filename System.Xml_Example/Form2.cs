using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace System.Xml_Example
{
    public partial class Form2 : Form
    {
        string arquivo = @"c:\bk\agenda2.xml";
        XmlDocument xmlDoc = new XmlDocument();

        public Form2()
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
            listBox1.Items.Clear();
            xmlDoc.Load(arquivo);
            foreach (XmlNode node in xmlDoc.GetElementsByTagName("Contato"))
            {
                listBox1.Items.Add("Nome     : " + node.Attributes["nome"].Value);
                listBox1.Items.Add("Telefone : " + node.Attributes["telefone"].Value);
                listBox1.Items.Add("");
            }
        }

        private void Add(string nome, string telefone)
        {
            XElement xElement = new XElement("Contato");
            xElement.Add(new XAttribute("nome", nome));
            xElement.Add(new XAttribute("telefone", telefone));

            XElement xDoc = XElement.Load(arquivo);
            xDoc.Add(xElement);
            xDoc.Save(arquivo);

            ReadAgenda();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add(txtNome.Text, txtTelefone.Text);

        }
    }
}
