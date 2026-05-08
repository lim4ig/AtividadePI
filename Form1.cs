using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadePI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var user = textBoxUser.Text.Trim();
            var pass = textBoxPass.Text;
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Preencha usuário e senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Exemplo simples: aceitar usuário "admin" e senha "1234"
            if (user == "admin" && pass == "1234")
            {
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxUser.Text = string.Empty;
            textBoxPass.Text = string.Empty;
            textBoxUser.Focus();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade de registro não implementada.", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digite seu usuário e senha e clique em Login.\nUsuário de teste: admin / 1234", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
