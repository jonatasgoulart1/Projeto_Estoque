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
using static Estoque.BLL.BLL_Familias;

namespace Estoque.Derivadas
{
    public partial class FrmCadFamilias : FrmTemplateBase
    {
        public FrmCadFamilias()
        {
            InitializeComponent();
        }
        BLL_Familias MeuAdapterFamilias = new BLL_Familias();


        public override void FrmTemplateBase_Load(object sender, EventArgs e)
        {
            GridLista.Columns[0].DataPropertyName = "Descricao";
            GridLista.Columns[0].HeaderText = "Descricao da  Familia";
            MeuAdapterFamilias.MontarLista("");

            ExibirTitulo("Cadastro das Familias");
            GridLista.DataSource = MeuAdapterFamilias.DtFamilias;
            base.FrmTemplateBase_Load(sender, e);
        }

        public override void TxtLocalizar_TextChanged(object sender, EventArgs e)
        {
            MeuAdapterFamilias.MontarLista(TxtLocalizar.Text);
            GridLista.DataSource = MeuAdapterFamilias.DtFamilias;
            base.TxtLocalizar_TextChanged(sender, e);
        }
        public override void GridLista_SelectionChanged(object sender, EventArgs e)
        {
            if (GridLista.SelectedRows.Count > 0)
            {
                DataRowView linha =
                    (DataRowView)GridLista.Rows[GridLista.SelectedRows[0].Index].DataBoundItem;
                LblFamiliaId.Text = linha["FamiliaId"].ToString();
                txtDescricao.Text = linha["Descricao"].ToString();


            }
            base.GridLista_SelectionChanged(sender, e);
        }

        void LimparCampos()
        {
            LblFamiliaId.Text = "";
            txtDescricao.Clear();
        }

        public override void BtnNovo_Click(object sender, EventArgs e)

        {
            LimparCampos();
            base.BtnNovo_Click(sender, e);

        }
        public override void BtnConfirmar_Click(object sender, EventArgs e)
        {

            string Mensagem = "";
            if (string.IsNullOrEmpty(txtDescricao.Text))


            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos.", "Atenção",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (LblFamiliaId.Text != "")
                    Mensagem = MeuAdapterFamilias.AlterarFamilias(txtDescricao.Text,
                   Convert.ToInt32(LblFamiliaId.Text));


                else Mensagem = MeuAdapterFamilias.InserirFamilias(txtDescricao.Text);


                if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção!");

                LimparCampos();
                MeuAdapterFamilias.MontarLista("");
                GridLista.DataSource = MeuAdapterFamilias.DtFamilias;
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
                    Mensagem = MeuAdapterFamilias.ExcluirFamilias(Convert.ToInt32(LblFamiliaId.Text));
                    if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção!");
                    LimparCampos();
                    MeuAdapterFamilias.MontarLista("");
                    GridLista.DataSource = MeuAdapterFamilias.DtFamilias;
                    base.BtnExcluir_Click(sender, e);
                }
            }
            else
                MessageBox.Show("Favor selecionar um item para excluir", "Atenção");
            base.BtnExcluir_Click(sender, e);

        }
    }
}


