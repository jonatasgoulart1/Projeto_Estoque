using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.BLL
{
    public class BLL_Fornecedores
    {
        SqlConnection conexao = new SqlConnection();
        BLL_Conexao conexaoBD = new BLL_Conexao();
        SqlDataReader Dr;

        public DataTable DtFornecedores = new DataTable();

        public class Fornecedores
        {


            public Int32 FornecedorID { get; set; }
            public string RazaoSocial { get; set; }
            public string Endereco { get; set; }
            public string Cidade { get; set; }
            public string UF { get; set; }
            public string cep { get; set; }
            public string Telefone { get; set; }
            public string Celular { get; set; }
            public string Email { get; set; }
            public string Site { get; set; }

            public string Observacoes  { get; set; }



            public Fornecedores fornecedores { get; set; }
        }
        public string MontarLista(string varValor)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            // montar banco de dados com procedure
            SqlCommand cmd = new SqlCommand("DalMontarListaFornecedores", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@RazaoSocial", "%" + varValor + "%");
            try
            {
                Dr = cmd.ExecuteReader();
                DtFornecedores.Clear();
                DtFornecedores.Load(Dr);
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

        public string InserirFornecedores(string varRazaoSocial, string varEndereco, string varCidade,string 
            varUF, string varcep, string varTelefone, string varCelular, string varEmail, string varSite, string varObservacoes)

        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALInserirFornecedores", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@RazaoSocial", varRazaoSocial);
            cmd.Parameters.AddWithValue("@Endereco", varEndereco);
            cmd.Parameters.AddWithValue("@Cidade", varCidade);
            cmd.Parameters.AddWithValue("@UF", varUF);
            cmd.Parameters.AddWithValue("@cep", varcep);
            cmd.Parameters.AddWithValue("@Telefone", varTelefone);
            cmd.Parameters.AddWithValue("@Celular", varCelular);
            cmd.Parameters.AddWithValue("@Email", varEmail);
            cmd.Parameters.AddWithValue("@Site", varSite);
            cmd.Parameters.AddWithValue("@Observacoes", varObservacoes);
           
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

        public string AlterarFornecedor(
        int fornecedorID, string razaoSocial, string endereco, string cidade,
        string uf, string cep, string telefone, string celular, string email,
          string site, string observacoes)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALAlterarFornecedores", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@FornecedorID", fornecedorID);
            cmd.Parameters.AddWithValue("@RazaoSocial", razaoSocial);
            cmd.Parameters.AddWithValue("@Endereco", endereco);
            cmd.Parameters.AddWithValue("@Cidade", cidade);
            cmd.Parameters.AddWithValue("@UF", uf);
            cmd.Parameters.AddWithValue("@CEP", cep);
            cmd.Parameters.AddWithValue("@Telefone", telefone);
            cmd.Parameters.AddWithValue("@Celular", celular);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Site", site);
            cmd.Parameters.AddWithValue("@Observacoes", observacoes);

            try
            {
                cmd.ExecuteNonQuery();
                msg = "Fornecedor atualizado com sucesso!";
            }
            catch (SqlException sqlErrr)
            {
                BLL_Conexao.RetornaErroSqlServer retErro = new BLL_Conexao.RetornaErroSqlServer();
                string msgErro = retErro.RetornaErro(sqlErrr.Number);
                msg = string.IsNullOrEmpty(msgErro) ? sqlErrr.Message : msgErro;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexaoBD.FecharBanco(conexao);
            }

            return msg;
        }
        public string ExcluirFornecedores(int varFornecedorID)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALExcluirFornecedores", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@FornecedorID", varFornecedorID);

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

   
