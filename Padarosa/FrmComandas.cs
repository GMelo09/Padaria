using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa
{
    public partial class lblProdutosLancar : Form
    {
        //variaveis globais
        Model.Usuario usuario;
        Model.Produto produto = new Model.Produto();
        Model.OrdemComanda ordemComanda = new Model.OrdemComanda();

        public lblProdutosLancar(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgvComandas();
        }
        public void AtualizarDgv()
        {
            dgvComandas.DataSource = ordemComanda.listar_Comanda();
        }

        public void AtualizarDgvComandas()
        {
            dgvComandas.DataSource = produto.Listar_Produtos();

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //Verificar se os campos forma preenchidos:
            if (txbComandasInfo.Text == "")
            {
                MessageBox.Show("Informe o número da comanda!",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbProdutosInfo.Text == "")
            {
                MessageBox.Show("Informe o número do produto!",
                        "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Habilitar o campo de Lançamento:
                grbLancar.Enabled = true;
                txbProdutosInfo.Enabled = true;

                //Desativar o grbInfos:
                grbInformacaoes.Enabled = false;
            }

        }

        public void ResetarCampos()
        {
            grbInformacaoes.Enabled = false ;
            grbLancar.Enabled = false ;

            //Limpar os campos
            txbProdutosInfo.Clear();
            txbComandasInfo.Clear();
            txbNomeProduto.Clear();
            txbQuantidade.Clear();
        }

        private void dgvComandas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvComandas.SelectedCells[0].RowIndex;
            //Atribuir p id no produto no txb:
            txbProdutosInfo.Text = dgvComandas.Rows[linhaSelecionada].Cells[0].Value.ToString();
            //Atribuir p nome no txb:
            txbNomeProduto.Text = dgvComandas.Rows[linhaSelecionada].Cells[1].Value.ToString();
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if(txbQuantidade.Text == "")
            {
                MessageBox.Show("Informe a quantidade!",
                        "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult r = MessageBox.Show($"Tem certeza que deseja lançar {txbQuantidade.Text} unidades de" +
                    $" {txbProdutosInfo.Text}  na comnada {txbNomeProduto.Text}?", "Atenção!",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                // Se "Sim
                if( r == DialogResult.Yes )
                {
                    ordemComanda.Idresp = usuario.Id;
                    ordemComanda.IdProduto = int.Parse(txbProdutosInfo.Text);
                    ordemComanda.idFicha = int.Parse(txbComandasInfo.Text);
                    ordemComanda.Quantidade = int.Parse(txbQuantidade.Text);
                    ordemComanda.Situacao = 1;//Inserir

                    if (ordemComanda.Cadastrar_Comanda())
                    {
                        MessageBox.Show("Lançamneto efetuado com sucesso!",
                        "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao efetuar lancamento!",
                       "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Resetar os campos
                    ResetarCampos();

                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }
    }
}
