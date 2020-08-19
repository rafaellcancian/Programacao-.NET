namespace Cifra
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonCriptografar = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonDescriptografar = new System.Windows.Forms.Button();
            this.buttonCopiar = new System.Windows.Forms.Button();
            this.buttonLimparCampos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(12, 9);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(776, 31);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "INPUT";
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(12, 43);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(776, 38);
            this.textBoxInput.TabIndex = 2;
            this.textBoxInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyUp);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(12, 196);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(776, 38);
            this.textBoxOutput.TabIndex = 3;
            // 
            // buttonCriptografar
            // 
            this.buttonCriptografar.Enabled = false;
            this.buttonCriptografar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriptografar.Location = new System.Drawing.Point(12, 87);
            this.buttonCriptografar.Name = "buttonCriptografar";
            this.buttonCriptografar.Size = new System.Drawing.Size(380, 52);
            this.buttonCriptografar.TabIndex = 4;
            this.buttonCriptografar.Text = "CRIPTOGRAFAR";
            this.buttonCriptografar.UseVisualStyleBackColor = true;
            this.buttonCriptografar.Click += new System.EventHandler(this.buttonCriptografar_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(12, 162);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(776, 31);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "OUTPUT";
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDescriptografar
            // 
            this.buttonDescriptografar.Enabled = false;
            this.buttonDescriptografar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDescriptografar.Location = new System.Drawing.Point(408, 87);
            this.buttonDescriptografar.Name = "buttonDescriptografar";
            this.buttonDescriptografar.Size = new System.Drawing.Size(380, 52);
            this.buttonDescriptografar.TabIndex = 7;
            this.buttonDescriptografar.Text = "DESCRIPTOGRAFAR";
            this.buttonDescriptografar.UseVisualStyleBackColor = true;
            this.buttonDescriptografar.Click += new System.EventHandler(this.buttonDescriptografar_Click);
            // 
            // buttonCopiar
            // 
            this.buttonCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopiar.Location = new System.Drawing.Point(12, 240);
            this.buttonCopiar.Name = "buttonCopiar";
            this.buttonCopiar.Size = new System.Drawing.Size(776, 52);
            this.buttonCopiar.TabIndex = 8;
            this.buttonCopiar.Text = "COPIAR PARA A ÁREA DE TRANSFERÊNCIA";
            this.buttonCopiar.UseVisualStyleBackColor = true;
            this.buttonCopiar.Click += new System.EventHandler(this.buttonCopiar_Click);
            // 
            // buttonLimparCampos
            // 
            this.buttonLimparCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimparCampos.Location = new System.Drawing.Point(12, 298);
            this.buttonLimparCampos.Name = "buttonLimparCampos";
            this.buttonLimparCampos.Size = new System.Drawing.Size(776, 52);
            this.buttonLimparCampos.TabIndex = 9;
            this.buttonLimparCampos.Text = "LIMPAR CAMPOS";
            this.buttonLimparCampos.UseVisualStyleBackColor = true;
            this.buttonLimparCampos.Click += new System.EventHandler(this.buttonLimparCampos_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.buttonLimparCampos);
            this.Controls.Add(this.buttonCopiar);
            this.Controls.Add(this.buttonDescriptografar);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonCriptografar);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Criptografar/Descriptografar Cifra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonCriptografar;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonDescriptografar;
        private System.Windows.Forms.Button buttonCopiar;
        private System.Windows.Forms.Button buttonLimparCampos;
    }
}

