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

            XElement xDoc = XElement.Load(arquivo);
            Contatos contatos = Serializer.Deserialize<Contatos>(xDoc);

            XElement result = Serializer.Serialize<Contatos>(contatos);
        }

        private void Add(string nome, string telefone)
        {
            XElement xElement = new XElement("Contato");
            xElement.Add(new XAttribute("Nome", nome));
            xElement.Add(new XAttribute("Telefone", telefone));

            XElement xDoc = XElement.Load(arquivo);
            xDoc.Add(xElement);
            xDoc.Save(arquivo);

            ReadAgenda();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add(txtNome.Text, txtTelefone.Text);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
