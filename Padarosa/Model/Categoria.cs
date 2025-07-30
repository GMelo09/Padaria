using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padarosa.Model
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }


        public int Cadastrar()
        {
            //Modificar depois:
            return 0;
        }
        public DataTable Listar()
        {
            //Modificar depois:
            return new DataTable();
        }
        public int Excluir()
        {
            //Modificar depois:
            return 0;
        }
        public int Modificar()
        {
            //Modificar depois:
            return 0;
        }
    }
}
