using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.BLL
{
    public class BLL_Conexao
    {
        public SqlConnection AbrirBanco()
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\Tecnico em Informatica\Backup projeto estoque\Estoque_XX\Estoque\Bd_Estoque.mdf"";Integrated Security=True;Connect Timeout=30");


            SqlCommand cmd = new SqlCommand();

            if (conexao.State == ConnectionState.Open) conexao.Close();
            conexao.Open();
            return conexao;
        }
        public void FecharBanco(SqlConnection conexao)
        {
            if (conexao.State == ConnectionState.Open)
                conexao.Close();
        }
        public class Erro
        {
            public int Id { get; set; }
            public string Descricao { get; set; }
        }

        public class RetornaErroSqlServer
        {
            List<Erro> lstErros = new List<Erro>()
            {
            new Erro() { Id = 2627,
             Descricao = "Violacao da restricao de chave Unica.Registro já existente"},
            new Erro(){ Id=547,
             Descricao="Exclusão de registro não permitida. \nProvavelmente existem registros filhos." }
            };
            public string RetornaErro(int erroNumber)
            {
                string msgErro = string.Empty;

                Erro erroInfo = new Erro();
                erroInfo = lstErros.Find(p => p.Id == erroNumber);
                if (erroInfo != null)
                    msgErro = erroInfo.Descricao;
                return msgErro;
            }
        }
    }
}

