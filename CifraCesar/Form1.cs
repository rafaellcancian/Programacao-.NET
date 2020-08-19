using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CifraCesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public char cifrar(char caracter)
        {
            int valorChar = caracter;
            if (valorChar == 255)//' '
            {
                return Convert.ToChar(128);//#
            }
            if (valorChar == 88)//X
            {
                return Convert.ToChar(65);
            }
            if (valorChar == 89)//Y
            {
                return Convert.ToChar(66);
            }
            if (valorChar == 90)//Z
            {
                return Convert.ToChar(67);
            }
            valorChar = valorChar + 3;
            return Convert.ToChar(valorChar);            
        }

        public char descifrar(char caracter)
        {
            int valorChar = caracter;
            if (valorChar == 128)
            {
                return Convert.ToChar(255);
            }
            if (valorChar == 65)
            {
                return Convert.ToChar(88);
            }
            if (valorChar == 66)
            {
                return Convert.ToChar(89);
            }
            if (valorChar == 67)
            {
                return Convert.ToChar(90);
            }
            valorChar = valorChar - 3;
            return Convert.ToChar(valorChar);
        }

        /*BOTÃO QUE FARÁ A CIFRA DO TEXTO DE ENTRADA E IRÁ ESCREVER NA SAÍDA*/
        private void button1_Click(object sender, EventArgs e)
        {
            //ABCDEFGHIJ...
            //A -->(3)-->D
            //B -->(3)-->E
            //...
            string texto = textBox1.Text.ToUpper();
            char[] mensagem = texto.ToCharArray();
            string saida = "";
            foreach(char c in mensagem)
            {
                saida = saida + cifrar(c);
            }
            textBox2.Text = saida;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text.ToUpper();
            char[] mensagem = texto.ToCharArray();
            string saida = "";
            foreach (char c in mensagem)
            {
                saida = saida + descifrar(c);
            }
            textBox2.Text = saida;
        }
    }
}
