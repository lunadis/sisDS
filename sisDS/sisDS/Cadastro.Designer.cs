namespace sisDS
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.txbNome = new System.Windows.Forms.TextBox();
            this.mTxbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mTxbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mTxbCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtVSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(36, 31);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(186, 20);
            this.txbNome.TabIndex = 0;
            // 
            // mTxbCPF
            // 
            this.mTxbCPF.Location = new System.Drawing.Point(36, 79);
            this.mTxbCPF.Mask = "000-000-000/00";
            this.mTxbCPF.Name = "mTxbCPF";
            this.mTxbCPF.Size = new System.Drawing.Size(100, 20);
            this.mTxbCPF.TabIndex = 1;
            this.mTxbCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nº CPF";
            // 
            // mTxbTelefone
            // 
            this.mTxbTelefone.Location = new System.Drawing.Point(36, 128);
            this.mTxbTelefone.Mask = "(99) 0000-0000";
            this.mTxbTelefone.Name = "mTxbTelefone";
            this.mTxbTelefone.Size = new System.Drawing.Size(100, 20);
            this.mTxbTelefone.TabIndex = 6;
            this.mTxbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mTxbCelular
            // 
            this.mTxbCelular.Location = new System.Drawing.Point(180, 129);
            this.mTxbCelular.Mask = "(99) 00000-0000";
            this.mTxbCelular.Name = "mTxbCelular";
            this.mTxbCelular.Size = new System.Drawing.Size(100, 20);
            this.mTxbCelular.TabIndex = 7;
            this.mTxbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(36, 168);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(170, 20);
            this.txtEndereco.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Senha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Confirmar senha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Celular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Complemento";
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(222, 167);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(58, 20);
            this.txtComp.TabIndex = 16;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(61, 295);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(165, 295);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(42, 217);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 20;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtVSenha
            // 
            this.txtVSenha.Location = new System.Drawing.Point(42, 256);
            this.txtVSenha.Name = "txtVSenha";
            this.txtVSenha.Size = new System.Drawing.Size(100, 20);
            this.txtVSenha.TabIndex = 21;
            this.txtVSenha.UseSystemPasswordChar = true;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 354);
            this.Controls.Add(this.txtVSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.mTxbCelular);
            this.Controls.Add(this.mTxbTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mTxbCPF);
            this.Controls.Add(this.txbNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.MaskedTextBox mTxbCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mTxbTelefone;
        private System.Windows.Forms.MaskedTextBox mTxbCelular;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtVSenha;
    }
}