using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Padarosa.Model
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }


        public int Cadastrar_Categorias()
        {
            //Modificar depois:
            return 0;
        }
        public DataTable Listar_Categorias()
        {
            string comando = "SELECT * FROM categorias";


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
        public int Excluir_Categorias()
        {
            //Modificar depois:
            return 0;
        }
        public int Modificar_Categorias()
        {
            //Modificar depois:
            return 0;
        }
    }
}
