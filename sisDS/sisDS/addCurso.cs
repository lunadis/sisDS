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
    public partial class addCurso : Form
    {
        public addCurso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conect;
            conexao.Open();
            string cadastroSQL = "insert into curso values ('"+txtNmCurso.Text+"','"+cbocursoArea.SelectedItem+"')";
            SqlCommand cadComand = new SqlCommand(cadastroSQL, conexao);
            cadComand.ExecuteNonQuery();
            conexao.Close();
            Principal p = new Principal();
            p.cboAreafill();
            Hide();
        }
    }
}
