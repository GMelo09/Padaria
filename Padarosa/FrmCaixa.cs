using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Padarosa.Model;

namespace Padarosa
{
    public partial class FrmCaixa : Form
    {
        //variaveis globais
        Model.Usuario usuario;
        Model.OrdemComanda ordemComanda = new OrdemComanda();
        public FrmCaixa(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
      
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if(txbNumFicha.Text == "" || txbNumFicha.Text.Length < 2)
            {
                MessageBox.Show ("Informe corretamente o número da ficha!",
                    "Atenção",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ordemComanda.idFicha = int.Parse(txbNumFicha.Text);
                DataTable consulta = ordemComanda.BuscarFicha();

                //Verificar se existe lançamentos na comanda
                if(consulta.Rows.Count == 0)
                {
                    MessageBox.Show("Não existe lancamentos nessa comnada!",
                   "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Mostar a consulta no dgv
                    dgvCaixaa.DataSource = consulta;

                    //Mostrar no label o total:
                    lblTotal.Text = "R$" + consulta.Compute("Sum(Total_Item)","True").ToString();
                }
            }
        }

        private void chbPagameneto_CheckedChanged(object sender, EventArgs e)
        {
            //Ativar ou desativar o btnEncerrar:
            btnEncerrar.Enabled = chbPagameneto.Checked;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            DialogResult pergunta = MessageBox.Show(
                $"Tem certeza que deseja encerrar a comanda {ordemComanda.idFicha}?",
                "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(pergunta == DialogResult.Yes)
            {
                if (ordemComanda.Encerrar())
                {
                    MessageBox.Show("Comanda Encerrada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Desabilitar o botão de encerrar o chb:
                    btnEncerrar.Enabled=false;
                    chbPagameneto.Checked=false;
                    //limpar o dgv
                    dgvCaixaa.DataSource = null;
                    //apagar o número da comanda
                    txbNumFicha.Text = "";

                        
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar comanda","ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
