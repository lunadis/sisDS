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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        public void limparCampos() { 
            txbNome.Text ="";
            mTxbCelular.Text = "";
            mTxbCPF.Text = "";
            mTxbTelefone.Text = "";
            txtComp.Text = "";
            txtEndereco.Text = "";
            txtSenha.Text = "";
            txtVSenha.Text = "";

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtSenha.Text.Equals(txtVSenha.Text)){
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conect;
            conexao.Open();
            string cadastroSQL = "insert into funcionario values('"+txbNome.Text+"','"+mTxbCPF.Text+"','"+mTxbTelefone.Text+"','"+mTxbCelular.Text+"','"+txtEndereco.Text+"','"+txtComp.Text+"','"+txtSenha.Text+"')";
            SqlCommand cadComand = new SqlCommand(cadastroSQL, conexao);
            cadComand.ExecuteNonQuery();
            conexao.Close();
            limparCampos();
            MessageBox.Show("Cadastro Efetuado");
            Hide();
            }else{
                MessageBox.Show("As senhas não são iguais");
            };
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
