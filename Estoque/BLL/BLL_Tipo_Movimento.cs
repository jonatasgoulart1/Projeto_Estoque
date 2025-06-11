using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Estoque.BLL.BLL_Grupos;

namespace Estoque.BLL
{
    public class BLL_Tipo_Movimento
    {
        SqlConnection conexao = new SqlConnection();
        BLL_Conexao conexaoBD = new BLL_Conexao();
        SqlDataReader Dr;

        public DataTable DtTipo_Movimento = new DataTable();

        public class Tipo_Movimento
        {
            public Int32 TipoMovimId { get; set; }
            public string Descricao { get; set; }
            public string Tipo { get; set; }
       
            public Tipo_Movimento tipo_Movimento { get; set; }
        }
        public string MontarLista(string varValor)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            // montar banco de dados com procedure
            SqlCommand cmd = new SqlCommand("DalMontarListaTipo_Movimento", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Descricao", "%" + varValor + "%");
            try
            {
                Dr = cmd.ExecuteReader();
                DtTipo_Movimento.Clear();
                DtTipo_Movimento.Load(Dr);
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
        public string InserirTipo_Movimento(string varDescricao ,string varTipo)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALInserirTipo_Movimento", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Descricao", varDescricao);
            cmd.Parameters.AddWithValue("@Tipo", varTipo);
         
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

        public string Alteratipo_Movimento(int tipoMovimId, string varDescricao, string varTipo)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALAlterarTipo_Movimento", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@TipoMovimId", tipoMovimId);
            cmd.Parameters.AddWithValue("@Descricao", varDescricao);
            cmd.Parameters.AddWithValue("@Tipo", varTipo);

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
    

      public string ExcluirTipo_Movimento(int varTipoMovimId)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALExcluirTipo_Movimento", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@TipoMovimId", varTipoMovimId);

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

    
 