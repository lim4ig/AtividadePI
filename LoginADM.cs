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
        const string DADOS_CONEXAO = "server=localhost;user=root;password=;database=db_PI";

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtArea.Text))
            {
                MessageBox.Show("Alguns campos não foram preenchidos!!!.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = txtNome.Text;
            string area = txtArea.Text;
            string data = dtpData.Text;

            DateTime dataConvertida = DateTime.Parse(data);

            int controleLinhasAfetadas = 0;

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                conn.Open();
                string scriptInsert = "INSERT INTO tb_dados (nome, area, data) VALUES (@nome, @area, @data)";

                using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                {
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@area", area);
                    comando.Parameters.AddWithValue("@data", dataConvertida);
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string idConsulta = txtNome.Text;

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                conn.Open();
                string scriptConsultaUnica = "SELECT * FROM tb_dados WHERE id = @id";
                using (MySqlCommand comando = new MySqlCommand(scriptConsultaUnica, conn))
                {
                    comando.Parameters.AddWithValue("@id", idConsulta);

                    var dasdosResultado = comando.ExecuteReader();
                    while (dasdosResultado.Read())
                    {
                        //Caso queira mostrar os dados em um ListBox, por exemplo, você pode fazer algo assim:
                        //lbResultado.Items.Add(dasdosResultado["id"].ToString());
                        //lbResultado.Items.Add(dasdosResultado["nome"].ToString());
                        //lbResultado.Items.Add(dasdosResultado["area"].ToString());
                        //lbResultado.Items.Add(dasdosResultado["data"].ToString());
                    }

                }
                conn.Close();
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                conn.Open();


                string scriptConsulta = "SELECT * FROM tb_dados";



                using (MySqlCommand comando = new MySqlCommand(scriptConsulta, conn))
                {
                    MySqlDataAdapter resultadoConsultaMySql = new MySqlDataAdapter(comando);
                    DataTable tabelaDados = new DataTable();
                    resultadoConsultaMySql.Fill(tabelaDados);
                    dgvLista.DataSource = tabelaDados;
                }
                conn.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumId.Text))
            {
                MessageBox.Show("Informe o ID para prosseguir!!!",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string campoId = txtNumId.Text;
            int controleLinhasAfetadas = 0;

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                conn.Open();
                string scriptDelete = "DELETE FROM tb_dados WHERE id = @id";

                using (MySqlCommand comando = new MySqlCommand(scriptDelete, conn))
                {
                    comando.Parameters.AddWithValue("@id", campoId);

                    controleLinhasAfetadas = comando.ExecuteNonQuery();
                }
                conn.Close();
            }
            if (controleLinhasAfetadas > 0)
            {
                MessageBox.Show("Dados deletados com sucesso!");
            }
            else
            {
                MessageBox.Show("Dados não encontrados!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumId.Text) || string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtArea.Text) || string.IsNullOrWhiteSpace(txtNumId.Text))
            {
                MessageBox.Show("Preencha os campos para alterar!!!",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string campoId = txtNumId.Text;
            string nome = txtNome.Text;
            string area = txtArea.Text;
            DateTime data = DateTime.Parse(dtpData.Text);
            int controleLinhasAfetadas = 0;

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                conn.Open();
                string scriptUpdate = "UPDATE tb_dados SET " + 
                    "nome = @nome, area = @area, data = @data WHERE id = @id";

                using (MySqlCommand comando = new MySqlCommand(scriptUpdate, conn))
                {
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@area", area);
                    comando.Parameters.AddWithValue("@data", data);
                    comando.Parameters.AddWithValue("@id", campoId);


                    controleLinhasAfetadas = comando.ExecuteNonQuery();
                }
                conn.Close();
            }

            if (controleLinhasAfetadas > 0)
            {
                MessageBox.Show("Dados atualizados com sucesso!");
            }
            else
            {
                MessageBox.Show("Dados não encontrados!");
            }

        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLista.Rows[e.RowIndex];

                txtNumId.Text = row.Cells["id"].Value.ToString();
                txtNome.Text = row.Cells["nome"].Value.ToString();
                txtArea.Text = row.Cells["area"].Value.ToString();

                dtpData.Value = Convert.ToDateTime(row.Cells["data"].Value);
            }
        }
    }
}

