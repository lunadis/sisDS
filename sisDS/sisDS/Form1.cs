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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Cadastro cada = new Cadastro();
            cada.Show();
        }
        public Boolean verificarSenha(string senha, string cpf)
        {
            try
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = Program.conect;
                conexao.Open();
                string verUsuario = string.Concat("select * from funcionario where cpf = '" + cpf + "' and senha = '" + senha + "'");
                SqlCommand verUsuarioSQL = new SqlCommand(verUsuario, conexao);
                SqlDataAdapter sdaUsuario = new SqlDataAdapter(verUsuarioSQL);
                DataTable dt = new DataTable();
                sdaUsuario.Fill(dt);
                conexao.Close();

                if (dt.Rows.Count != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch(Exception e)
            {
                MessageBox.Show("erro foi" + e);
                return false;
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (verificarSenha(txtCPF.Text, txtSenha.Text))
            {
                Principal p = new Principal();
                p.Show();
                Hide();
            }
            else {
                MessageBox.Show("Usuario ou senha incorreto");
            }
        }
    }
}
