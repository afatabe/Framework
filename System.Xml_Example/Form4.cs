using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Xml_Example
{
    public partial class Form4 : Form
    {
        Contatos contatos = null;
        List<Contato> resultado = null;
        public Form4()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            contatos = SContatos.Read();
            if (cmbCampo.Text == "Nome")
            {
                resultado = contatos.Contato.Where(p => p.Nome.Contains(txtBusca.Text)).ToList<Contato>();
            }
            else
                if (cmbCampo.Text == "Telefone")
            {

            }
            FiltroContatos.Filtro = resultado;
            this.Close();
        }
    }
}
