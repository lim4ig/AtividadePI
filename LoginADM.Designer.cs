namespace AtividadePI
{
    partial class LoginADM
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumId = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnLista = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(97, 209);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(224, 180);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(139, 180);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(54, 180);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(92, 127);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(230, 20);
            this.txtSenha.TabIndex = 11;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(41, 130);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(41, 13);
            this.labelPass.TabIndex = 10;
            this.labelPass.Text = "Senha:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(92, 94);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(230, 20);
            this.txtUser.TabIndex = 9;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(41, 97);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(35, 13);
            this.labelUser.TabIndex = 8;
            this.labelUser.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.txtNumId);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.btnLista);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.labelPass);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.labelUser);
            this.groupBox1.Location = new System.Drawing.Point(37, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 238);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // txtNumId
            // 
            this.txtNumId.Location = new System.Drawing.Point(92, 11);
            this.txtNumId.Name = "txtNumId";
            this.txtNumId.Size = new System.Drawing.Size(230, 20);
            this.txtNumId.TabIndex = 22;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(41, 14);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(21, 13);
            this.txtID.TabIndex = 21;
            this.txtID.Text = "ID:";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(44, 154);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(278, 20);
            this.dtpData.TabIndex = 20;
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(178, 209);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 23);
            this.btnLista.TabIndex = 19;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(92, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 20);
            this.txtNome.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nome:";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(92, 63);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(230, 20);
            this.txtArea.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Area:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 55);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cadastro";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(446, 87);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(326, 271);
            this.dgvLista.TabIndex = 18;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            // 
            // LoginADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginADM";
            this.Text = "LoginADM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtNumId;
        private System.Windows.Forms.Label txtID;
    }
}