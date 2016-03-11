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
        Contatos contatos = null;
        private int next;

        public Form3()
        {
            InitializeComponent();

        }

        private void BindListbox()
        {
            contatos = SContatos.Read();
            listBox1.DataSource = contatos.Contato;
            listBox1.DisplayMember = "Nome";
            listBox1.ValueMember = "Id";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.BindListbox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contato c = new Contato();
            c.Id = this.NextId();
            c.Nome = txtNome.Text;
            c.Telefone = txtTelefone.Text;

            contatos.Contato.Add(c);

            SContatos.Write(contatos);

            this.BindListbox();

        }


        private int NextId()
        {
            int next;
            try
            {
                next = contatos.Contato[contatos.Contato.Count - 1].Id + 1;
            }
            catch
            {
                next = 1;
            }

            return next;

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                Contato c = contatos.Contato.Find(p => p.Id == (int)listBox1.SelectedValue);
                contatos.Contato.Remove(c);

                SContatos.Write(contatos);
                this.BindListbox();
            }
            else
            {
                MessageBox.Show("Nenhum Item Selecionado");               
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
