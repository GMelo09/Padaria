using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Padarosa.Model
{
    class OrdemComanda
    {
        public int id { get; set; }
        public int idFicha { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public int Idresp { get; set; }
        public DateTime DataAdic { get; set; }
        public int Situacao { get; set; }

      

        public DataTable BuscarFicha()
        {
            string comando = "SELECT * FROM view_fichas WHERE Ficha = @idFicha";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@idFicha", idFicha);

            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();

            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public DataTable listar_Comanda()
        {

            string comando = "SELECT * FROM view_fichas";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();

            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();

            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public bool Cadastrar_Comanda()
        {
            string comando = "INSERT INTO ordens_comandas (id_ficha, id_produto, quantidade, id_resp, situacao) " +
              "VALUES (@id_ficha, @id_produto, @quantidade, @id_resp, @situacao)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_ficha", idFicha);
            cmd.Parameters.AddWithValue("@id_produto", IdProduto);
            cmd.Parameters.AddWithValue("@quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@id_resp", Idresp);
            cmd.Parameters.AddWithValue("@situacao", Situacao);

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }


        public bool Encerrar()
        {
            string comando = "UPDATE ordens_comandas SET situacao = 0 WHERE id_ficha = @id_ficha AND situacao = 1";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_ficha", idFicha);
            
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}