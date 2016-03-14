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

        private int Id;
        public Form3()
        {
            InitializeComponent();

        }

        private void BindListbox(List<Contato> lContato)
        {
            listBox1.DataSource = lContato;
            listBox1.DisplayMember = "Nome";
            listBox1.ValueMember = "Id";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            contatos = SContatos.Read();
            this.BindListbox(contatos.Contato);
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                this.BindListbox(SContatos.Read().Contato);
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
            this.btnSelecionar_Click(null, null);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                pnlAlterar.Visible = true;
                pnlIncluir.Visible = false;

                Contato c = contatos.Contato.Find(p => p.Id == (int)listBox1.SelectedValue);
                txtNome.Text = c.Nome;
                if (c.Telefone.Count > 0)
                {

                    txtTelefoneResidencial.Text = c.Telefone[(int)TiposTelefone.Residencial].Numero;
                    txtTelefoneComercial.Text = c.Telefone[(int)TiposTelefone.Comercial].Numero;
                    txtTelefoneCelular.Text = c.Telefone[(int)TiposTelefone.Celular].Numero;
                }

                txtObs.Text = c.Obs;
                Id = c.Id;



            }
        }

        private void btnSAlterar_Click(object sender, EventArgs e)
        {
            Contato c = contatos.Contato.Find(p => p.Id == Id);
            c.Nome = txtNome.Text;

            c.Telefone[(int)TiposTelefone.Residencial].Numero = txtTelefoneResidencial.Text;
            c.Telefone[(int)TiposTelefone.Comercial].Numero = txtTelefoneComercial.Text;
            c.Telefone[(int)TiposTelefone.Celular].Numero = txtTelefoneCelular.Text;

            c.Obs = txtObs.Text;

            SContatos.Write(contatos);
            this.BindListbox(SContatos.Read().Contato);

            this.btnCancelar_Click(null, null);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlAlterar.Visible = false;
            pnlIncluir.Visible = true;
            txtNome.Text = txtObs.Text = txtTelefoneCelular.Text = txtTelefoneComercial.Text = txtTelefoneResidencial.Text = string.Empty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Contato c = new Contato();
            c.Id = this.NextId();
            c.Nome = txtNome.Text;

            c.Telefone = new List<Telefone>();
            c.Telefone.Add(new Telefone((int)TiposTelefone.Residencial, txtTelefoneResidencial.Text));
            c.Telefone.Add(new Telefone((int)TiposTelefone.Comercial, txtTelefoneComercial.Text));
            c.Telefone.Add(new Telefone((int)TiposTelefone.Celular, txtTelefoneCelular.Text));

            c.Obs = txtObs.Text;

            contatos.Contato.Add(c);

            SContatos.Write(contatos);

            this.BindListbox(SContatos.Read().Contato);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.FormClosed += f4_Formclose;

            f4.ShowDialog();
        }

        void f4_Formclose(object sender, FormClosedEventArgs e)
        {
            if (FiltroContatos.Filtro.Count > 0)
            {
                this.BindListbox(FiltroContatos.Filtro);
            }
            else
            {
                MessageBox.Show("Nenhum resultado encontrado");
            }

        }

        private void btnRemoverFiltro_Click(object sender, EventArgs e)
        {
            this.BindListbox(SContatos.Read().Contato);
        }
    }
}