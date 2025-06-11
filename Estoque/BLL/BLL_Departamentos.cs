using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Estoque.BLL.BLL_Familias;

namespace Estoque.BLL
{
    public class BLL_Departamentos
    {
        SqlConnection conexao = new SqlConnection();
        BLL_Conexao conexaoBD = new BLL_Conexao();
        SqlDataReader Dr;

        public DataTable DtDepartamentos = new DataTable();

        public class Departamentos
        {
            public Int32 DepartamentoId { get; set; }
            public string Descricao { get; set; }

            public Departamentos departamentos { get; set; }
        }
        public string MontarLista(string varValor)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            // montar banco de dados com procedure
            SqlCommand cmd = new SqlCommand("DalMontarListaDepartamentos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Descricao", "%" + varValor + "%");
            try
            {
                Dr = cmd.ExecuteReader();
                DtDepartamentos.Clear();
                DtDepartamentos.Load(Dr);
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

        public string InserirDepartamentos(string varDescricao)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALInserirDepartamentos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Descricao", varDescricao);
  


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

        public string EditarDepartamentos(int departamentoId, string varDescricao)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALEditarDepartamentos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DepartamentoId", departamentoId);
            cmd.Parameters.AddWithValue("@Descricao", varDescricao);
      

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
        public string ExcluirDepartamentos(int varDepartamentoId)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALExcluirDepartamentos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DepartamentoId", varDepartamentoId);

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

    
 
