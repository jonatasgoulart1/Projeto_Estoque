using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;
using Estoque.Base;
using Estoque.BLL;

namespace Estoque.Derivadas
{
    public partial class FrmCadProdutos : FrmTemplateBase
    {
        BLL_Produtos MeuAdapterProdutos = new BLL_Produtos();

        public FrmCadProdutos()
        {
            InitializeComponent();
        }

        public override void FrmTemplateBase_Load(object sender, EventArgs e)
        {
            GridLista.Columns[0].DataPropertyName = "Descricao";
            GridLista.Columns[0].HeaderText = "Descrição do Produto";


            MeuAdapterProdutos.MontarLista("");
            ExibirTitulo("Cadastro dos Produtos");
            GridLista.DataSource = MeuAdapterProdutos.DtProdutos;
            base.FrmTemplateBase_Load(sender, e);
        }

        public override void TxtLocalizar_TextChanged(object sender, EventArgs e)
        {
            MeuAdapterProdutos.MontarLista(TxtLocalizar.Text);
            GridLista.DataSource = MeuAdapterProdutos.DtProdutos;
            base.TxtLocalizar_TextChanged(sender, e);
        }

        public override void GridLista_SelectionChanged(object sender, EventArgs e)
        {
            if (GridLista.SelectedRows.Count > 0)
            {
                DataRowView linha = (DataRowView)GridLista.SelectedRows[0].DataBoundItem;

                LblProdutoId.Text = linha["ProdutoId"].ToString();
                TxtCodigo.Text = linha["Codigo"].ToString();
                TxtDescricao.Text = linha["Descricao"].ToString();
                TxtUnidade.Text = linha["Unidade"].ToString();
                TxtPesoLiquido.Text = linha["PesoLiquido"].ToString();
                TxtPesoBruto.Text = linha["PesoBruto"].ToString();
                cmbClasse.Text = linha["Classe"].ToString();
                cmbGrupo.Text = linha["Grupo"].ToString();
                cmbFamilia.Text = linha["Familia"].ToString();
                cmbDepartamento.Text = linha["Departamento"].ToString();
                txtQtdeSaldo.Text = linha["QtdeSaldo"].ToString();
                txtCustoMedio.Text = linha["CustoMedio"].ToString();
                txtValorSaldo.Text = linha["ValorSaldo"].ToString();
                dtpDataCadastro.Text = linha["Data_Cadastro"].ToString();
                dtpUltCompra.Text = linha["DataUltCompra"].ToString();
                cmbSituacao.Text = linha["Situacao"].ToString();
                TxtLocalArmazenamento.Text = linha["Local_Armazenamento"].ToString();
            }

            base.GridLista_SelectionChanged(sender, e);
        }

        void LimparCampos()
        {
            LblProdutoId.Text = "";
            TxtCodigo.Clear();
            TxtDescricao.Clear();
            TxtUnidade.Clear();
            TxtPesoBruto.Clear();
            TxtPesoLiquido.Clear();
            cmbClasse.SelectedIndex = -1;
            cmbGrupo.SelectedIndex = -1;
            cmbFamilia.SelectedIndex = -1;
            cmbDepartamento.SelectedIndex = -1;
            txtQtdeSaldo.Clear();
            txtCustoMedio.Clear();
            txtValorSaldo.Clear();
            cmbSituacao.SelectedIndex = -1;
            dtpDataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpUltCompra.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public override void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            base.BtnNovo_Click(sender, e);
        }

        public override void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string Mensagem = "";
            if (string.IsNullOrEmpty(TxtCodigo.Text) ||
             string.IsNullOrEmpty(TxtDescricao.Text) ||
             string.IsNullOrEmpty(TxtUnidade.Text) ||
             string.IsNullOrEmpty(TxtPesoBruto.Text) ||
             string.IsNullOrEmpty(TxtPesoLiquido.Text) ||
             string.IsNullOrEmpty(cmbClasse.Text) ||
             string.IsNullOrEmpty(cmbGrupo.Text) ||
             string.IsNullOrEmpty(cmbFamilia.Text) ||
             string.IsNullOrEmpty(cmbDepartamento.Text) ||
             string.IsNullOrEmpty(txtQtdeSaldo.Text) ||
             string.IsNullOrEmpty(txtCustoMedio.Text) ||
             string.IsNullOrEmpty(txtValorSaldo.Text) ||
             string.IsNullOrEmpty(dtpDataCadastro.Text) ||
             string.IsNullOrEmpty(cmbSituacao.Text) ||
             string.IsNullOrEmpty(dtpUltCompra.Text))

            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                decimal pesoBruto = Convert.ToDecimal(TxtPesoBruto.Text);
                decimal pesoLiquido = Convert.ToDecimal(TxtPesoLiquido.Text);
                decimal qtdeSaldo = Convert.ToDecimal(txtQtdeSaldo.Text);
                decimal custoMedio = Convert.ToDecimal(txtCustoMedio.Text);
                decimal valorSaldo = Convert.ToDecimal(txtValorSaldo.Text);
                DateTime dataCadastro = Convert.ToDateTime(dtpDataCadastro.Text);
                DateTime dataUltCompra = Convert.ToDateTime(dtpUltCompra.Text);

                int classe = Convert.ToInt32(cmbClasse.Text);
                int grupo = Convert.ToInt32(cmbGrupo.Text);
                int familia = Convert.ToInt32(cmbFamilia.Text);
                int departamento = Convert.ToInt32(cmbDepartamento.Text);




                if (LblProdutoId.Text != "")
                {
                    int produtoId = Convert.ToInt32(LblProdutoId.Text);
                      Mensagem = MeuAdapterProdutos.AlterarProdutos(
                     TxtCodigo.Text, TxtDescricao.Text, TxtUnidade.Text,
                    pesoBruto, pesoLiquido,
                     classe, grupo, familia, departamento,
                     qtdeSaldo, custoMedio, valorSaldo,
                     dataCadastro, cmbSituacao.Text, dataUltCompra,
                      TxtLocalArmazenamento.Text, produtoId);
                }
                else
                {
                    Mensagem = MeuAdapterProdutos.InserirProdutos(
                     TxtCodigo.Text, TxtDescricao.Text, TxtUnidade.Text,
                     pesoBruto, pesoLiquido,
                     classe, grupo, familia, departamento,
                     qtdeSaldo, custoMedio, valorSaldo,
                     dataCadastro, cmbSituacao.Text, dataUltCompra, TxtLocalArmazenamento.Text);


                }

                if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção!");

                LimparCampos();
                MeuAdapterProdutos.MontarLista("");
                GridLista.DataSource = MeuAdapterProdutos.DtProdutos;
                base.BtnConfirmar_Click(sender, e);
            }


        }


        public override void BtnExcluir_Click(object sender, EventArgs e)
        {
            string Mensagem = "";
            if (GridLista.SelectedRows.Count > 0)
            {
                DataRowView linha =
               (DataRowView)GridLista.Rows[GridLista.SelectedRows[0].Index].DataBoundItem;
                if (MessageBox.Show(string.Format("Deseja Excluir {0}?",
               linha["Descricao"]), "Atenção",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Mensagem = MeuAdapterProdutos.ExcluirProdutos(Convert.ToInt32(LblProdutoId.Text));
                    if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção!");
                    LimparCampos();
                    MeuAdapterProdutos.MontarLista("");
                    GridLista.DataSource = MeuAdapterProdutos.DtProdutos;
                    base.BtnExcluir_Click(sender, e);
                }
            }
            else
                MessageBox.Show("Favor selecionar um item para excluir", "Atenção");
            base.BtnExcluir_Click(sender, e);

        }
    }
}
    

