using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FramePrincipal : Form
    {
        List<Pessoa> list = new List<Pessoa>();

        public FramePrincipal()
        {
            InitializeComponent();
            this.ActiveControl = maskedTextCPF;
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Cpf = maskedTextCPF.Text;
            pessoa.Nome = textNome.Text;
            pessoa.Email = textEmail.Text;
            pessoa.Telefone = maskedTextTelefone.Text;
            list.Add(pessoa);
            limparCampos();
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            string nomePesquisar = textNome.Text;
            bool encontrou = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (nomePesquisar.ToUpper().Equals(list[i].Nome.ToUpper()))
                {
                    MessageBox.Show("Encontrou o CPF: " + list[i].Cpf);
                    encontrou = true;
                }
            }

            if (encontrou == false)
            {
                MessageBox.Show("Não foi encontrado nenhuma pessoa.");
            }
        }

        public void limparCampos()
        {
            foreach (var Control in Controls)
            {
                if (Control is TextBoxBase TextBox)
                    TextBox.ResetText();
            }
        }
    }
}
