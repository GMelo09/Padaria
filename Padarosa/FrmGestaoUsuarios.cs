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

namespace Padarosa
{
    public partial class FrmGestaoUsuarios : Form
    {
        //variaveis globais
        Model.Usuario usuario;
        public FrmGestaoUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
        }
        public void AtualizarDgv()
        {
          DgvUsuario.DataSource = usuario.Listar();

                
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Validação de Erros:
            if(txbCadastroEmail.Text.Length < 6)
            {
                MessageBox.Show("O Email informado é invalido!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbCadastroNome.Text.Length < 7)
            {
                MessageBox.Show("O Nome informado vazio ou invalido!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbCadastroSenha.Text.Length <6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracters!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Instanciar o usuario
                Model.Usuario usuario = new Model.Usuario();
                usuario.Email = txbCadastroEmail.Text;
                usuario.NomeCompleto = txbCadastroNome.Text;
                usuario.Senha = txbCadastroSenha.Text;

                if (usuario.Cadastrar())
                {
                    MessageBox.Show("Usuario cadastrado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Limpar os campos do cadastro
                    txbCadastroEmail.Clear();
                    txbCadastroNome.Clear();
                    txbCadastroSenha.Clear();
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar usuario", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Validação de Erros:
            if (TxbEditarEmail.Text.Length < 6)
            {
                MessageBox.Show("O Email informado é invalido!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEditarNome.Text.Length < 7)
            {
                MessageBox.Show("O Nome informado vazio ou invalido!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxbEditarSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracters!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //iniciar edição no bd
                this.usuario.NomeCompleto = txbEditarNome.Text;
                this.usuario.Email = TxbEditarEmail.Text;
                this.usuario.Senha = TxbEditarSenha.Text;
                AtualizarDgv();

                //Executar o Modificar:
                if (this.usuario.Modificar())
                {
                    MessageBox.Show("Usuário modificado com sucesso! ", "Sucesso",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpar campos e desabelitar os grbs:
                    GrbApagar.Enabled = false;
                    grbEdicao.Enabled = false;
                    txbCadastroEmail.Clear();
                    txbCadastroNome.Clear();
                    txbCadastroSenha.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar usuário!", "ERRO",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult apagar = MessageBox.Show("Tem certeza que deseja apagar este usuario?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (apagar == DialogResult.Yes)
            {
                if (this.usuario.Remover())
                {
                    MessageBox.Show("Usuário removido com sucesso! ", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpar campos e desabelitar os grbs:
                    GrbApagar.Enabled = false;
                    grbEdicao.Enabled = false;
                    txbCadastroEmail.Clear();
                    txbCadastroNome.Clear();
                    txbCadastroSenha.Clear();
                    lblApagar.Text = "Selecione o usuario que deseja apagar.";
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Falha ao remover o usuário", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AtualizarDgv();
            }
        }

        private void DgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           int linhaSelecionada = DgvUsuario.SelectedCells[0].RowIndex;

            //Atribuir od dados da çonha selecionada no grbEditar:
            this.usuario.NomeCompleto = DgvUsuario.Rows[linhaSelecionada].Cells[1].Value.ToString();
            this.usuario.Email = DgvUsuario.Rows[linhaSelecionada].Cells[2].Value.ToString();
            this.usuario.Id = (int)DgvUsuario.Rows[linhaSelecionada].Cells[0].Value;
            

            //atribuir linha selecionada no grbEditar
            txbCadastroNome.Text = this.usuario.NomeCompleto;
            txbCadastroEmail.Text = this.usuario.Email;
            //ativar o grbEdição:
            grbEdicao.Enabled = true;

            //Ativar o grbApagar:
            GrbApagar.Enabled = true;
            lblApagar.Text = $"{this.usuario.Id} - {this.usuario.NomeCompleto}";
            
        }
    }
}
