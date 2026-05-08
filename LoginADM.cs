using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace AtividadePI
{
    public partial class LoginADM : Form
    {
        public LoginADM()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int controleLinhasAfetadas = 0;

            string dadosConexao = "server=localhost;user=root;password=;database=db_PI";
            using (MySqlConnection conn = new MySqlConnection(dadosConexao))
            {
                conn.Open();
                string scriptInsert = "INSERT INTO tb_dados (nome) VALUES (@nome)";

                using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                {
                    comando.Parameters.AddWithValue("@nome", nome);
                    controleLinhasAfetadas = comando.ExecuteNonQuery();
                }
                conn.Close();
            }
            
            if (controleLinhasAfetadas > 0)
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar.");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }
    }
}
