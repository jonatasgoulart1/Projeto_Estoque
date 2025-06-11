using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Estoque.BLL.BLL_Classes;

namespace Estoque.BLL
{
    public class BLL_Grupos
    {
        SqlConnection conexao = new SqlConnection();
        BLL_Conexao conexaoBD = new BLL_Conexao();
        SqlDataReader Dr;

        public DataTable DtGrupos = new DataTable();

        public class Grupos
        {
            public Int32 GrupoId { get; set; }
            public string Abreviatura { get; set; }
            public string Descricao { get; set; }
   
            public Grupos grupos { get; set; }
        }

        public string MontarLista(string varValor)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            // montar banco de dados com procedure
            SqlCommand cmd = new SqlCommand("DalMontarListaGrupos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Descricao", "%" + varValor + "%");
            try
            {
                Dr = cmd.ExecuteReader();
                DtGrupos.Clear();
                DtGrupos.Load(Dr);
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

        public string InserirGrupos(string varDescricao, string varAbreviatura)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALInserirGrupos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Descricao", varDescricao);
            cmd.Parameters.AddWithValue("@Abreviatura", varAbreviatura);


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

        public string AlterarGrupos(int grupoID, string varDescricao, string varAbreviatura)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALAlterarGrupos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@GrupoId", grupoID);
            cmd.Parameters.AddWithValue("@Descricao", varDescricao);
            cmd.Parameters.AddWithValue("@Abreviatura", varAbreviatura);


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
        public string ExcluirGrupos(int varGrupoId)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALExcluirGrupos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@GrupoId", varGrupoId);

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

    

 