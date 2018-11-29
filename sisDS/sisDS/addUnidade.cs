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
    public partial class addUnidade : Form
    {
        public addUnidade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conect;
            conexao.Open();
            string cadastroSQL = "insert into unidade values('"+txtNome.Text+"','"+txtCidade.Text+"','"+cboCOuf.SelectedItem+"','"+txtEndereco.Text+ "','"+txtComp.Text+"','"+txtFone.Text+"')";
            SqlCommand cadComand = new SqlCommand(cadastroSQL, conexao);
            cadComand.ExecuteNonQuery();
            conexao.Close();
            Principal p = new Principal();
            p.cboAreafill();
            Hide();
        }
    }
}
