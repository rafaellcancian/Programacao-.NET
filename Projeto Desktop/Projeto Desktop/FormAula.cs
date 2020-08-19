using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Desktop
{
    public partial class FormAula : Form
    {
        LinkedList<Pessoa> agenda = new LinkedList<Pessoa>();

        public FormAula()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = textBoxNome.Text;
            pessoa.Telefone = textBoxTelefone.Text;

            agenda.AddLast(pessoa);
            MessageBox.Show("Nome: " + pessoa.Nome + "\nTelefone: " + pessoa.Telefone);
            textBoxNome.Clear();
            textBoxTelefone.Clear();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            String dados = "";
            foreach(Pessoa individuo in agenda)
            {
                dados = dados + individuo.Nome + " - " + individuo.Telefone + Environment.NewLine;
            }
            MessageBox.Show(dados);
        }
    }
}
