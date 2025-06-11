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
    public partial class FrmCadGrupos : FrmTemplateBase
    {
        public FrmCadGrupos()
        {
            InitializeComponent();
        }
        BLL_Grupos MeuAdapterGrupos = new BLL_Grupos();


        public override void FrmTemplateBase_Load(object sender, EventArgs e)
        {
            GridLista.Columns[0].DataPropertyName = "Descricao";
            GridLista.Columns[0].HeaderText = "Descricao do Grupo";
            MeuAdapterGrupos.MontarLista("");

            ExibirTitulo("Cadastro dos Grupos");
            GridLista.DataSource = MeuAdapterGrupos.DtGrupos;
            base.FrmTemplateBase_Load(sender, e);
        }

        public override void TxtLocalizar_TextChanged(object sender, EventArgs e)
        {
            MeuAdapterGrupos.MontarLista(TxtLocalizar.Text);
            GridLista.DataSource = MeuAdapterGrupos.DtGrupos;
            base.TxtLocalizar_TextChanged(sender, e);
        }
        public override void GridLista_SelectionChanged(object sender, EventArgs e)
        {
            if (GridLista.SelectedRows.Count > 0)
            {
                DataRowView linha =
                    (DataRowView)GridLista.Rows[GridLista.SelectedRows[0].Index].DataBoundItem;
                LblGrupoId.Text = linha["GrupoId"].ToString();
                txtAbreviatura.Text = linha["Abreviatura"].ToString();
                txtDescricao.Text = linha["Descricao"].ToString();


            }
            base.GridLista_SelectionChanged(sender, e);
        }
        void LimparCampos()
        {
            LblGrupoId.Text = "";
            txtDescricao.Clear();
            txtAbreviatura.Clear();
        }

        public override void BtnNovo_Click(object sender, EventArgs e)

        {
            LimparCampos();
            base.BtnNovo_Click(sender, e);

        }
        public override void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string Mensagem = "";

            if (String.IsNullOrEmpty(txtDescricao.Text) ||
               String.IsNullOrEmpty(txtAbreviatura.Text))

            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos.", "Atenção",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
             
            }
            else
            {
                if (LblGrupoId.Text != "")

                    Mensagem = MeuAdapterGrupos.AlterarGrupos(
                        Convert.ToInt32(LblGrupoId.Text), txtDescricao.Text, txtAbreviatura.Text);

                else Mensagem = MeuAdapterGrupos.InserirGrupos(txtDescricao.Text, txtAbreviatura.Text);


                if (!string.IsNullOrEmpty(Mensagem)) MessageBox.Show(Mensagem, "Atenção!");
                LimparCampos();
                MeuAdapterGrupos.MontarLista("");
                GridLista.DataSource = MeuAdapterGrupos.DtGrupos;
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
                    Mensagem = MeuAdapterGrupos.ExcluirGrupos(Convert.ToInt32(LblGrupoId.Text));
                    if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção!");
                    LimparCampos();
                    MeuAdapterGrupos.MontarLista("");
                    GridLista.DataSource = MeuAdapterGrupos.DtGrupos;
                    base.BtnExcluir_Click(sender, e);
                }
            }
            else
                MessageBox.Show("Favor selecionar um item para excluir", "Atenção");
            base.BtnExcluir_Click(sender, e);

        }

    }
}

