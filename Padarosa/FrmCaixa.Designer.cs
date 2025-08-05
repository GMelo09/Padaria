namespace Padarosa
{
    partial class FrmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixa));
            this.dgvCaixaa = new System.Windows.Forms.DataGridView();
            this.lblNumeroComanda = new System.Windows.Forms.Label();
            this.txbNumFicha = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.chbPagameneto = new System.Windows.Forms.CheckBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixaa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCaixaa
            // 
            this.dgvCaixaa.AllowUserToAddRows = false;
            this.dgvCaixaa.AllowUserToDeleteRows = false;
            this.dgvCaixaa.AllowUserToResizeColumns = false;
            this.dgvCaixaa.AllowUserToResizeRows = false;
            this.dgvCaixaa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixaa.Location = new System.Drawing.Point(12, 12);
            this.dgvCaixaa.Name = "dgvCaixaa";
            this.dgvCaixaa.Size = new System.Drawing.Size(621, 241);
            this.dgvCaixaa.TabIndex = 0;
            // 
            // lblNumeroComanda
            // 
            this.lblNumeroComanda.AutoSize = true;
            this.lblNumeroComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroComanda.Location = new System.Drawing.Point(8, 290);
            this.lblNumeroComanda.Name = "lblNumeroComanda";
            this.lblNumeroComanda.Size = new System.Drawing.Size(113, 20);
            this.lblNumeroComanda.TabIndex = 1;
            this.lblNumeroComanda.Text = "N° Comanda:";
            // 
            // txbNumFicha
            // 
            this.txbNumFicha.Location = new System.Drawing.Point(127, 290);
            this.txbNumFicha.Multiline = true;
            this.txbNumFicha.Name = "txbNumFicha";
            this.txbNumFicha.Size = new System.Drawing.Size(100, 26);
            this.txbNumFicha.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListar.Location = new System.Drawing.Point(12, 326);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(215, 38);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // chbPagameneto
            // 
            this.chbPagameneto.AutoSize = true;
            this.chbPagameneto.Location = new System.Drawing.Point(333, 303);
            this.chbPagameneto.Name = "chbPagameneto";
            this.chbPagameneto.Size = new System.Drawing.Size(129, 17);
            this.chbPagameneto.TabIndex = 4;
            this.chbPagameneto.Text = "Pagamento Recebido";
            this.chbPagameneto.UseVisualStyleBackColor = true;
            this.chbPagameneto.CheckedChanged += new System.EventHandler(this.chbPagameneto_CheckedChanged);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.FlatAppearance.BorderSize = 0;
            this.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrar.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnEncerrar.Location = new System.Drawing.Point(333, 326);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(215, 38);
            this.btnEncerrar.TabIndex = 5;
            this.btnEncerrar.Text = "Encerrar comanda";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(329, 280);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Valor:";
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 405);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.chbPagameneto);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txbNumFicha);
            this.Controls.Add(this.lblNumeroComanda);
            this.Controls.Add(this.dgvCaixaa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCaixa";
            this.Text = "FrmCaixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixaa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCaixaa;
        private System.Windows.Forms.Label lblNumeroComanda;
        private System.Windows.Forms.TextBox txbNumFicha;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.CheckBox chbPagameneto;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label lblTotal;
    }
}