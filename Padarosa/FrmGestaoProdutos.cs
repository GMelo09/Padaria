using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Padarosa.Model;

namespace Padarosa
{
    public partial class FrmGestaoProdutos : Form
    {
        //Variaveis globais:
        Model.Usuario usuario;
        Model.Produto produto = new Model.Produto();
        Model.Categoria categoria = new Model.Categoria();

        public FrmGestaoProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgvProdutos();
            
            //Obter as Categorias do Banco:
            DataTable resultadoCategorias = categoria.Listar_Categorias();

            foreach (DataRow linha in resultadoCategorias.Rows)
            {
                //Exemplo: 1 -Alimentacao:
                //Adicionar ao Combobox
                cmbCategoriasCadastrar.Items.Add($"{linha["id"]} - {linha["nome"]}");
                CmbCategoriasEditar.Items.Add($"{linha["id"]} - {linha["nome"]}");


            }
        }

        private void FrmGestaoProdutos_Load(object sender, EventArgs e)
        {
            
        }
        public void AtualizarDgvProdutos()
        {
           dgvProdutos.DataSource = produto.Listar_Produtos();


        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {

            if (txbCadastroNome.Text.Length < 6)
            {
                MessageBox.Show("O nome informado é invalido!", "Erro! ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbCadastroPreco.Text.Length < 1)
            {
                MessageBox.Show("O preço informado é invalido!", "Erro! ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                this.produto.nome = txbCadastroNome.Text;
                this.produto.preco = double.Parse(txbCadastroPreco.Text);
                this.produto.id_categoria = int.Parse(cmbCategoriasCadastrar.Text.Split('-')[0]);

                //Obter apenas o id categoria no combobox
                this.produto.id_rescadastro = usuario.Id;

                if (produto.Cadastrar_produtos() == true)
                {
                    MessageBox.Show("Produto cadastrado com sucesso! ", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpar os campo de cadastro: 
                    txbCadastroNome.Clear();
                    txbCadastroPreco.Clear();


                    //Puxar os dados da tabela usuario
                    AtualizarDgvProdutos();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o Produto", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvProdutos.SelectedCells[0].RowIndex;

            //Atribuir od dados da çonha selecionada no grbEditar:
            this.produto.nome = dgvProdutos.Rows[linhaSelecionada].Cells[1].Value.ToString();
            this.produto.preco = Convert.ToDouble(dgvProdutos.Rows[linhaSelecionada].Cells[2].Value);
            this.produto.Id = (int)dgvProdutos.Rows[linhaSelecionada].Cells[3].Value;
            this.produto.Id = (int)dgvProdutos.Rows[linhaSelecionada].Cells[0].Value;


            //atribuir linha selecionada no grbEditar
            txbEditarNome.Text = this.produto.nome;
            TxbEditarPreco.Text = this.produto.preco.ToString();
            //ativar o grbEdição:
            grbEdicao.Enabled = true;

            //Ativar o grbApagar:
            GrbApagar.Enabled = true;
            lblApagar.Text = $"{this.produto.Id} - {this.produto.nome}";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult apagar = MessageBox.Show("Tem certeza que deseja apagar este produto?", "Atenção!",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (apagar == DialogResult.Yes)
            {
                if (this.produto.Deletar_produtos())
                {
                    MessageBox.Show("produto removido com sucesso! ", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpar campos e desabelitar os grbs:
                    AtualizarDgvProdutos();
                    GrbApagar.Enabled = false;
                    grbEdicao.Enabled = false;
                    txbCadastroNome.Clear();
                   
                    txbCadastroPreco.Clear();
                    lblApagar.Text = "Selecione o usuario que deseja apagar.";
                  
                }
                else
                {
                    MessageBox.Show("Falha ao remover o produto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            //Validação de Erros:
            if (txbEditarNome.Text.Length < 3)
            {
                MessageBox.Show("O nome do produto informado é invalido!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxbEditarPreco.Text.Length < 1)
            {
                MessageBox.Show("O preco do produto informado é invalido!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            
            
            else
            {
                this.produto.nome = txbEditarNome.Text;
                this.produto.preco = double.Parse(TxbEditarPreco.Text);
                this.produto.id_categoria = int.Parse(CmbCategoriasEditar.Text.Split('-')[0]);

                this.produto.id_rescadastro = usuario.Id;
                //Executar o Modificar()
                if (this.produto.Modificar())
                {
                    MessageBox.Show("Produto modificado com sucesso! ", "Sucesso!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgvProdutos();
                    //Limparos campos e desabilitar os grbs
                    grbEdicao.Enabled = false;
                    GrbApagar.Enabled = false;
                    //txbEditarCategoria.Clear();
                    txbEditarNome.Clear();
                    txbCadastroPreco.Clear();

                }
                else
                {
                    MessageBox.Show("Falha ao modificar o produto! ", "Erro!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                AtualizarDgvProdutos();
            }
        }

    }
}
  


