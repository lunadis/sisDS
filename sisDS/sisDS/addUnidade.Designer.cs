namespace sisDS
{
    partial class addUnidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUnidade));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCOuf = new System.Windows.Forms.ComboBox();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(35, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(35, 103);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo UF";
            // 
            // cboCOuf
            // 
            this.cboCOuf.FormattingEnabled = true;
            this.cboCOuf.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "SA"});
            this.cboCOuf.Location = new System.Drawing.Point(35, 142);
            this.cboCOuf.Name = "cboCOuf";
            this.cboCOuf.Size = new System.Drawing.Size(121, 21);
            this.cboCOuf.TabIndex = 5;
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(236, 187);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(100, 20);
            this.txtComp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Comp";
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(35, 236);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(100, 20);
            this.txtFone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone";
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(119, 276);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(75, 23);
            this.BtnIncluir.TabIndex = 10;
            this.BtnIncluir.Text = "Nova Unidade";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(35, 187);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(195, 20);
            this.txtEndereco.TabIndex = 11;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(35, 170);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 12;
            this.lblEndereco.Text = "Endereço";
            // 
            // addUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 334);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCOuf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addUnidade";
            this.Text = "Nova unidade";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCOuf;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
    }
}