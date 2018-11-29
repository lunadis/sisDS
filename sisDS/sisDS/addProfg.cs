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
    public partial class addProfg : Form
    {
        public addProfg()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conect;
            conexao.Open();
            string cadastroSQL = "insert into professor " +
            "values('" + txbNome.Text + "','" + mTxbCPF.Text + "'," +
            " '" + mTxbTelefone.Text + "', '" + mTxbCelular.Text + "'," +
            " '" + txtCidade.Text + "', '" + cboUF.SelectedValue + "', '" + txtEndereco.Text + "'," +
            " '" + txtComp.Text + "', '" + cboArea.SelectedValue + "', '" + cboCurso.SelectedValue + "'," +
            " '" + cboUnidade.SelectedValue + "')";
            SqlCommand cadComand = new SqlCommand(cadastroSQL, conexao);
            cadComand.ExecuteNonQuery();
            conexao.Close();
            Hide();
        }

        public void cboUFfill()
        {
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

            conexao.Close();

        }
        public void cboAreafill()
        {
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
        public void cboCursoFill() {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conect;
            conexao.Open();
            string pesquisarUF = string.Concat("SELECT nome FROM curso WHERE area = '" + cboArea.SelectedValue + "'");
            SqlCommand pesquisarUFSQL = new SqlCommand(pesquisarUF, conexao);

            SqlDataAdapter sdaUF = new SqlDataAdapter(pesquisarUFSQL);
            DataTable dt = new DataTable();

            sdaUF.Fill(dt);

            cboCurso.DataSource = dt;
            cboCurso.DisplayMember = "nome";
            cboCurso.ValueMember = "nome";

            conexao.Close();
        }

        public void cboUnidadeFill()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conect;
            conexao.Open();
            string pesquisarUF = string.Concat("SELECT nome FROM unidade WHERE cdUF = '" + cboUF.SelectedValue + "'");
            SqlCommand pesquisarUFSQL = new SqlCommand(pesquisarUF, conexao);

            SqlDataAdapter sdaUF = new SqlDataAdapter(pesquisarUFSQL);
            DataTable dt = new DataTable();

            sdaUF.Fill(dt);

            cboUnidade.DataSource = dt;
            cboUnidade.DisplayMember = "nome";
            cboUnidade.ValueMember = "nome";

            conexao.Close();
        }

        private void addProfg_Load(object sender, EventArgs e)
        {
            cboUFfill();
            cboAreafill();
        }

        private void cboArea_SelectedValueChanged(object sender, EventArgs e)
        {
            cboCursoFill();
        }

        private void cboUF_SelectedValueChanged(object sender, EventArgs e)
        {
            cboUnidadeFill();
        }
    }
}
