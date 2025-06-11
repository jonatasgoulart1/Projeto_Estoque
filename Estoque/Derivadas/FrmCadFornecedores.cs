using Estoque.Base;
using Estoque.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Derivadas
{
    public partial class FrmCadFornecedores : FrmTemplateBase
    {
        public FrmCadFornecedores()
        {
            InitializeComponent();
        }

        BLL_Fornecedores MeuAdapterFornecedores = new BLL_Fornecedores();


        public override void FrmTemplateBase_Load(object sender, EventArgs e)
        {
            GridLista.Columns[0].DataPropertyName = "RazaoSocial";
            GridLista.Columns[0].HeaderText = "Descricao da RazaoSocial";
            MeuAdapterFornecedores.MontarLista("");

            ExibirTitulo("Cadastro dos Fornecedores");
            GridLista.DataSource = MeuAdapterFornecedores.DtFornecedores;
            base.FrmTemplateBase_Load(sender, e);
        }

        public override void TxtLocalizar_TextChanged(object sender, EventArgs e)
        {
            MeuAdapterFornecedores.MontarLista(TxtLocalizar.Text);
            GridLista.DataSource = MeuAdapterFornecedores.DtFornecedores;
            base.TxtLocalizar_TextChanged(sender, e);
        }
        public override void GridLista_SelectionChanged(object sender, EventArgs e)
        {
            if (GridLista.SelectedRows.Count > 0)
            {
                DataRowView linha =
                    (DataRowView)GridLista.Rows[GridLista.SelectedRows[0].Index].DataBoundItem;
                LblFornecedorID.Text = linha["FornecedorID"].ToString();
                TxtRazaoSocial.Text = linha["RazaoSocial"].ToString();
                TxtEndereco.Text = linha["Endereco"].ToString();
                TxtCidade.Text = linha["Cidade"].ToString();
                CmbUf.Text = linha["UF"].ToString();
                Txtcep.Text = linha["cep"].ToString();
                TxtTelefone.Text = linha["Telefone"].ToString();
                TxtCelular.Text = linha["Celular"].ToString();
                TxtEmail.Text = linha["Email"].ToString();
                TxtSite.Text = linha["Site"].ToString();
                TxtObservacoes.Text = linha["Observacoes"].ToString();
            }
            base.GridLista_SelectionChanged(sender, e);
        }
        void LimparCampos()
        {
            LblFornecedorID.Text = "";
            TxtRazaoSocial.Clear();
            TxtEndereco.Clear();
            TxtCidade.Clear();
            CmbUf.SelectedIndex = -1;
            Txtcep.Clear();
            TxtTelefone.Clear();
            TxtCelular.Clear();
            TxtEmail.Clear();
            TxtSite.Clear();
            TxtObservacoes.Clear();
        }

        public override void BtnNovo_Click(object sender, EventArgs e)

        {
            LimparCampos();
            base.BtnNovo_Click(sender, e);

        }
        public override void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string mensagem = "";


            if (string.IsNullOrEmpty(TxtRazaoSocial.Text) ||
                string.IsNullOrEmpty(TxtEndereco.Text) ||
                string.IsNullOrEmpty(TxtCidade.Text) ||
                string.IsNullOrEmpty(CmbUf.Text) ||
                string.IsNullOrEmpty(Txtcep.Text) ||
                string.IsNullOrEmpty(TxtTelefone.Text) ||
                string.IsNullOrEmpty(TxtCelular.Text) ||
                string.IsNullOrEmpty(TxtEmail.Text) ||
                string.IsNullOrEmpty(TxtSite.Text))
            {
                MessageBox.Show("Obrigatório preencher todos os campos obrigatórios.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (!string.IsNullOrEmpty(LblFornecedorID.Text))
                {
                    mensagem = MeuAdapterFornecedores.AlterarFornecedor(
                        Convert.ToInt32(LblFornecedorID.Text),
                        TxtRazaoSocial.Text,
                        TxtEndereco.Text,
                        TxtCidade.Text,
                        CmbUf.Text,
                        Txtcep.Text,
                        TxtTelefone.Text,
                        TxtCelular.Text,
                        TxtEmail.Text,
                        TxtSite.Text,
                        TxtObservacoes.Text
                    );
                }
                else
                {
                    mensagem = MeuAdapterFornecedores.InserirFornecedores(
                        TxtRazaoSocial.Text,
                        TxtEndereco.Text,
                        TxtCidade.Text,
                        CmbUf.Text,
                        Txtcep.Text,
                        TxtTelefone.Text,
                        TxtCelular.Text,
                        TxtEmail.Text,
                        TxtSite.Text,
                        TxtObservacoes.Text
                    );
                }

                if (mensagem != "") MessageBox.Show(mensagem, "Atenção!");

                LimparCampos();
                MeuAdapterFornecedores.MontarLista("");
                GridLista.DataSource = MeuAdapterFornecedores.DtFornecedores;

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
               linha["Parametro"]), "Atenção",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Mensagem = MeuAdapterFornecedores.ExcluirFornecedores(Convert.ToInt32(LblFornecedorID.Text));
                    if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção!");
                    LimparCampos();
                    MeuAdapterFornecedores.MontarLista("");
                    GridLista.DataSource = MeuAdapterFornecedores.DtFornecedores;
                    base.BtnExcluir_Click(sender, e);
                }
            }
            else
                MessageBox.Show("Favor selecionar um item para excluir", "Atenção");
            base.BtnExcluir_Click(sender, e);
        }
    }
}

        