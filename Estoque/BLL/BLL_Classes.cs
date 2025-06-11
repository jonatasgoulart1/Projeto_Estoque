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
    public class BLL_Classes
    {
        SqlConnection conexao = new SqlConnection();
        BLL_Conexao conexaoBD = new BLL_Conexao();
        SqlDataReader Dr;

        public DataTable DtClasses = new DataTable();

        public class Classes
        {
            public Int32 ClasseId { get; set; }
            public string Abreviatura { get; set; }
            public string Descricao { get; set; }
            public Classes classes{ get; set; }
        }
        public string MontarLista(string varValor)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            // montar banco de dados com procedure
            SqlCommand cmd = new SqlCommand("DalMontarListaClasses", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Descricao", "%" + varValor + "%");
            try
            {
                Dr = cmd.ExecuteReader();
                DtClasses.Clear();
                DtClasses.Load(Dr);
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
        public string InserirClasses(string varDescricao,string varAbreviatura)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALInserirClasses", conexao);
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
        public string AlterarClasse(int classeId, string varDescricao, string varAbreviatura)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALAlterarClasse", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ClasseId", classeId);
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
        public string ExcluirClasses(int varclasseId)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALExcluirClasses", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ClasseId", varclasseId);

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

    
