namespace Padarosa
{
    partial class FrmGestaoProdutos
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.GrbApagar = new System.Windows.Forms.GroupBox();
            this.lblApagar = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.grbEdicao = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblEdicaoPreco = new System.Windows.Forms.Label();
            this.lblEditarNomePreduto = new System.Windows.Forms.Label();
            this.TxbEditarPreco = new System.Windows.Forms.TextBox();
            this.txbEditarNome = new System.Windows.Forms.TextBox();
            this.GrbCadastro = new System.Windows.Forms.GroupBox();
            this.lblCadastraCategoria = new System.Windows.Forms.Label();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblEdicaoNomeProdutos = new System.Windows.Forms.Label();
            this.txbCadastroPreco = new System.Windows.Forms.TextBox();
            this.txbCadastroNome = new System.Windows.Forms.TextBox();
            this.txbEditarCategoria = new System.Windows.Forms.TextBox();
            this.txbCadastroCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.GrbApagar.SuspendLayout();
            this.grbEdicao.SuspendLayout();
            this.GrbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvProdutos.Location = new System.Drawing.Point(289, 24);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(496, 431);
            this.dgvProdutos.TabIndex = 16;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // GrbApagar
            // 
            this.GrbApagar.Controls.Add(this.lblApagar);
            this.GrbApagar.Controls.Add(this.btnApagar);
            this.GrbApagar.Enabled = false;
            this.GrbApagar.Location = new System.Drawing.Point(12, 461);
            this.GrbApagar.Name = "GrbApagar";
            this.GrbApagar.Size = new System.Drawing.Size(568, 51);
            this.GrbApagar.TabIndex = 15;
            this.GrbApagar.TabStop = false;
            this.GrbApagar.Text = "Apagar";
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.Location = new System.Drawing.Point(25, 20);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(338, 22);
            this.lblApagar.TabIndex = 1;
            this.lblApagar.Text = "Selecione um produto que deseja apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(470, 18);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(90, 24);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // grbEdicao
            // 
            this.grbEdicao.BackColor = System.Drawing.SystemColors.Control;
            this.grbEdicao.Controls.Add(this.txbEditarCategoria);
            this.grbEdicao.Controls.Add(this.lblCategoria);
            this.grbEdicao.Controls.Add(this.btnEditar);
            this.grbEdicao.Controls.Add(this.lblEdicaoPreco);
            this.grbEdicao.Controls.Add(this.lblEditarNomePreduto);
            this.grbEdicao.Controls.Add(this.TxbEditarPreco);
            this.grbEdicao.Controls.Add(this.txbEditarNome);
            this.grbEdicao.Enabled = false;
            this.grbEdicao.Location = new System.Drawing.Point(5, 216);
            this.grbEdicao.Name = "grbEdicao";
            this.grbEdicao.Size = new System.Drawing.Size(274, 239);
            this.grbEdicao.TabIndex = 14;
            this.grbEdicao.TabStop = false;
            this.grbEdicao.Text = "Edicao";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(41, 129);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 22);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(26, 171);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(232, 36);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblEdicaoPreco
            // 
            this.lblEdicaoPreco.AutoSize = true;
            this.lblEdicaoPreco.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdicaoPreco.Location = new System.Drawing.Point(68, 82);
            this.lblEdicaoPreco.Name = "lblEdicaoPreco";
            this.lblEdicaoPreco.Size = new System.Drawing.Size(52, 22);
            this.lblEdicaoPreco.TabIndex = 4;
            this.lblEdicaoPreco.Text = "Preço:";
            // 
            // lblEditarNomePreduto
            // 
            this.lblEditarNomePreduto.AutoSize = true;
            this.lblEditarNomePreduto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarNomePreduto.Location = new System.Drawing.Point(6, 42);
            this.lblEditarNomePreduto.Name = "lblEditarNomePreduto";
            this.lblEditarNomePreduto.Size = new System.Drawing.Size(115, 22);
            this.lblEditarNomePreduto.TabIndex = 3;
            this.lblEditarNomePreduto.Text = "Nome Produto:";
            // 
            // TxbEditarPreco
            // 
            this.TxbEditarPreco.Location = new System.Drawing.Point(126, 85);
            this.TxbEditarPreco.Name = "TxbEditarPreco";
            this.TxbEditarPreco.Size = new System.Drawing.Size(132, 20);
            this.TxbEditarPreco.TabIndex = 1;
            // 
            // txbEditarNome
            // 
            this.txbEditarNome.Location = new System.Drawing.Point(126, 42);
            this.txbEditarNome.Name = "txbEditarNome";
            this.txbEditarNome.Size = new System.Drawing.Size(132, 20);
            this.txbEditarNome.TabIndex = 0;
            // 
            // GrbCadastro
            // 
            this.GrbCadastro.Controls.Add(this.lblCadastraCategoria);
            this.GrbCadastro.Controls.Add(this.txbCadastroCategoria);
            this.GrbCadastro.Controls.Add(this.btnCadastrarProduto);
            this.GrbCadastro.Controls.Add(this.lblPreco);
            this.GrbCadastro.Controls.Add(this.lblEdicaoNomeProdutos);
            this.GrbCadastro.Controls.Add(this.txbCadastroPreco);
            this.GrbCadastro.Controls.Add(this.txbCadastroNome);
            this.GrbCadastro.Location = new System.Drawing.Point(5, 12);
            this.GrbCadastro.Name = "GrbCadastro";
            this.GrbCadastro.Size = new System.Drawing.Size(274, 192);
            this.GrbCadastro.TabIndex = 13;
            this.GrbCadastro.TabStop = false;
            this.GrbCadastro.Text = "Cadstro";
            // 
            // lblCadastraCategoria
            // 
            this.lblCadastraCategoria.AutoSize = true;
            this.lblCadastraCategoria.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastraCategoria.Location = new System.Drawing.Point(49, 95);
            this.lblCadastraCategoria.Name = "lblCadastraCategoria";
            this.lblCadastraCategoria.Size = new System.Drawing.Size(80, 22);
            this.lblCadastraCategoria.TabIndex = 7;
            this.lblCadastraCategoria.Text = "Categoria:";
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(35, 125);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(232, 36);
            this.btnCadastrarProduto.TabIndex = 6;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(77, 61);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(52, 22);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço:";
            // 
            // lblEdicaoNomeProdutos
            // 
            this.lblEdicaoNomeProdutos.AutoSize = true;
            this.lblEdicaoNomeProdutos.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdicaoNomeProdutos.Location = new System.Drawing.Point(14, 32);
            this.lblEdicaoNomeProdutos.Name = "lblEdicaoNomeProdutos";
            this.lblEdicaoNomeProdutos.Size = new System.Drawing.Size(115, 22);
            this.lblEdicaoNomeProdutos.TabIndex = 3;
            this.lblEdicaoNomeProdutos.Text = "Nome Produto:";
            // 
            // txbCadastroPreco
            // 
            this.txbCadastroPreco.Location = new System.Drawing.Point(136, 64);
            this.txbCadastroPreco.Name = "txbCadastroPreco";
            this.txbCadastroPreco.Size = new System.Drawing.Size(132, 20);
            this.txbCadastroPreco.TabIndex = 1;
            // 
            // txbCadastroNome
            // 
            this.txbCadastroNome.Location = new System.Drawing.Point(135, 35);
            this.txbCadastroNome.Name = "txbCadastroNome";
            this.txbCadastroNome.Size = new System.Drawing.Size(132, 20);
            this.txbCadastroNome.TabIndex = 0;
            // 
            // txbEditarCategoria
            // 
            this.txbEditarCategoria.Location = new System.Drawing.Point(126, 129);
            this.txbEditarCategoria.Name = "txbEditarCategoria";
            this.txbEditarCategoria.Size = new System.Drawing.Size(131, 20);
            this.txbEditarCategoria.TabIndex = 8;
            // 
            // txbCadastroCategoria
            // 
            this.txbCadastroCategoria.Location = new System.Drawing.Point(135, 99);
            this.txbCadastroCategoria.Name = "txbCadastroCategoria";
            this.txbCadastroCategoria.Size = new System.Drawing.Size(131, 20);
            this.txbCadastroCategoria.TabIndex = 9;
            // 
            // FrmGestaoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.GrbApagar);
            this.Controls.Add(this.grbEdicao);
            this.Controls.Add(this.GrbCadastro);
            this.Name = "FrmGestaoProdutos";
            this.Text = "FrmGestaoProdutos";
            this.Load += new System.EventHandler(this.FrmGestaoProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.GrbApagar.ResumeLayout(false);
            this.GrbApagar.PerformLayout();
            this.grbEdicao.ResumeLayout(false);
            this.grbEdicao.PerformLayout();
            this.GrbCadastro.ResumeLayout(false);
            this.GrbCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox GrbApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.GroupBox grbEdicao;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblEdicaoPreco;
        private System.Windows.Forms.Label lblEditarNomePreduto;
        private System.Windows.Forms.TextBox TxbEditarPreco;
        private System.Windows.Forms.TextBox txbEditarNome;
        private System.Windows.Forms.GroupBox GrbCadastro;
        private System.Windows.Forms.Label lblCadastraCategoria;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblEdicaoNomeProdutos;
        private System.Windows.Forms.TextBox txbCadastroPreco;
        private System.Windows.Forms.TextBox txbCadastroNome;
        private System.Windows.Forms.TextBox txbEditarCategoria;
        private System.Windows.Forms.TextBox txbCadastroCategoria;
    }
}