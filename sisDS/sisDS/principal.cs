using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sisDS
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        public void cboUFfill(){
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conect;
            conexao.Open();
            string pesquisarUF = string.Concat("SELECT cdUF FROM unidade");
            SqlCommand pesquisarUFSQL = new SqlCommand(pesquisarUF, conexao);

            SqlDataAdapter sdaUF = new SqlDataAdapter(pesquisarUFSQL);
            DataTable dt = new DataTable();

            sdaUF.Fill(dt);

            cboUF.DataSource = dt;
            cboUF.DisplayMember = "cdUF";
            cboUF.ValueMember = "cdUF";
            cboUFrof.DataSource = dt;
            cboUFrof.DisplayMember = "cdUF";
            cboUFrof.ValueMember = "cdUF";

            conexao.Close();
        
        }

        public void cboAreafill() {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conect;
            conexao.Open();
            string pesquisarUF = string.Concat("SELECT area FROM curso");
            SqlCommand pesquisarUFSQL = new SqlCommand(pesquisarUF, conexao);

            SqlDataAdapter sdaUF = new SqlDataAdapter(pesquisarUFSQL);
            DataTable dt = new DataTable();

            sdaUF.Fill(dt);

            cboArea.DataSource = dt;
            cboArea.DisplayMember = "area";
            cboArea.ValueMember = "area";

            conexao.Close();
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            cboUFfill();
            cboAreafill();
        }

        private void cboUF_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conect;
            conexao.Open();
            string pesquisarUF = string.Concat("SELECT * FROM unidade where cdUF = '"+cboUF.SelectedValue+"'");
            SqlCommand pesquisarUFSQL = new SqlCommand(pesquisarUF, conexao);

            SqlDataAdapter sdaUF = new SqlDataAdapter(pesquisarUFSQL);
            DataTable dt = new DataTable();
            
            sdaUF.Fill(dt);

            dgvUnidades.DataSource = null;
            dgvUnidades.DataSource = dt;
            conexao.Close();
        }

        private void cboArea_SelectedValueChanged(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conect;
            conexao.Open();
            string pesquisarUF = string.Concat("SELECT * FROM curso where area = '" + cboArea.SelectedValue + "'");
            SqlCommand pesquisarUFSQL = new SqlCommand(pesquisarUF, conexao);

            SqlDataAdapter sdaUF = new SqlDataAdapter(pesquisarUFSQL);
            DataTable dt = new DataTable();

            sdaUF.Fill(dt);

            dgvCurso.DataSource = null;
            dgvCurso.DataSource = dt;
            conexao.Close();

        }

        private void btnADDcurso_Click(object sender, EventArgs e)
        {
            addCurso add = new addCurso();
            add.Show();
        }

        private void btnAddunidade_Click(object sender, EventArgs e)
        {
            addUnidade addu = new addUnidade();
            addu.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboUFfill();
            cboAreafill();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addProfg prof = new addProfg();
            prof.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conect;
            conexao.Open();
            string pesquisarUF = string.Concat("select * from professor");
            SqlCommand pesquisarUFSQL = new SqlCommand(pesquisarUF, conexao);

            SqlDataAdapter sdaUF = new SqlDataAdapter(pesquisarUFSQL);
            DataTable dt = new DataTable();

            sdaUF.Fill(dt);

            dgvProf.DataSource = null;
            dgvProf.DataSource = dt;
            conexao.Close();
        }

        private void cboUFrof_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conect;
            conexao.Open();
            string pesquisarUF = string.Concat("select * from professor where codigoUf = '"+ cboUFrof.SelectedValue + "'");
            SqlCommand pesquisarUFSQL = new SqlCommand(pesquisarUF, conexao);

            SqlDataAdapter sdaUF = new SqlDataAdapter(pesquisarUFSQL);
            DataTable dt = new DataTable();

            sdaUF.Fill(dt);

            dgvProf.DataSource = null;
            dgvProf.DataSource = dt;
            conexao.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conect;
            conexao.Open();
            string pesquisarUF = string.Concat("select * from professor where nome LIKE '%" + txtNomeProf.Text + "%'");
            SqlCommand pesquisarUFSQL = new SqlCommand(pesquisarUF, conexao);

            SqlDataAdapter sdaUF = new SqlDataAdapter(pesquisarUFSQL);
            DataTable dt = new DataTable();

            sdaUF.Fill(dt);

            dgvProf.DataSource = null;
            dgvProf.DataSource = dt;
            conexao.Close();
        }

        private void dgvUnidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            const string caption = "Excluir unidade";
            string a = dgvUnidades.Rows[e.RowIndex].Cells[0].Value.ToString();
            string un = dgvUnidades.Rows[e.RowIndex].Cells[1].Value.ToString();
            string message = " deseja excluir "+un+"?";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = Program.conect;
                conexao.Open();
                string delete = string.Concat("DELETE FROM unidade where id = "+a+" ");
                SqlCommand deleteSQL = new SqlCommand(delete, conexao);
                deleteSQL.ExecuteNonQuery();
                conexao.Close();
            }
        }
    }
}
