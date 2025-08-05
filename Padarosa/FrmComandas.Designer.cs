namespace Padarosa
{
    partial class lblProdutosLancar
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
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.grbInformacaoes = new System.Windows.Forms.GroupBox();
            this.txbProdutosInfo = new System.Windows.Forms.TextBox();
            this.txbComandasInfo = new System.Windows.Forms.TextBox();
            this.lblProdutoInfo = new System.Windows.Forms.Label();
            this.lblComandaInfo = new System.Windows.Forms.Label();
            this.grbLancar = new System.Windows.Forms.GroupBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbNomeProduto = new System.Windows.Forms.TextBox();
            this.lblQuantidadeLancamento = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.btnLancar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            this.grbInformacaoes.SuspendLayout();
            this.grbLancar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComandas
            // 
            this.dgvComandas.AllowUserToAddRows = false;
            this.dgvComandas.AllowUserToDeleteRows = false;
            this.dgvComandas.AllowUserToResizeColumns = false;
            this.dgvComandas.AllowUserToResizeRows = false;
            this.dgvComandas.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvComandas.Location = new System.Drawing.Point(362, 12);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.Size = new System.Drawing.Size(426, 516);
            this.dgvComandas.TabIndex = 0;
            this.dgvComandas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComandas_CellClick);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContinuar.Location = new System.Drawing.Point(23, 204);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(263, 39);
            this.btnContinuar.TabIndex = 1;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // grbInformacaoes
            // 
            this.grbInformacaoes.Controls.Add(this.txbProdutosInfo);
            this.grbInformacaoes.Controls.Add(this.txbComandasInfo);
            this.grbInformacaoes.Controls.Add(this.lblProdutoInfo);
            this.grbInformacaoes.Controls.Add(this.lblComandaInfo);
            this.grbInformacaoes.Controls.Add(this.btnContinuar);
            this.grbInformacaoes.Location = new System.Drawing.Point(12, 12);
            this.grbInformacaoes.Name = "grbInformacaoes";
            this.grbInformacaoes.Size = new System.Drawing.Size(321, 249);
            this.grbInformacaoes.TabIndex = 2;
            this.grbInformacaoes.TabStop = false;
            this.grbInformacaoes.Text = "Informações";
            // 
            // txbProdutosInfo
            // 
            this.txbProdutosInfo.Location = new System.Drawing.Point(113, 111);
            this.txbProdutosInfo.Multiline = true;
            this.txbProdutosInfo.Name = "txbProdutosInfo";
            this.txbProdutosInfo.Size = new System.Drawing.Size(160, 20);
            this.txbProdutosInfo.TabIndex = 5;
            // 
            // txbComandasInfo
            // 
            this.txbComandasInfo.Location = new System.Drawing.Point(113, 48);
            this.txbComandasInfo.Multiline = true;
            this.txbComandasInfo.Name = "txbComandasInfo";
            this.txbComandasInfo.Size = new System.Drawing.Size(160, 20);
            this.txbComandasInfo.TabIndex = 4;
            // 
            // lblProdutoInfo
            // 
            this.lblProdutoInfo.AutoSize = true;
            this.lblProdutoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoInfo.Location = new System.Drawing.Point(6, 111);
            this.lblProdutoInfo.Name = "lblProdutoInfo";
            this.lblProdutoInfo.Size = new System.Drawing.Size(80, 20);
            this.lblProdutoInfo.TabIndex = 3;
            this.lblProdutoInfo.Text = "Produto:";
            // 
            // lblComandaInfo
            // 
            this.lblComandaInfo.AutoSize = true;
            this.lblComandaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandaInfo.Location = new System.Drawing.Point(6, 48);
            this.lblComandaInfo.Name = "lblComandaInfo";
            this.lblComandaInfo.Size = new System.Drawing.Size(103, 20);
            this.lblComandaInfo.TabIndex = 2;
            this.lblComandaInfo.Text = "Comandas:";
            // 
            // grbLancar
            // 
            this.grbLancar.Controls.Add(this.txbQuantidade);
            this.grbLancar.Controls.Add(this.txbNomeProduto);
            this.grbLancar.Controls.Add(this.lblQuantidadeLancamento);
            this.grbLancar.Controls.Add(this.lblNomeProduto);
            this.grbLancar.Controls.Add(this.btnLancar);
            this.grbLancar.Enabled = false;
            this.grbLancar.Location = new System.Drawing.Point(12, 267);
            this.grbLancar.Name = "grbLancar";
            this.grbLancar.Size = new System.Drawing.Size(321, 207);
            this.grbLancar.TabIndex = 6;
            this.grbLancar.TabStop = false;
            this.grbLancar.Text = "Lançar";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(136, 86);
            this.txbQuantidade.Multiline = true;
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(179, 20);
            this.txbQuantidade.TabIndex = 5;
            // 
            // txbNomeProduto
            // 
            this.txbNomeProduto.Location = new System.Drawing.Point(167, 40);
            this.txbNomeProduto.Multiline = true;
            this.txbNomeProduto.Name = "txbNomeProduto";
            this.txbNomeProduto.Size = new System.Drawing.Size(148, 20);
            this.txbNomeProduto.TabIndex = 4;
            // 
            // lblQuantidadeLancamento
            // 
            this.lblQuantidadeLancamento.AutoSize = true;
            this.lblQuantidadeLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeLancamento.Location = new System.Drawing.Point(19, 86);
            this.lblQuantidadeLancamento.Name = "lblQuantidadeLancamento";
            this.lblQuantidadeLancamento.Size = new System.Drawing.Size(110, 20);
            this.lblQuantidadeLancamento.TabIndex = 3;
            this.lblQuantidadeLancamento.Text = "Quantidade:";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(20, 43);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(141, 17);
            this.lblNomeProduto.TabIndex = 2;
            this.lblNomeProduto.Text = "Nome Do Produto:";
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.Black;
            this.btnLancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLancar.Location = new System.Drawing.Point(23, 138);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(269, 41);
            this.btnLancar.TabIndex = 1;
            this.btnLancar.Text = "Lancar";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Black;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.Red;
            this.btncancelar.Location = new System.Drawing.Point(12, 495);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(120, 33);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblProdutosLancar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.grbLancar);
            this.Controls.Add(this.grbInformacaoes);
            this.Controls.Add(this.dgvComandas);
            this.Name = "lblProdutosLancar";
            this.Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            this.grbInformacaoes.ResumeLayout(false);
            this.grbInformacaoes.PerformLayout();
            this.grbLancar.ResumeLayout(false);
            this.grbLancar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.GroupBox grbInformacaoes;
        private System.Windows.Forms.Label lblProdutoInfo;
        private System.Windows.Forms.Label lblComandaInfo;
        private System.Windows.Forms.TextBox txbProdutosInfo;
        private System.Windows.Forms.TextBox txbComandasInfo;
        private System.Windows.Forms.GroupBox grbLancar;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbNomeProduto;
        private System.Windows.Forms.Label lblQuantidadeLancamento;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Button btncancelar;
    }
}