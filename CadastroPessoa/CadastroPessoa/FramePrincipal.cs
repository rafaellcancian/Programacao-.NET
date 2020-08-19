using System;
using System;
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

namespace CadastroPessoa
{
    public partial class FramePrincipal : Form
    {

        public FramePrincipal()
        {
            InitializeComponent();
            this.ActiveControl = maskedTextCPF;
            this.MaximizeBox = false;
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            StreamWriter sWriter;

            if(checarCampos() == false)
            {
                sWriter = File.CreateText(maskedTextCPF.Text + ".txt");

                sWriter.WriteLine(maskedTextCPF.Text);
                sWriter.WriteLine(textNome.Text);
                sWriter.WriteLine(textEmail.Text);
                sWriter.WriteLine(maskedTextTelefone.Text);
                sWriter.Close();
                limparCampos();
            }
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"" + maskedTextCPF.Text + ".txt"))
            {
                textNome.Text = File.ReadLines(maskedTextCPF.Text + ".txt").ElementAt(1);
                textEmail.Text = File.ReadLines(maskedTextCPF.Text + ".txt").ElementAt(2);
                maskedTextTelefone.Text = File.ReadLines(maskedTextCPF.Text + ".txt").ElementAt(3);
            } else
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

        public bool checarCampos()
        {
            if ((File.Exists(@"" + maskedTextCPF.Text + ".txt")))
            {
                MessageBox.Show("Já existe uma pessoa cadastrada com esse CPF.");
                return true;
            }
            else if ((string.IsNullOrWhiteSpace(textNome.Text))) {
                MessageBox.Show("Preencha todos os campos corretamente.");
                return true;
            }
            return false;
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            StreamWriter sWriter;

            if (File.Exists(@"" + maskedTextCPF.Text + ".txt"))
            {

                sWriter = File.CreateText(maskedTextCPF.Text + ".txt");

                sWriter.WriteLine(maskedTextCPF.Text);
                sWriter.WriteLine(textNome.Text);
                sWriter.WriteLine(textEmail.Text);
                sWriter.WriteLine(maskedTextTelefone.Text);
                sWriter.Close();
                limparCampos();
            } else
            {
                MessageBox.Show("Não foi encontrado nenhuma pessoa.");
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"" + maskedTextCPF.Text + ".txt"))
            {
                File.Delete(@"" + maskedTextCPF.Text + ".txt");
                limparCampos();
            } else
            {
                MessageBox.Show("Não foi encontrado nenhuma pessoa.");
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
