using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Estoque.BLL.BLL_Parametros;

namespace Estoque.BLL
{
    public class BLL_Movimentos
    {
        SqlConnection conexao = new SqlConnection();
        BLL_Conexao conexaoBD = new BLL_Conexao();
        SqlDataReader Dr;

        public DataTable DtMovimentos = new DataTable();

        public class Movimentos
        {
            public Int32 MovimentoID { get; set; }
            public int Produto { get; set; }
            public int NrDocumento { get; set; }
            public DateTime DataDocumento { get; set; }
            public int Sequencia { get; set; }
            public int TipoMov { get; set; }
            public decimal Qtde { get; set; }
            public decimal CustoUnitario { get; set; }
            public decimal ValorMovimento { get; set; }
            public decimal QtdeSaldo { get; set; }
            public decimal CustoUnitarioSaldo { get; set; }
            public decimal ValorSaldo { get; set; }
            public int Fornecedor { get; set; }
        }





        public Movimentos movimentos { get; set; }

        public string MontarLista(string varValor)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            // montar banco de dados com procedure
            SqlCommand cmd = new SqlCommand("DalMontarListaMovimentos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Produto", "%" + varValor + "%");
            try
            {
                Dr = cmd.ExecuteReader();
                DtMovimentos.Clear();
                DtMovimentos.Load(Dr);
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

        public string InserirMovimento(
       int varProduto,
       int varNrDocumento,
       DateTime varDataDocumento,
       int varSequencia,
       int varTipoMov,
       decimal varQtde,
       decimal varCustoUnitario,
       decimal varValorMovimento,
       decimal varQtdeSaldo,
       decimal varCustoUnitarioSaldo,
       decimal varValorSaldo,
       int varFornecedor)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALInserirMovimentos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Produto", varProduto);
            cmd.Parameters.AddWithValue("@NrDocumento", varNrDocumento);
            cmd.Parameters.AddWithValue("@DataDocumento", Convert.ToDateTime(varDataDocumento));
            cmd.Parameters.AddWithValue("@Sequencia", varSequencia);
            cmd.Parameters.AddWithValue("@TipoMov", varTipoMov);
            cmd.Parameters.AddWithValue("@Qtde", varQtde);
            cmd.Parameters.AddWithValue("@CustoUnitario", varCustoUnitario);
            cmd.Parameters.AddWithValue("@ValorMovimento", varValorMovimento);
            cmd.Parameters.AddWithValue("@QtdeSaldo", varQtdeSaldo);
            cmd.Parameters.AddWithValue("@CustoUnitarioSaldo", varCustoUnitarioSaldo);
            cmd.Parameters.AddWithValue("@ValorSaldo", varValorSaldo);
            cmd.Parameters.AddWithValue("@Fornecedor", varFornecedor);

            try
            {
                cmd.ExecuteNonQuery();
                conexaoBD.FecharBanco(conexao);
                msg = "Registro inserido com sucesso!";
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
        public string AlterarMovimento(
        int movimentoID,
       int varProduto,
       int varNrDocumento,
       DateTime varDataDocumento,
       int varSequencia,
       int varTipoMov,
       decimal varQtde,
       decimal varCustoUnitario,
       decimal varValorMovimento,
       decimal varQtdeSaldo,
       decimal varCustoUnitarioSaldo,
       decimal varValorSaldo,
       int varFornecedor)

        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALAlterarMovimentos", conexao); 
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@MovimentoID", movimentoID);
            cmd.Parameters.AddWithValue("@Produto", varProduto);
            cmd.Parameters.AddWithValue("@NrDocumento", varNrDocumento);
            cmd.Parameters.AddWithValue("@DataDocumento", Convert.ToDateTime(varDataDocumento));
            cmd.Parameters.AddWithValue("@Sequencia", varSequencia);
            cmd.Parameters.AddWithValue("@TipoMov", varTipoMov);
            cmd.Parameters.AddWithValue("@Qtde", varQtde);
            cmd.Parameters.AddWithValue("@CustoUnitario", varCustoUnitario);
            cmd.Parameters.AddWithValue("@ValorMovimento", varValorMovimento);
            cmd.Parameters.AddWithValue("@QtdeSaldo", varQtdeSaldo);
            cmd.Parameters.AddWithValue("@CustoUnitarioSaldo", varCustoUnitarioSaldo);
            cmd.Parameters.AddWithValue("@ValorSaldo", varValorSaldo);
            cmd.Parameters.AddWithValue("@Fornecedor", varFornecedor);

            try
            {
                cmd.ExecuteNonQuery();
                conexaoBD.FecharBanco(conexao);
                msg = "Registro alterado com sucesso!";
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

        public string ExcluirMovimentos(int varMovimentoID)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALExcluirMovimentos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@MovimentoID", varMovimentoID);

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


