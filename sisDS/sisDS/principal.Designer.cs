namespace sisDS
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbUnidades = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddunidade = new System.Windows.Forms.Button();
            this.lblcdUF = new System.Windows.Forms.Label();
            this.dgvUnidades = new System.Windows.Forms.DataGridView();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.tbCursos = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnADDcurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.tbProfessores = new System.Windows.Forms.TabPage();
            this.dgvProf = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeProf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboUFrof = new System.Windows.Forms.ComboBox();
            this.tbAlunos = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tbUnidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).BeginInit();
            this.tbCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.tbProfessores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProf)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbUnidades);
            this.tabControl1.Controls.Add(this.tbCursos);
            this.tabControl1.Controls.Add(this.tbProfessores);
            this.tabControl1.Controls.Add(this.tbAlunos);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 413);
            this.tabControl1.TabIndex = 0;
            // 
            // tbUnidades
            // 
            this.tbUnidades.Controls.Add(this.btnRefresh);
            this.tbUnidades.Controls.Add(this.btnAddunidade);
            this.tbUnidades.Controls.Add(this.lblcdUF);
            this.tbUnidades.Controls.Add(this.dgvUnidades);
            this.tbUnidades.Controls.Add(this.cboUF);
            this.tbUnidades.Location = new System.Drawing.Point(4, 22);
            this.tbUnidades.Name = "tbUnidades";
            this.tbUnidades.Padding = new System.Windows.Forms.Padding(3);
            this.tbUnidades.Size = new System.Drawing.Size(585, 387);
            this.tbUnidades.TabIndex = 0;
            this.tbUnidades.Text = "Unidades";
            this.tbUnidades.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(191, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(38, 34);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddunidade
            // 
            this.btnAddunidade.Location = new System.Drawing.Point(322, 24);
            this.btnAddunidade.Name = "btnAddunidade";
            this.btnAddunidade.Size = new System.Drawing.Size(75, 23);
            this.btnAddunidade.TabIndex = 3;
            this.btnAddunidade.Text = "Add unidade";
            this.btnAddunidade.UseVisualStyleBackColor = true;
            this.btnAddunidade.Click += new System.EventHandler(this.btnAddunidade_Click);
            // 
            // lblcdUF
            // 
            this.lblcdUF.AutoSize = true;
            this.lblcdUF.Location = new System.Drawing.Point(20, 10);
            this.lblcdUF.Name = "lblcdUF";
            this.lblcdUF.Size = new System.Drawing.Size(57, 13);
            this.lblcdUF.TabIndex = 2;
            this.lblcdUF.Text = "Codigo UF";
            // 
            // dgvUnidades
            // 
            this.dgvUnidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidades.Location = new System.Drawing.Point(23, 71);
            this.dgvUnidades.Name = "dgvUnidades";
            this.dgvUnidades.Size = new System.Drawing.Size(526, 269);
            this.dgvUnidades.TabIndex = 1;
            this.dgvUnidades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidades_CellDoubleClick);
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(23, 26);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(151, 21);
            this.cboUF.TabIndex = 0;
            this.cboUF.SelectedValueChanged += new System.EventHandler(this.cboUF_SelectedValueChanged);
            // 
            // tbCursos
            // 
            this.tbCursos.Controls.Add(this.button1);
            this.tbCursos.Controls.Add(this.btnADDcurso);
            this.tbCursos.Controls.Add(this.label1);
            this.tbCursos.Controls.Add(this.dgvCurso);
            this.tbCursos.Controls.Add(this.cboArea);
            this.tbCursos.Location = new System.Drawing.Point(4, 22);
            this.tbCursos.Name = "tbCursos";
            this.tbCursos.Padding = new System.Windows.Forms.Padding(3);
            this.tbCursos.Size = new System.Drawing.Size(585, 387);
            this.tbCursos.TabIndex = 1;
            this.tbCursos.Text = "Cursos";
            this.tbCursos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(296, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 34);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnADDcurso
            // 
            this.btnADDcurso.Location = new System.Drawing.Point(201, 26);
            this.btnADDcurso.Name = "btnADDcurso";
            this.btnADDcurso.Size = new System.Drawing.Size(75, 23);
            this.btnADDcurso.TabIndex = 5;
            this.btnADDcurso.Text = "add Curso";
            this.btnADDcurso.UseVisualStyleBackColor = true;
            this.btnADDcurso.Click += new System.EventHandler(this.btnADDcurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Area do curso";
            // 
            // dgvCurso
            // 
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Location = new System.Drawing.Point(16, 73);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.Size = new System.Drawing.Size(526, 269);
            this.dgvCurso.TabIndex = 3;
            // 
            // cboArea
            // 
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(16, 28);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(148, 21);
            this.cboArea.TabIndex = 2;
            this.cboArea.SelectedValueChanged += new System.EventHandler(this.cboArea_SelectedValueChanged);
            // 
            // tbProfessores
            // 
            this.tbProfessores.Controls.Add(this.dgvProf);
            this.tbProfessores.Controls.Add(this.button4);
            this.tbProfessores.Controls.Add(this.button3);
            this.tbProfessores.Controls.Add(this.button2);
            this.tbProfessores.Controls.Add(this.label3);
            this.tbProfessores.Controls.Add(this.txtNomeProf);
            this.tbProfessores.Controls.Add(this.label2);
            this.tbProfessores.Controls.Add(this.cboUFrof);
            this.tbProfessores.Location = new System.Drawing.Point(4, 22);
            this.tbProfessores.Name = "tbProfessores";
            this.tbProfessores.Size = new System.Drawing.Size(585, 387);
            this.tbProfessores.TabIndex = 3;
            this.tbProfessores.Text = "Professores";
            this.tbProfessores.UseVisualStyleBackColor = true;
            // 
            // dgvProf
            // 
            this.dgvProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProf.Location = new System.Drawing.Point(24, 124);
            this.dgvProf.Name = "dgvProf";
            this.dgvProf.Size = new System.Drawing.Size(515, 230);
            this.dgvProf.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(191, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 34);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "add Prof";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeProf
            // 
            this.txtNomeProf.Location = new System.Drawing.Point(24, 75);
            this.txtNomeProf.Name = "txtNomeProf";
            this.txtNomeProf.Size = new System.Drawing.Size(151, 20);
            this.txtNomeProf.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo UF";
            // 
            // cboUFrof
            // 
            this.cboUFrof.FormattingEnabled = true;
            this.cboUFrof.Location = new System.Drawing.Point(24, 32);
            this.cboUFrof.Name = "cboUFrof";
            this.cboUFrof.Size = new System.Drawing.Size(151, 21);
            this.cboUFrof.TabIndex = 3;
            this.cboUFrof.SelectedValueChanged += new System.EventHandler(this.cboUFrof_SelectedValueChanged);
            // 
            // tbAlunos
            // 
            this.tbAlunos.Location = new System.Drawing.Point(4, 22);
            this.tbAlunos.Name = "tbAlunos";
            this.tbAlunos.Size = new System.Drawing.Size(585, 387);
            this.tbAlunos.TabIndex = 2;
            this.tbAlunos.Text = "Alunos";
            this.tbAlunos.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 415);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbUnidades.ResumeLayout(false);
            this.tbUnidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).EndInit();
            this.tbCursos.ResumeLayout(false);
            this.tbCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.tbProfessores.ResumeLayout(false);
            this.tbProfessores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbUnidades;
        private System.Windows.Forms.TabPage tbCursos;
        private System.Windows.Forms.TabPage tbProfessores;
        private System.Windows.Forms.TabPage tbAlunos;
        private System.Windows.Forms.DataGridView dgvUnidades;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.DataGridView dgvCurso;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label lblcdUF;
        private System.Windows.Forms.Button btnADDcurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddunidade;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProf;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeProf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboUFrof;
    }
}