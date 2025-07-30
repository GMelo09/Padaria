namespace Padarosa
{
    partial class FrmGestaoUsuarios
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
            this.DgvUsuario = new System.Windows.Forms.DataGridView();
            this.GrbCadastro = new System.Windows.Forms.GroupBox();
            this.txbCadastroNome = new System.Windows.Forms.TextBox();
            this.txbCadastroEmail = new System.Windows.Forms.TextBox();
            this.txbCadastroSenha = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbEdicao = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblEditarNovaSenha = new System.Windows.Forms.Label();
            this.lblEditarEmail = new System.Windows.Forms.Label();
            this.lblEditarNome = new System.Windows.Forms.Label();
            this.TxbEditarSenha = new System.Windows.Forms.TextBox();
            this.TxbEditarEmail = new System.Windows.Forms.TextBox();
            this.txbEditarNome = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GrbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuario)).BeginInit();
            this.GrbCadastro.SuspendLayout();
            this.grbEdicao.SuspendLayout();
            this.GrbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvUsuario
            // 
            this.DgvUsuario.AllowUserToAddRows = false;
            this.DgvUsuario.AllowUserToDeleteRows = false;
            this.DgvUsuario.AllowUserToResizeColumns = false;
            this.DgvUsuario.AllowUserToResizeRows = false;
            this.DgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuario.Location = new System.Drawing.Point(12, 12);
            this.DgvUsuario.Name = "DgvUsuario";
            this.DgvUsuario.ReadOnly = true;
            this.DgvUsuario.Size = new System.Drawing.Size(724, 230);
            this.DgvUsuario.TabIndex = 0;
            this.DgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuario_CellClick);
            // 
            // GrbCadastro
            // 
            this.GrbCadastro.Controls.Add(this.btnCadastrar);
            this.GrbCadastro.Controls.Add(this.lblSenha);
            this.GrbCadastro.Controls.Add(this.lblEmail);
            this.GrbCadastro.Controls.Add(this.lblNome);
            this.GrbCadastro.Controls.Add(this.txbCadastroSenha);
            this.GrbCadastro.Controls.Add(this.txbCadastroEmail);
            this.GrbCadastro.Controls.Add(this.txbCadastroNome);
            this.GrbCadastro.Location = new System.Drawing.Point(41, 248);
            this.GrbCadastro.Name = "GrbCadastro";
            this.GrbCadastro.Size = new System.Drawing.Size(261, 236);
            this.GrbCadastro.TabIndex = 1;
            this.GrbCadastro.TabStop = false;
            this.GrbCadastro.Text = "Cadstro";
            // 
            // txbCadastroNome
            // 
            this.txbCadastroNome.Location = new System.Drawing.Point(106, 63);
            this.txbCadastroNome.Name = "txbCadastroNome";
            this.txbCadastroNome.Size = new System.Drawing.Size(132, 20);
            this.txbCadastroNome.TabIndex = 0;
            // 
            // txbCadastroEmail
            // 
            this.txbCadastroEmail.Location = new System.Drawing.Point(106, 104);
            this.txbCadastroEmail.Name = "txbCadastroEmail";
            this.txbCadastroEmail.Size = new System.Drawing.Size(132, 20);
            this.txbCadastroEmail.TabIndex = 1;
            // 
            // txbCadastroSenha
            // 
            this.txbCadastroSenha.Location = new System.Drawing.Point(106, 149);
            this.txbCadastroSenha.Name = "txbCadastroSenha";
            this.txbCadastroSenha.PasswordChar = '•';
            this.txbCadastroSenha.Size = new System.Drawing.Size(132, 20);
            this.txbCadastroSenha.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(0, 64);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(100, 15);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome Completo:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(45, 107);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(45, 152);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(53, 17);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(6, 179);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(232, 36);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grbEdicao
            // 
            this.grbEdicao.Controls.Add(this.btnEditar);
            this.grbEdicao.Controls.Add(this.lblEditarNovaSenha);
            this.grbEdicao.Controls.Add(this.lblEditarEmail);
            this.grbEdicao.Controls.Add(this.lblEditarNome);
            this.grbEdicao.Controls.Add(this.TxbEditarSenha);
            this.grbEdicao.Controls.Add(this.TxbEditarEmail);
            this.grbEdicao.Controls.Add(this.txbEditarNome);
            this.grbEdicao.Enabled = false;
            this.grbEdicao.Location = new System.Drawing.Point(444, 248);
            this.grbEdicao.Name = "grbEdicao";
            this.grbEdicao.Size = new System.Drawing.Size(261, 236);
            this.grbEdicao.TabIndex = 7;
            this.grbEdicao.TabStop = false;
            this.grbEdicao.Text = "Edicao";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(6, 179);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(232, 36);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblEditarNovaSenha
            // 
            this.lblEditarNovaSenha.AutoSize = true;
            this.lblEditarNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarNovaSenha.Location = new System.Drawing.Point(47, 131);
            this.lblEditarNovaSenha.Name = "lblEditarNovaSenha";
            this.lblEditarNovaSenha.Size = new System.Drawing.Size(53, 17);
            this.lblEditarNovaSenha.TabIndex = 5;
            this.lblEditarNovaSenha.Text = "Senha:";
            // 
            // lblEditarEmail
            // 
            this.lblEditarEmail.AutoSize = true;
            this.lblEditarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarEmail.Location = new System.Drawing.Point(54, 86);
            this.lblEditarEmail.Name = "lblEditarEmail";
            this.lblEditarEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEditarEmail.TabIndex = 4;
            this.lblEditarEmail.Text = "Email:";
            // 
            // lblEditarNome
            // 
            this.lblEditarNome.AutoSize = true;
            this.lblEditarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarNome.Location = new System.Drawing.Point(0, 47);
            this.lblEditarNome.Name = "lblEditarNome";
            this.lblEditarNome.Size = new System.Drawing.Size(100, 15);
            this.lblEditarNome.TabIndex = 3;
            this.lblEditarNome.Text = "Nome Completo:";
            // 
            // TxbEditarSenha
            // 
            this.TxbEditarSenha.Location = new System.Drawing.Point(106, 128);
            this.TxbEditarSenha.Name = "TxbEditarSenha";
            this.TxbEditarSenha.Size = new System.Drawing.Size(132, 20);
            this.TxbEditarSenha.TabIndex = 2;
            // 
            // TxbEditarEmail
            // 
            this.TxbEditarEmail.Location = new System.Drawing.Point(106, 85);
            this.TxbEditarEmail.Name = "TxbEditarEmail";
            this.TxbEditarEmail.Size = new System.Drawing.Size(132, 20);
            this.TxbEditarEmail.TabIndex = 1;
            // 
            // txbEditarNome
            // 
            this.txbEditarNome.Location = new System.Drawing.Point(106, 42);
            this.txbEditarNome.Name = "txbEditarNome";
            this.txbEditarNome.Size = new System.Drawing.Size(132, 20);
            this.txbEditarNome.TabIndex = 0;
            // 
            // GrbApagar
            // 
            this.GrbApagar.Controls.Add(this.lblApagar);
            this.GrbApagar.Controls.Add(this.btnApagar);
            this.GrbApagar.Enabled = false;
            this.GrbApagar.Location = new System.Drawing.Point(12, 490);
            this.GrbApagar.Name = "GrbApagar";
            this.GrbApagar.Size = new System.Drawing.Size(693, 51);
            this.GrbApagar.TabIndex = 8;
            this.GrbApagar.TabStop = false;
            this.GrbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(523, 19);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(90, 24);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.Location = new System.Drawing.Point(25, 20);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(322, 22);
            this.lblApagar.TabIndex = 1;
            this.lblApagar.Text = "Selecione o usuario que deseja apagar";
            // 
            // FrmGestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 601);
            this.Controls.Add(this.GrbApagar);
            this.Controls.Add(this.grbEdicao);
            this.Controls.Add(this.GrbCadastro);
            this.Controls.Add(this.DgvUsuario);
            this.Name = "FrmGestaoUsuarios";
            this.Text = "FrmGestaoUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuario)).EndInit();
            this.GrbCadastro.ResumeLayout(false);
            this.GrbCadastro.PerformLayout();
            this.grbEdicao.ResumeLayout(false);
            this.grbEdicao.PerformLayout();
            this.GrbApagar.ResumeLayout(false);
            this.GrbApagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUsuario;
        private System.Windows.Forms.GroupBox GrbCadastro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbCadastroSenha;
        private System.Windows.Forms.TextBox txbCadastroEmail;
        private System.Windows.Forms.TextBox txbCadastroNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbEdicao;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblEditarNovaSenha;
        private System.Windows.Forms.Label lblEditarEmail;
        private System.Windows.Forms.Label lblEditarNome;
        private System.Windows.Forms.TextBox TxbEditarSenha;
        private System.Windows.Forms.TextBox TxbEditarEmail;
        private System.Windows.Forms.TextBox txbEditarNome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox GrbApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Button btnApagar;
    }
}