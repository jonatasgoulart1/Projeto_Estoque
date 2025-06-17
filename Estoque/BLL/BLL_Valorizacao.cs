using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Estoque.BLL.BLL_Classes;

namespace Estoque.BLL
{
    public class BLL_Valorizacao
    {
        SqlConnection conexao = new SqlConnection();
        BLL_Conexao conexaoBD = new BLL_Conexao();
        SqlDataReader Dr;

        public DataTable DtValorizacao = new DataTable();

        public class Valorizacao
        {
            public Int32 Ano { get; set; }
            public Int32 Mes { get; set; }
            public Int32 ProdutoId { get; set; }

            public decimal QtdeSaldo { get; set; }
            public decimal CustoMedio { get; set; }
            public decimal ValorSaldo { get; set; }
            public Valorizacao valorizacao { get; set; }
        }

        public string MontarLista(string varValor)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            // montar banco de dados com procedure
            SqlCommand cmd = new SqlCommand("DalMontarListaValorizacao", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Ano", "%" + varValor + "%");
            try
            {
                Dr = cmd.ExecuteReader();
                DtValorizacao.Clear();
                DtValorizacao.Load(Dr);
                Dr.Close();
                conexaoBD.FecharBanco(conexao);

            }
            catch (SqlException sqlErrr)
            {
                BLL_Conexao.RetornaErroSqlServer retErro = new BLL_Conexao.RetornaErroSqlServer();
                string msgErro = retErro.RetornaErro(sqlErrr.Number);
                if (string.IsNullOrEmpty(msgErro)) msgErro = sqlErrr.Message; msg = msgErro;

            }
            catch (Exception err)
            {
                msg = err.Message.ToString();
            }
            finally
            {
                if (conexao.State == ConnectionState.Open) conexaoBD.FecharBanco(conexao);
            }
            return msg;
        }
    

     public string InserirValorizacao(int varAno, int varMes,
         int varProdutoId, decimal varQtdeSaldo,
         decimal varCustoMedio,decimal varValorSaldo)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALInserirValorizacao", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Ano", varAno);
            cmd.Parameters.AddWithValue("@Mes", varMes);
            cmd.Parameters.AddWithValue("@ProdutoId", varProdutoId);
            cmd.Parameters.AddWithValue("@QtdeSaldo", varQtdeSaldo);
            cmd.Parameters.AddWithValue("@CustoMedio", varCustoMedio);
            cmd.Parameters.AddWithValue("@ValorSaldo", varValorSaldo);



            try
            {
                cmd.ExecuteNonQuery();
                conexaoBD.FecharBanco(conexao);
                msg = "Registro Inserido com Sucesso!";
            }
            catch (SqlException sqlErrr)
            {
                BLL_Conexao.RetornaErroSqlServer retErro = new BLL_Conexao.RetornaErroSqlServer();
                string msgErro = retErro.RetornaErro(sqlErrr.Number);
                if (string.IsNullOrEmpty(msgErro))
                    msgErro = sqlErrr.Message;
                msg = msgErro;
            }
            catch (Exception err)
            {
                msg = err.Message.ToString();
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexaoBD.FecharBanco(conexao);
            }

            return msg;
        }
        public string AlterarValorizacao(int varAno, int varMes,
         int varProdutoId, decimal varQtdeSaldo,
         decimal varCustoMedio, decimal varValorSaldo)

        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALAlterarValorizacao", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Ano", varAno);
            cmd.Parameters.AddWithValue("@Mes", varMes);
            cmd.Parameters.AddWithValue("@ProdutoId", varProdutoId);
            cmd.Parameters.AddWithValue("@QtdeSaldo", varQtdeSaldo);
            cmd.Parameters.AddWithValue("@CustoMedio", varCustoMedio);
            cmd.Parameters.AddWithValue("@ValorSaldo", varValorSaldo);


            try
            {
                cmd.ExecuteNonQuery();
                msg = "Registro Atualizado com Sucesso!";
            }
            catch (SqlException sqlErrr)
            {
                BLL_Conexao.RetornaErroSqlServer retErro = new BLL_Conexao.RetornaErroSqlServer();
                string msgErro = retErro.RetornaErro(sqlErrr.Number);
                if (string.IsNullOrEmpty(msgErro))
                    msgErro = sqlErrr.Message;
                msg = msgErro;
            }
            catch (Exception err)
            {
                msg = err.Message.ToString();
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexaoBD.FecharBanco(conexao);
            }

            return msg;
        }
        public string ExcluirValorizacao(int varAno, int varMes, int ProdutoId)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALExcluirValorizacao", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Ano", varAno);
            cmd.Parameters.AddWithValue("@Mes", varMes);
            cmd.Parameters.AddWithValue("@ProdutoId", ProdutoId);

            try
            {
                cmd.ExecuteNonQuery();
                msg = "Registro Excluido com sucesso!";
            }
            catch (SqlException sqlErrr)
            {
                BLL_Conexao.RetornaErroSqlServer retErro = new BLL_Conexao.RetornaErroSqlServer();
                string msgErro = retErro.RetornaErro(sqlErrr.Number);
                if (string.IsNullOrEmpty(msgErro))
                    msgErro = sqlErrr.Message;
                msg = msgErro;
            }
            catch (Exception err)
            {
                msg = err.Message.ToString();
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexaoBD.FecharBanco(conexao);
            }

            return msg;
        }
    }
}

    
