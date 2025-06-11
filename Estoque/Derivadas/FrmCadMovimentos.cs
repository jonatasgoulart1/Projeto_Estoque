using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estoque.Base;
using Estoque.BLL;

namespace Estoque.Derivadas
{
    public partial class FrmCadMovimentos : FrmTemplateBase
    {
        public FrmCadMovimentos()
        {
            InitializeComponent();
        }
        BLL_Movimentos MeuAdapterMovimentos = new BLL_Movimentos();


        public override void FrmTemplateBase_Load(object sender, EventArgs e)
        {
            GridLista.Columns[0].DataPropertyName = "Produto";
            GridLista.Columns[0].HeaderText = "Descricao do  Produto";
            MeuAdapterMovimentos.MontarLista("");

            ExibirTitulo("Cadastro do Movimento");
            GridLista.DataSource = MeuAdapterMovimentos.DtMovimentos;
            base.FrmTemplateBase_Load(sender, e);
        }

        public override void TxtLocalizar_TextChanged(object sender, EventArgs e)
        {
            MeuAdapterMovimentos.MontarLista(TxtLocalizar.Text);
            GridLista.DataSource = MeuAdapterMovimentos.DtMovimentos;
            base.TxtLocalizar_TextChanged(sender, e);
        }
        public override void GridLista_SelectionChanged(object sender, EventArgs e)
        {
            if (GridLista.SelectedRows.Count > 0)
            {
                DataRowView linha =
                (DataRowView)GridLista.Rows[GridLista.SelectedRows[0].Index].DataBoundItem;
                lblMovimentoID.Text = linha["MovimentoID"].ToString();
                cmbProduto.Text = linha["Produto"].ToString();
                txtNrDocumento.Text = linha["NrDocumento"].ToString();
                dtpDataDocumento.Text = linha["DataDocumento"].ToString();
                txtSequencia.Text = linha["Sequencia"].ToString();
                TxtTipoMov.Text = linha["TipoMov"].ToString();
                txtQtde.Text = linha["Qtde"].ToString();
                txtCustoUnitario.Text = linha["CustoUnitario"].ToString();
                txtValorMovimento.Text = linha["ValorMovimento"].ToString();
                txtQtdeSaldo.Text = linha["QtdeSaldo"].ToString();
                txtCustoUnitarioSaldo.Text = linha["CustoUnitarioSaldo"].ToString();
                txtValorSaldo.Text = linha["ValorSaldo"].ToString();
                cmbFornecedor.Text = linha["Fornecedor"].ToString();


            }
            base.GridLista_SelectionChanged(sender, e);
        }
        void LimparCampos()
        {
            lblMovimentoID.Text = "";
            cmbProduto.SelectedIndex = -1;
            cmbProduto.Text = "";
            txtNrDocumento.Clear();
            dtpDataDocumento.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtSequencia.Clear();
            TxtTipoMov.Clear();
            txtQtde.Clear();
            txtCustoUnitario.Clear();
            txtValorMovimento.Clear();
            txtQtdeSaldo.Clear();
            txtCustoUnitarioSaldo.Clear();
            txtValorSaldo.Clear();
            cmbFornecedor.SelectedIndex = -1;
            cmbFornecedor.Text = "";
        }

        public override void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            base.BtnNovo_Click(sender, e);
        }



        public override void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string Mensagem = "";

            if (string.IsNullOrEmpty(cmbProduto.Text) ||
                string.IsNullOrEmpty(txtNrDocumento.Text) ||
                string.IsNullOrEmpty(txtSequencia.Text) ||
                string.IsNullOrEmpty(TxtTipoMov.Text) ||
                string.IsNullOrEmpty(txtQtde.Text) ||
                string.IsNullOrEmpty(txtCustoUnitario.Text) ||
                string.IsNullOrEmpty(txtValorMovimento.Text) ||
                string.IsNullOrEmpty(txtQtdeSaldo.Text) ||
                string.IsNullOrEmpty(txtCustoUnitarioSaldo.Text) ||
                string.IsNullOrEmpty(txtValorSaldo.Text) ||
                string.IsNullOrEmpty(cmbFornecedor.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            else
            {

                 int produto = Convert.ToInt32(cmbProduto.Text);
                int nrDocumento = Convert.ToInt32(txtNrDocumento.Text);
                DateTime dataDocumento = Convert.ToDateTime(dtpDataDocumento.Text);
                int sequencia = Convert.ToInt32(txtSequencia.Text);
                int tipoMov = Convert.ToInt32(TxtTipoMov.Text);
                decimal qtde = Convert.ToDecimal(txtQtde.Text);
                decimal custoUnitario = Convert.ToDecimal(txtCustoUnitario.Text);
                decimal valorMovimento = Convert.ToDecimal(txtValorMovimento.Text);
                decimal qtdeSaldo = Convert.ToDecimal(txtQtdeSaldo.Text);
                decimal custoUnitarioSaldo = Convert.ToDecimal(txtCustoUnitarioSaldo.Text);
                decimal valorSaldo = Convert.ToDecimal(txtValorSaldo.Text);
                int fornecedor = Convert.ToInt32(cmbFornecedor.Text);

                if (!string.IsNullOrEmpty(lblMovimentoID.Text))
                {
                    int movimentoID = Convert.ToInt32(lblMovimentoID.Text);
                    Mensagem = MeuAdapterMovimentos.AlterarMovimento(
                        movimentoID,
                        produto,
                        nrDocumento,
                        dataDocumento,
                        sequencia,
                        tipoMov,
                        qtde,
                        custoUnitario,
                        valorMovimento,
                        qtdeSaldo,
                        custoUnitarioSaldo,
                        valorSaldo,
                        fornecedor);
                }
                else
                {
                    Mensagem = MeuAdapterMovimentos.InserirMovimento(
                        produto,
                        nrDocumento,
                        dataDocumento,
                        sequencia,
                        tipoMov,
                        qtde,
                        custoUnitario,
                        valorMovimento,
                        qtdeSaldo,
                        custoUnitarioSaldo,
                        valorSaldo,
                        fornecedor);
                }

                if (Mensagem != "")
                    MessageBox.Show(Mensagem, "Atenção!");

                LimparCampos();
                MeuAdapterMovimentos.MontarLista("");
                GridLista.DataSource = MeuAdapterMovimentos.DtMovimentos;
                base.BtnConfirmar_Click(sender, e);
                if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção!");

                LimparCampos();
                MeuAdapterMovimentos.MontarLista("");
                GridLista.DataSource = MeuAdapterMovimentos.DtMovimentos;
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
               linha["Produto"]), "Atenção",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Mensagem = MeuAdapterMovimentos.ExcluirMovimentos(Convert.ToInt32(lblMovimentoID.Text));
                    if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção!");
                    LimparCampos();
                    MeuAdapterMovimentos.MontarLista("");
                    GridLista.DataSource = MeuAdapterMovimentos.DtMovimentos;
                    base.BtnExcluir_Click(sender, e);
                }
            }
            else
                MessageBox.Show("Favor selecionar um item para excluir", "Atenção");
            base.BtnExcluir_Click(sender, e);

        }
    }
}
