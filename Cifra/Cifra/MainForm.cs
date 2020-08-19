using System;
using System.Windows.Forms;

namespace Cifra {
    public partial class MainForm : Form {

        //Váriaveis globais
        //Matriz contendo o alfabeto e a criptografia
        readonly string[,] matrizAlfabeto = {
            {"A", "i"},
            {"B", "#dre"},
            {"C", "{ewqx"},
            {"D", "1T%.,"},
            {"E", "Qa![[]"},
            {"F", "d*sdf"},
            {"G", "[´f''"},
            {"H", "254"},
            {"I", "98$d"},
            {"J", "yeh*3@!"},
            {"K", "qa![[]"},
            {"L", "76ewczz"},
            {"M", "4232ery"},
            {"N", "/"},
            {"O", "."},
            {"P", "c"},
            {"Q", "V&6dswc"},
            {"R", "apRR2@"},
            {"S", "bqwqWW"},
            {"T", "WW6564"},
            {"U", "Cc./"},
            {"V", "S3#--"},
            {"W", "ç*-/f"},
            {"X", "z6sdfg"},
            {"Y", "Aaaa"},
            {"Z", "8ç*-"},
            {"a", "Yeh3l"},
            {"b", "ZYeah"},
            {"c", "ez"},
            {"d", "lol"},
            {"e", "mezl"},
            {"f", "**"},
            {"g", "h¥¥"},
            {"h", "Â%¨6"},
            {"i", "À%¨"},
            {"j", "u=="},
            {"k", "Í1895"},
            {"l", "ãdhf$%&"},
            {"m", "ss"},
            {"n", "P"},
            {"o", "Õ"},
            {"p", "n"},
            {"q", "ff"},
            {"r", "k"},
            {"s", "jjkffn"},
            {"t", "oo"},
            {"u", "wWW"},
            {"v", "v%$#"},
            {"w", "G#$%"},
            {"x", "=@3"},
            {"y", "r"},
            {"z", "ÃwwW"},
            {"Á", "TT"},
            {"á", "E#$%"},
            {"Â", "f"},
            {"â", "g"},
            {"À", "F¨YUI%"},
            {"à", "UU"},
            {"Ã", "áBB"},
            {"ã", "BB"},
            {"É", "Ooo"},
            {"é", "p00"},
            {"Ê", "â3@!â"},
            {"ê", "à"},
            {"Í", "Liur"},
            {"í", "§§"},
            {"Ó", "H"},
            {"ó", "I3@!"},
            {"Ô", "°§§"},
            {"ô", "M"},
            {"Õ", "N"},
            {"õ", "D842^~"},
            {"Ú", "R"},
            {"ú", "X"},
            {"Ç", "J@$#%"},
            {"ç", "K%¨&"},
            {"0", "úÇ"},
            {"1", "ÇÚ"},
            {"2", "00Ç"},
            {"3", "ÓÓÇ3@!"},
            {"4", "ôÇô"},
            {"5", "é"},
            {"6", "Ôfshsdf"},
            {"7", "ÊÊ"},
            {"8", "õ"},
            {"9", "ô"},
            {" ", "3l"},
            {"/", "í"},
            {"\\", "êí"},
            {"=", "5"},
            {"-", "6"},
            {"_", "\\6"},
            {"(", ")"},
            {")", "("},
            {"{", ">"},
            {"}", "&&"},
            {"[", "%"},
            {"]", "_()"},
            {".", "--"},
            {",", ":--É"},
            {"<", "}"},
            {">", "@"},
            {"!", "É::"},
            {"?", "++"},
            {"*", "??"},
            {"&", "!??++"},
            {"%", "<"},
            {"$", ","},
            {"#", "]"},
            {"@", "$$"},
            {"+", ";"},
            {":", "Á"},
            {";", "tÁÁ"},
            {"|", "|3@!"}
        };

        //Construtor
        public MainForm() {
            InitializeComponent();
            this.CenterToScreen();
        }

        //Eventos
        private void buttonCriptografar_Click(object sender, EventArgs e) {
            Criptografar();
        }

        private void buttonDescriptografar_Click(object sender, EventArgs e) {
            Descriptografar();
        }

        private void textBoxInput_KeyUp(object sender, KeyEventArgs e) {
            if (string.IsNullOrEmpty(textBoxInput.Text)) {
                DesativarBotoesCriptografia();
            } else {
                AtivarBotoesCriptografia();
            }
        }

        private void buttonCopiar_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(textBoxOutput.Text)) {
                Clipboard.SetText(textBoxOutput.Text);
            }
        }

        private void buttonLimparCampos_Click(object sender, EventArgs e) {
            DesativarBotoesCriptografia();
            textBoxInput.ResetText();
            textBoxOutput.ResetText();
        }

        //Funções
        public void Criptografar() {
            textBoxOutput.Clear();
            for (int i = 0; i < textBoxInput.Text.Length; i++) {
                for (int j = 0; j < matrizAlfabeto.GetLength(0); j++) {
                    if (textBoxInput.Text[i].ToString().Equals(matrizAlfabeto[j, 0])) {
                        textBoxOutput.AppendText(matrizAlfabeto[j, 1]);
                    }
                }
            }
        }

        public void Descriptografar() {
            textBoxOutput.Clear();

            int tamTotal = textBoxInput.Text.Length; //tamanho total (int) da frase criptografada
            string fraseDesc = ""; //frase que vai ser descriptografada
            int contador = 0; //um contador para auxiliar 
            string aux; //auxiliar de string para comparar
            int colunaAlfabeto = 0; //coluna do alfabeto
            int colunaCaracter = 1; //coluna criptografado
            int tamCaracter; //tamanho do item criptografado
            string fraseCri = textBoxInput.Text; //frase (string) para descriptografar

            while (contador < tamTotal) { //ir até o chegar no tamanho total da frase

                aux = matrizAlfabeto[colunaAlfabeto, colunaCaracter]; //pegar sequência de caracter criptografado da letra

                if (fraseCri[contador] == aux[0]) {
                    tamCaracter = aux.Length;
                    contador += tamCaracter;
                    fraseDesc += matrizAlfabeto[colunaAlfabeto, 0];
                    colunaAlfabeto = 0;
                } else {
                    colunaAlfabeto++;
                }
            }
            textBoxOutput.AppendText(fraseDesc);
        }

        public void AtivarBotoesCriptografia() {
            if (!buttonCriptografar.Enabled) {
                buttonCriptografar.Enabled = true;
            }
            if (!buttonDescriptografar.Enabled) {
                buttonDescriptografar.Enabled = true;
            }
        }

        public void DesativarBotoesCriptografia() {
            if (buttonCriptografar.Enabled) {
                buttonCriptografar.Enabled = false;
            }
            if (buttonDescriptografar.Enabled) {
                buttonDescriptografar.Enabled = false;
            }
        }

    }
}
