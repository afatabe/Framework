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
        private int Id;

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

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                pnlAlterar.Visible = true;
                pnlIncluir.Visible = false;               

                Contato c = contatos.Contato.Find(p => p.Id == (int)listBox1.SelectedValue);
                txtNome.Text = c.Nome;
                txtTelefone.Text = c.Telefone;
                Id = c.Id;


                
            }
        }

        private void btnSAlterar_Click(object sender, EventArgs e)
        {
            contatos.Contato.Find(p => p.Id == Id).Nome = txtNome.Text;
            contatos.Contato.Find(p => p.Id == Id).Telefone = txtTelefone.Text;

            SContatos.Write(contatos);
            this.BindListbox();

            this.btnCancelar_Click(null, null);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlAlterar.Visible = false;
            pnlIncluir.Visible = true;
            txtNome.Text = txtTelefone.Text = string.Empty;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}