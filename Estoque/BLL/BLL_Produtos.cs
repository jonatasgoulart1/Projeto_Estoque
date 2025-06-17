using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Estoque.BLL.BLL_Classes;
using static Estoque.BLL.BLL_Produtos;

namespace Estoque.BLL
{
    public class BLL_Produtos
    {
        SqlConnection conexao = new SqlConnection();
        BLL_Conexao conexaoBD = new BLL_Conexao();
        SqlDataReader Dr;

        public DataTable DtProdutos = new DataTable();

        public class Produtos
        {
            public Int32 ProdutoId { get; set; }
            public string Codigo { get; set; }

            public string Descricao { get; set; }
            public string Unidade { get; set; }

            public decimal PesoLiquido { get; set; }

            public decimal PesoBruto { get; set; }

            public Int32 Classe { get; set; }
            public Int32 Grupo { get; set; }

            public Int32 Familia { get; set; }
            public Int32 Departamento { get; set; }

            public decimal QtdeSaldo { get; set; }

            public decimal CustoMedio { get; set; }

            public decimal ValorSaldo { get; set; }
            public DateTime Data_Cadastro { get; set; }

            public string Situacao { get; set; }

            public DateTime DataUltCompra { get; set; }

            public string Local_Armazenamento { get; set; }

            public Produtos produtos { get; set; }
        }
        public string MontarLista(string varValor)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
   
            SqlCommand cmd = new SqlCommand("DalMontarListaProdutos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Descricao", "%" + varValor + "%");
            try
            {
                Dr = cmd.ExecuteReader();
                DtProdutos.Clear();
                DtProdutos.Load(Dr);
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

        public string InserirProdutos(
              string varCodigo,
              string varDescricao,
              string varUnidade,
              decimal varPesoBruto,
              decimal varPesoLiquido,
              int varClasse,
              int varGrupo,
              int varFamilia,
              int varDepartamento,
              decimal varQtdeSaldo,
              decimal varCustoMedio,
              decimal varValorSaldo,
              DateTime varDataCadastro,
              string varSituacao,
              DateTime varDataUltCompra,
               string varLocalArmazenamento)
        {
            string msg = string.Empty;
            try
            {
                conexao = conexaoBD.AbrirBanco();
                using (SqlCommand cmd = new SqlCommand("DALInserirProdutos", conexao))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Codigo", varCodigo);
                    cmd.Parameters.AddWithValue("@Descricao", varDescricao);
                    cmd.Parameters.AddWithValue("@Unidade", varUnidade);
                    cmd.Parameters.AddWithValue("@PesoBruto", varPesoBruto);
                    cmd.Parameters.AddWithValue("@PesoLiquido", varPesoLiquido);
                    cmd.Parameters.AddWithValue("@Classe", varClasse);
                    cmd.Parameters.AddWithValue("@Grupo", varGrupo);
                    cmd.Parameters.AddWithValue("@Familia", varFamilia);
                    cmd.Parameters.AddWithValue("@Departamento", varDepartamento);
                    cmd.Parameters.AddWithValue("@QtdeSaldo", varQtdeSaldo);
                    cmd.Parameters.AddWithValue("@CustoMedio", varCustoMedio);
                    cmd.Parameters.AddWithValue("@ValorSaldo", varValorSaldo);
                    cmd.Parameters.AddWithValue("@Data_Cadastro", varDataCadastro);
                    cmd.Parameters.AddWithValue("@Situacao", varSituacao);
                    cmd.Parameters.AddWithValue("@DataUltCompra", varDataUltCompra);
                    cmd.Parameters.AddWithValue("@Local_Armazenamento", varLocalArmazenamento);

                    cmd.ExecuteNonQuery();
                    msg = "Registro Inserido com Sucesso!";
                }
            }
            catch (SqlException sqlErr)
            {
                var retErro = new BLL_Conexao.RetornaErroSqlServer();
                msg = retErro.RetornaErro(sqlErr.Number);
                if (string.IsNullOrEmpty(msg)) msg = sqlErr.Message;
            }
            catch (Exception err)
            {
                msg = err.Message;
            }
            finally
            {
                if (conexao?.State == ConnectionState.Open)
                    conexaoBD.FecharBanco(conexao);
            }
            return msg;
        }

        public string AlterarProdutos(
 
            string varCodigo,
            string varDescricao,
            string varUnidade,
            decimal varPesoBruto,
            decimal varPesoLiquido,
            int varClasse,
            int varGrupo,
            int varFamilia,
            int varDepartamento,
            decimal varQtdeSaldo,
            decimal varCustoMedio,
            decimal varValorSaldo,
            DateTime varDataCadastro,
            string varSituacao,
            DateTime varDataUltCompra,
             string varLocalArmazenamento,
             int ProdutoId)
        {
            string msg = string.Empty;
            try
            {
                conexao = conexaoBD.AbrirBanco();
                using (SqlCommand cmd = new SqlCommand("DALAlterarProdutos", conexao))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Codigo", varCodigo);
                    cmd.Parameters.AddWithValue("@Descricao", varDescricao);
                    cmd.Parameters.AddWithValue("@Unidade", varUnidade);
                    cmd.Parameters.AddWithValue("@PesoBruto", varPesoBruto);
                    cmd.Parameters.AddWithValue("@PesoLiquido", varPesoLiquido);
                    cmd.Parameters.AddWithValue("@Classe", varClasse);
                    cmd.Parameters.AddWithValue("@Grupo", varGrupo);
                    cmd.Parameters.AddWithValue("@Familia", varFamilia);
                    cmd.Parameters.AddWithValue("@Departamento", varDepartamento);
                    cmd.Parameters.AddWithValue("@QtdeSaldo", varQtdeSaldo);
                    cmd.Parameters.AddWithValue("@CustoMedio", varCustoMedio);
                    cmd.Parameters.AddWithValue("@ValorSaldo", varValorSaldo);
                    cmd.Parameters.AddWithValue("@Data_Cadastro", varDataCadastro);
                    cmd.Parameters.AddWithValue("@Situacao", varSituacao);
                    cmd.Parameters.AddWithValue("@DataUltCompra", varDataUltCompra);
                    cmd.Parameters.AddWithValue("@Local_Armazenamento", varLocalArmazenamento);
                    cmd.Parameters.AddWithValue("@ProdutoId", ProdutoId);

                    cmd.ExecuteNonQuery();
                    msg = "Registro Atualizado com Sucesso!";
                }
            }
            catch (SqlException sqlErr)
            {
                var retErro = new BLL_Conexao.RetornaErroSqlServer();
                msg = retErro.RetornaErro(sqlErr.Number);
                if (string.IsNullOrEmpty(msg)) msg = sqlErr.Message;
            }
            catch (Exception err)
            {
                msg = err.Message;
            }
            finally
            {
                if (conexao?.State == ConnectionState.Open)
                    conexaoBD.FecharBanco(conexao);
            }
            return msg;
        }
    
      public string ExcluirProdutos(int varProdutoId)
        {
            string msg = string.Empty;
            conexao = conexaoBD.AbrirBanco();
            SqlCommand cmd = new SqlCommand("DALExcluirProdutos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ProdutoId", varProdutoId);

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

