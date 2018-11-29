namespace sisDS
{
    partial class addCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCurso));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNmCurso = new System.Windows.Forms.TextBox();
            this.cbocursoArea = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area";
            // 
            // txtNmCurso
            // 
            this.txtNmCurso.Location = new System.Drawing.Point(12, 56);
            this.txtNmCurso.Name = "txtNmCurso";
            this.txtNmCurso.Size = new System.Drawing.Size(143, 20);
            this.txtNmCurso.TabIndex = 2;
            // 
            // cbocursoArea
            // 
            this.cbocursoArea.FormattingEnabled = true;
            this.cbocursoArea.Items.AddRange(new object[] {
            "Administrativa",
            "Tecnologia",
            "Social",
            "Biologica",
            "Quimica"});
            this.cbocursoArea.Location = new System.Drawing.Point(12, 102);
            this.cbocursoArea.Name = "cbocursoArea";
            this.cbocursoArea.Size = new System.Drawing.Size(161, 21);
            this.cbocursoArea.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 77);
            this.button1.TabIndex = 4;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 180);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbocursoArea);
            this.Controls.Add(this.txtNmCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addCurso";
            this.Text = "Novo cuso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNmCurso;
        private System.Windows.Forms.ComboBox cbocursoArea;
        private System.Windows.Forms.Button button1;
    }
}